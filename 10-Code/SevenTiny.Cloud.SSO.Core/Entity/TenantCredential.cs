﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SevenTiny.Cloud.SSO.Core.Entity
{
    /// <summary>
    /// 租户凭据
    /// </summary>
    public class TenantCredential
    {
        /// <summary>
        /// 租户Id，自增
        /// </summary>
        public int TenantId { get; set; }
        /// <summary>
        /// 租户名称
        /// </summary>
        public string TenantName { get; set; }
        /// <summary>
        /// 开通时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpiredTime { get; set; }
    }
}
