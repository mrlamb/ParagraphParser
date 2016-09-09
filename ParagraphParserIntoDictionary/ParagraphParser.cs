using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParagraphParserIntoDictionary
{
    public class ParagraphParser :SortedDictionary<string, List<String>>
    {
        public ParagraphParser(string WallOfText)
        {
            string[] split = WallOfText.Split(new char[] { ',', '!', ' ', '.',
                '"','-','*','[',']','#','(',')',':',';','_','?','/','\\' },
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < split.Length; i++)
            {
                if (!this.ContainsKey(split[i]))
                {
                    this.Add(split[i], new List<String>());
                    if (!(i + 1 == split.Length))
                        this[split[i]].Add(split[i + 1]);
                }
                else
                {
                    if (!(i + 1 == split.Length))
                        this[split[i]].Add(split[i + 1]);

                }
            }
        }
    }
}
