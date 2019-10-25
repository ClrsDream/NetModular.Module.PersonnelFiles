using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities.Extend;

namespace NetModular.Module.PersonnelFiles.Domain.Department
{
    /// <summary>
    /// 部门
    /// </summary>
    [Table("Department")]
    public partial class DepartmentEntity : EntityBase
    {
        /// <summary>
        /// 公司编号
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Length(100)]
        public string Name { get; set; }

        /// <summary>
        /// 父节点
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        public Guid Leader { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
    }
}
