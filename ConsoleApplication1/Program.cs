using ParagraphParserIntoDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pp = new ParagraphParser("On old olympus, a man sat and sat. An old man was he and he sang to the trees.");
            Console.ReadLine();
        }
    }
}
