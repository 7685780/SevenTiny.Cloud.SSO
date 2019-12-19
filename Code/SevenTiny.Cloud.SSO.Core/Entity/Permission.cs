using System;
using System.Collections.Generic;
using System.Text;

namespace SevenTiny.Cloud.SSO.Core.Entity
{
    /// <summary>
    /// 权限【权限配置维护】
    /// </summary>
    public class Permission
    {
        /// <summary>
        /// 主键【自增】
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 应用Id
        /// </summary>
        public int ApplicationId { get; set; }
        /// <summary>
        /// 权限编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否有权限
        /// </summary>
        public int HasPermission { get; set; }
    }
}
