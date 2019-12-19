using System;
using System.Collections.Generic;
using System.Text;

namespace SevenTiny.Cloud.SSO.Core.Entity
{
    /// <summary>
    /// 用户账号
    /// </summary>
    public class UserAccount
    {
        /// <summary>
        /// Id【主键】
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 租户Id
        /// </summary>
        public int TenantId { get; set; }
        /// <summary>
        /// 权限组织
        /// </summary>
        public int GoupId { get; set; }
        /// <summary>
        /// 账号名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 密码【加盐处理】
        /// </summary>
        public string Password { get; set; }
    }
}
