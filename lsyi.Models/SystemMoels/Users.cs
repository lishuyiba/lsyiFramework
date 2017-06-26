using System;
using System.Collections.Generic;
using System.Text;

namespace lsyi.Models.SystemMoels
{
    public partial class Users
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleID { get; set; }
        /// <summary>
        /// 删除标记
        /// </summary>
        public int DelFlag { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastEditTime { get; set; }
    }
}
