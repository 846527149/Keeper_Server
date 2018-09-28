using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KeepCommon
{
    /// <summary>
    /// 分页结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedResult<T> : ServiceResult
    {
        public PageResultData<T> Data { get; set; }

        /// <summary>
        /// 构建一个没有错误的结果
        /// </summary>
        /// <param name="data"></param>
        public PagedResult(int start, int limit, int total, List<T> items)
            : base()
        {
            Data = new PageResultData<T>(start, limit, total, items);
            IsSuccess = true;
            ErrorCode = 0;
            Message = string.Empty;
        }
        public PagedResult(int start, int limit, int total,  T[] items)
            : base()
        {
            Data = new PageResultData<T>(start, limit, total, items);
            IsSuccess = true;
            ErrorCode = 0;
            Message = string.Empty;
        }

        /// <summary>
        /// 构建一个错误的结果
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        public PagedResult(int errorCode, string message)
        {
            IsSuccess = false;
            ErrorCode = errorCode;
            Message = message;
        }

        public PagedResult()
        {
        }
    }

    /// <summary>
    /// 分页数据
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageResultData<T>
    {
        public int Start { get; set; }
        public int Limit { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public List<T> Items { get; set; }

        public PageResultData(int start, int limit, int total, List<T> items)
            : base()
        {
            Items = items;
            Start = start;
            Limit = limit;
            Total = total;
            Count = items.Count;
        }

        public PageResultData(int start, int limit, int total, T[] items)
            : base()
        {
            Items = new List<T>();
            Items.AddRange(items);
            Start = start;
            Limit = limit;
            Total = total;
            Count = items.Length;
        }

        public PageResultData()
        {
        }
    }
}
