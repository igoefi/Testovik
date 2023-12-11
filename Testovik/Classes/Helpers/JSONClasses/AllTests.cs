using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovik.Classes.Helpers.JSON
{
    [Serializable]
    internal class AllTests
    {
        public List<Test> Tests;

        public void AddTest(Test test)
        {
            if(Tests == null)
                Tests = new List<Test>();
            Tests.Add(test);
        }
    }
}
