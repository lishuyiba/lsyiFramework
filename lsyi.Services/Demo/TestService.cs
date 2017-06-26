using lsyi.Core.Dependency;
using System;

namespace lsyi.Services.Demo
{
    /// <summary>
    /// 
    /// lsy
    /// 
    /// 2017/6/26 上午11:30:13
    /// 
    /// 测试
    /// 
    /// </summary>
    public class TestService : ITest
    {
        public string GetStrTest()
        {
            return "成功返回字符串！";
        }


    }
}
