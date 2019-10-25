using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.PersonnelFiles.Application.DepartmentService;
using NetModular.Module.PersonnelFiles.Application.DepartmentService.ViewModels;
using NetModular.Module.PersonnelFiles.Domain.Department.Models;

namespace NetModular.Module.PersonnelFiles.Web.Controllers
{
    [Description("部门管理")]
    public class DepartmentController : ModuleController
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }

        [HttpGet]
        [Description("部门树")]
        public async Task<IResultModel> Tree([BindRequired] Guid companyId)
        {
            return await _service.GetTree(companyId);
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery] DepartmentQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpPost]
        [Description("添加")]
        public Task<IResultModel> Add(DepartmentAddModel model)
        {
            return _service.Add(model);
        }

        [HttpDelete]
        [Description("删除")]
        public async Task<IResultModel> Delete([BindRequired] Guid id)
        {
            return await _service.Delete(id);
        }

        [HttpGet]
        [Description("编辑")]
        public async Task<IResultModel> Edit([BindRequired] Guid id)
        {
            return await _service.Edit(id);
        }

        [HttpPost]
        [Description("修改")]
        public Task<IResultModel> Update(DepartmentUpdateModel model)
        {
            return _service.Update(model);
        }
    }
}
