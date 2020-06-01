using System;

namespace GitPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            ///当前：release，修复bug
            Console.WriteLine("Hello World!");//master：avoid conflict
            //from master
            ///当前 master， 提交-1
            ///当前 master， 继续工作，提交-1
            ///当前 fg，提交-1
            ///当前 fg，pk提交
            ///当前 release，pk提交-2
        }
    }
}
