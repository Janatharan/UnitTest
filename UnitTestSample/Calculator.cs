using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    public class Calculator
    {
        public int? Add(int? x, int? y)
        {
            if (x != null || y != null)
            {
                if (x > 100 || x < 0)
                    throw new ArgumentNullException("Input must be less than 100");
                return x + y;
            }
            return 0;
        }
    }

    public class CheckEmployee
    {
        public virtual Boolean CheckEmp()
        {
            throw new NotImplementedException();
        }
    }

    public class ProcessEmployee
    {
        public Boolean InsertEmployee(CheckEmployee objtmp)
        {
            objtmp.CheckEmp();
            return true;
        }
    }

    public class MyClass
    {
        public virtual string GetSomeString(IDependance objectThatITalkTo)
        {
            return objectThatITalkTo.GiveMeAString();
        }
    }

    public interface IDependance
    {
        string GiveMeAString();
    }

    public class TestClass
    {
        public string TestFun()
        {
            return "done";
        }
    }
}