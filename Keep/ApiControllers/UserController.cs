using KeepCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common = KeepCommon;

namespace Keep.ApiControllers
{
    public class UserController : ApiController
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="params">params</param>
        /// <returns></returns>
        [HttpPost]
        public ServiceResult Login(LoginParams @params)
        {
            return new ServiceResult();
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet]
        public Common.SingleResult<UserInfo> Info() {
            UserInfo info = new UserInfo();
            info.Roles = new object[5];
            info.Name = "test";
            info.Avatar = "http://demo.eeejian.com/Upload/photo/u/7cd920620a6746728b35bfbc8a936bdf.jpg";
            return new Common.SingleResult<UserInfo>(info);
        }
        /// <summary>
        /// 退出登录
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ServiceResult Logout() {
            return new ServiceResult();
        }
        /// <summary>
        /// 登录params
        /// </summary>
        public class LoginParams
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        /// <summary>
        /// 用户信息
        /// </summary>
        public class UserInfo {
            /// <summary>
            /// 权限
            /// </summary>
            public object[] Roles { get; set; }
            /// <summary>
            /// 姓名
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 头像
            /// </summary>
            public string Avatar { get; set; }
        }
    }
}