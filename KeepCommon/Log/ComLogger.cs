using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepCommon.Log
{
    public static class ComLogger
    {
        /// <summary>
        /// 实例化Logger对象，默认logger的名称是当前类的名称（包括类所在的命名空间名称）
        /// 日志级别 Trace|Debug|Info|Warn|Error|Fatal
        /// </summary>
        static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 最常见的记录信息，一般用于普通输出
        /// </summary>
        /// <param name="msg">日志内容</param>
        public static void Trace(string msg)
        {
            logger.Trace(() => msg);
        }
        /// <summary>
        /// 最常见的记录信息带Tag
        /// </summary>
        /// <param name="tag">方法名</param>
        /// <param name="msg"></param>
        public static void TraceTag(string tag, string msg)
        {
            string strSql = string.Format(@"[{0}]{1}", tag, msg);
            logger.Trace(() => strSql);
        }
        /// <summary>
        /// 调试日志,一般用来调试程序
        /// </summary>
        /// <param name="msg">日志内容</param>
        public static void Debug(string msg)
        {
            logger.Debug(() => msg);
        }
        /// <summary>
        /// 调试日志带Tag
        /// </summary>
        /// <param name="tag">方法名</param>
        /// <param name="msg"></param>
        public static void DebugTag(string tag, string msg)
        {
            string strSql = string.Format(@"[{0}]{1}", tag, msg);
            logger.Debug(() => strSql);
        }
        /// <summary>
        /// 信息类型的消息
        /// </summary>
        /// <param name="msg">日志内容</param>
        public static void Info(string msg)
        {
            logger.Info(() => msg);
        }
        /// <summary>
        /// 信息类型的消息带Tag
        /// </summary>
        /// <param name="tag">方法名</param>
        /// <param name="msg"></param>
        public static void InfoTag(string tag, string msg)
        {
            string strSql = string.Format(@"[{0}]{1}", tag, msg);
            logger.Info(() => strSql);
        }
        /// <summary>
        /// 警告信息，一般用于比较重要的场合
        /// </summary>
        /// <param name="msg">日志内容</param>
        public static void Warn(string msg)
        {
            logger.Warn(() => msg);
        }
        /// <summary>
        /// 警告信息带Tag
        /// </summary>
        /// <param name="tag">方法名</param>
        /// <param name="msg"></param>
        public static void WarnTag(string tag, string msg)
        {
            string strSql = string.Format(@"[{0}]{1}", tag, msg);
            logger.Warn(() => strSql);
        }
        /// <summary>
        /// 错误日志
        /// </summary>
        /// <param name="msg">日志内容</param>
        public static void Error(string msg)
        {
            logger.Error(() => msg);
        }
        /// <summary>
        /// 错误日志带Tag
        /// </summary>
        /// <param name="tag">方法名</param>
        /// <param name="msg"></param>
        public static void ErrorTag(string tag, string msg)
        {
            string strSql = string.Format(@"[{0}]{1}", tag, msg);
            logger.Error(() => strSql);
        }
        /// <summary>
        /// 致命异常信息。
        /// 用于，发生致命异常之后程序将无法继续执行。
        /// </summary>
        /// <param name="msg">日志内容</param>
        public static void Fatal(string msg)
        {
            logger.Fatal(() => msg);
        }
        /// <summary>
        /// 致命异常信息日志带Tag
        /// </summary>
        /// <param name="tag">方法名</param>
        /// <param name="msg"></param>
        public static void FatalTag(string tag, string msg)
        {
            string strSql = string.Format(@"[{0}]{1}", tag, msg);
            logger.Fatal(() => strSql);
        }
    }
}
