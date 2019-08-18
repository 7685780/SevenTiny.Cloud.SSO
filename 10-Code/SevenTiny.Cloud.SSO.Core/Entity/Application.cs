using System;
using System.Collections.Generic;
using System.Text;

namespace SevenTiny.Cloud.SSO.Core.Entity
{
    /// <summary>
    /// 应用，具体的权限控制单位
    /// </summary>
    public class Application
    {
        /// <summary>
        /// 应用Id【主键】
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 分组Id【组1-*应用】
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// 应用名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 应用描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 应用具体权限【Dictionary<code,haspermission(bool)>】的Json集合,不存过多的无用字段
        /// </summary>
        public string PermissionJson { get; set; }
    }
}
