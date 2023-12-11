using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovik.Classes.Helpers.JSON
{
    [Serializable]
    internal class Test
    {
        public string Tag;
        public List<string> Questions;
        public List<List<string>> Answers;

        public Test()
        {
            Questions= new List<string>();
            Answers= new List<List<string>>(); 
        }
    }
}
