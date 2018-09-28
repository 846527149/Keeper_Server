using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeepCommon
{
    /// <summary>
    /// 单个对象
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleResult<T> : ServiceResult
    {
        public T Data { get; set; }

        public SingleResult()
        {
        }

        /// <summary>
        /// 构建一个没有错误的结果
        /// </summary>
        /// <param name="data"></param>
        public SingleResult(T data)
            : base()
        {
            Data = data;
            IsSuccess = true;
            ErrorCode = 0;
            Message = string.Empty;
        }

        /// <summary>
        /// 构建一个错误的结果
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        public SingleResult(int errorCode, string message)
        {
            IsSuccess = false;
            ErrorCode = errorCode;
            Message = message;
        }


        public SingleResult(bool isSuccess, int errorCode, string message, T data)
        {
            IsSuccess = isSuccess;
            ErrorCode = errorCode;
            Message = message;
            Data = data;
        }
    }
}
