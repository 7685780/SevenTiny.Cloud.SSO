using System;
using System.Collections.Generic;
using System.Text;

namespace SevenTiny.Cloud.SSO.Core.Entity
{
    /// <summary>
    /// 组，权限基本单位
    /// </summary>
    public class Group
    {
        /// <summary>
        /// 组Id【主键】
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 所属的租户Id
        /// </summary>
        public int TenantId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
