using NetModular.Lib.Data.Abstractions.Attributes;

namespace NetModular.Module.PersonnelFiles.Domain.Post
{
    public partial class PostEntity
    {
        /// <summary>
        /// ְλ����
        /// </summary>
        [Ignore]
        public string PositionName { get; set; }
    }
}
