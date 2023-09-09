using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006.go关键字的用法
{
    internal class Login
    {
        /// <summary>
        /// goto用法，代码跳转到指定语句块继续执行。
        /// 这里演示：如果用户名，密码正确直接跳转到程序结尾执行
        /// </summary>
        /// <param name="loginName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public string ValidateLogin(string loginName, string pwd)
        {
            if (loginName == "admin" && pwd == "123456")
            {
                goto Finished;
            }
            if (loginName != "admin")
            {
                return "验证失败，用户名错误";
            }
            if (pwd == "123456")
            {
                return "验证失败，密码错误";
            }

            Finished:
            return "验证成功";
        }
    }
}
