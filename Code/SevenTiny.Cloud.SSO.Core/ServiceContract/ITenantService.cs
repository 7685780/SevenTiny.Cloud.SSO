using SevenTiny.Bantina;
using SevenTiny.Cloud.SSO.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SevenTiny.Cloud.SSO.Core.ServiceContract
{
    public interface ITenantService
    {
        /// <summary>
        /// 添加租户
        /// </summary>
        /// <param name="tenantCredential"></param>
        /// <returns></returns>
        Result AddTenant(TenantCredential tenantCredential);
        /// <summary>
        /// 修改租户信息
        /// TenantId必传
        /// </summary>
        /// <param name="tenantCredential"></param>
        /// <returns></returns>
        Result UpdateTenantInfo(TenantCredential tenantCredential);
        /// <summary>
        /// 删除租户
        /// 同时删除租户相关配置信息
        /// </summary>
        /// <param name="tenantId"></param>
        /// <returns></returns>
        Result DeleteTenant(int tenantId);
    }
}
