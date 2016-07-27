using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptCs.Contracts;

namespace ScriptCsTest
{
    public class TestPack : IScriptPackContext
    {
        public void Hello(string s)
        {
            Console.WriteLine($"Hello {s}!");
        }
    }

    public class TestScriptPack : IScriptPack
    {
        public void Initialize(IScriptPackSession session)
        {
            
        }

        public IScriptPackContext GetContext()
        {
            return new TestPack();
        }

        public void Terminate()
        {
            
        }
    }
}
