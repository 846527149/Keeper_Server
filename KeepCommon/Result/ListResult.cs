using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeepCommon
{
    /// <summary>
    /// 返回分页
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListResult<T> : ServiceResult
    {
        public ListResultData<T> Data { get; set; }

        public ListResult()
            : base()
        {
            IsSuccess = true;
            ErrorCode = 0;
            Message = string.Empty;
        }

        /// <summary>
        /// 构建一个没有错误的结果
        /// </summary>
        /// <param name="data"></param>
        public ListResult(List<T> items)
            : base()
        {
            Data = new ListResultData<T>(items);
            IsSuccess = true;
            ErrorCode = 0;
            Message = string.Empty;
        }

        public ListResult(T[] items)
            : base()
        {
            Data = new ListResultData<T>(items);
            IsSuccess = true;
            ErrorCode = 0;
            Message = string.Empty;
        }

        /// <summary>
        /// 构建一个错误的结果
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        public ListResult(int errorCode, string message)
        {
            IsSuccess = false;
            ErrorCode = errorCode;
            Message = message;
        }
    }

    public class ListResultData<T>
    {
        private List<T> _items;

        public int Count { get; set; }
        public List<T> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                if (_items != null)
                {
                    Count = _items.Count;
                }
            }
        }

        public ListResultData()
        {
        }

        public ListResultData(List<T> items)
            : base()
        {
            Items = items;
        }
        public ListResultData(T[] items)
            : base()
        {
            Items = new List<T>(items);
        }
    }
}
