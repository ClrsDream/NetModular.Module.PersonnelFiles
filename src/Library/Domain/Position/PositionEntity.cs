using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities.Extend;

namespace NetModular.Module.PersonnelFiles.Domain.Position
{
    /// <summary>
    /// 岗位
    /// </summary>
    [Table("Position")]
    public partial class PositionEntity : EntityBase
    {
        /// <summary>
        /// 部门编码
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Length(100)]
        public string Name { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
    }
}
