using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lsyi.Core.Utility
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 日志类
    /// 
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public static void WriteLog(string message, Exception ex = null)
        {
            var dir = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(dir, "Log");
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            var fileName = Path.Combine(filePath, "lsy-framework-log.txt");
            try
            {
                File.AppendAllText(fileName, $"【INFO {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}】 {message}" + "\r\n");
                if (ex != null)
                {
                    File.AppendAllText(fileName, $"系统异常：{ex.ToString()}" + "\r\n");
                }
            }
            catch (Exception e)
            {
                if (e != null)
                {
                    File.AppendAllText(fileName, $"日志写入异常：{e.ToString()}" + "\r\n");
                }
            }
        }
    }
}
