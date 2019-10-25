using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.PersonnelFiles.Application.UserEducationHistoryService;
using NetModular.Module.PersonnelFiles.Application.UserEducationHistoryService.ViewModels;
using NetModular.Module.PersonnelFiles.Domain.UserEducationHistory.Models;

namespace NetModular.Module.PersonnelFiles.Web.Controllers
{
    [Description("用户教育经历管理")]
    public class UserEducationHistoryController : ModuleController
    {
        private readonly IUserEducationHistoryService _service;

        public UserEducationHistoryController(IUserEducationHistoryService service)
        {
            _service = service;
        }

        [HttpGet]
        [Description("查询")]
        public Task<IResultModel> Query([FromQuery] UserEducationHistoryQueryModel model)
        {
            return _service.Query(model);
        }

        [HttpPost]
        [Description("添加")]
        public Task<IResultModel> Add(UserEducationHistoryAddModel model)
        {
            return _service.Add(model);
        }

        [HttpDelete]
        [Description("删除")]
        public async Task<IResultModel> Delete([BindRequired] int id)
        {
            return await _service.Delete(id);
        }

        [HttpGet]
        [Description("编辑")]
        public async Task<IResultModel> Edit([BindRequired] int id)
        {
            return await _service.Edit(id);
        }

        [HttpPost]
        [Description("修改")]
        public Task<IResultModel> Update(UserEducationHistoryUpdateModel model)
        {
            return _service.Update(model);
        }
    }
}
