﻿using System.Threading.Tasks;
using NetModular.Lib.Utils.Core.Result;
using NetModular.Module.PersonnelFiles.Application.UserWorkHistoryService.ViewModels;
using NetModular.Module.PersonnelFiles.Domain.UserWorkHistory.Models;

namespace NetModular.Module.PersonnelFiles.Application.UserWorkHistoryService
{
    /// <summary>
    /// 用户工作经历服务
    /// </summary>
    public interface IUserWorkHistoryService
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Query(UserWorkHistoryQueryModel model);

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Add(UserWorkHistoryAddModel model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        Task<IResultModel> Delete(int id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResultModel> Edit(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResultModel> Update(UserWorkHistoryUpdateModel model);
    }
}
