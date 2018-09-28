using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeepCommon
{
    /// <summary>
    /// 执行结果
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        /// 是否执行成功
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 构建一个没有错误的结果
        /// </summary>
        public ServiceResult()
        {
            IsSuccess = true;
            ErrorCode = 0;
            Message = string.Empty;
        }

        /// <summary>
        /// 构建有错误的结果
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        public ServiceResult(int errorCode, string message)
        {
            IsSuccess = false;
            ErrorCode = errorCode;
            Message = message;
        }
    }
}
