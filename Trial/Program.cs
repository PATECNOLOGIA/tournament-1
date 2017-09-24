using System;
using System.Collections.Generic;
using System.Linq;
namespace Trial
{
    class Program
    {
        /*
         * Complete the function below.
         */
        static int[] rearrange(int[] elements)
        {
            List<int> result = new List<int>();
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();
            List<string> binaries = new List<string>();
            Dictionary<int, int> elementsBinary = new Dictionary<int, int>();
            for(int ndx = 0; ndx < elements.Length; ndx++)
            {
                string binary = Convert.ToString(elements[ndx], 2);
                //binaries.Add(binary);
                elementsBinary.Add(elements[ndx], binary.Count(c => c == '1'));
            }
            //foreach(var item in elementsBinary.OrderBy(o => o.Value))
            //{                             
            //    result.Add(item.Key);
            //}

            //result1 = elementsBinary.OrderBy(o => o.Key).Select(s => s.Key).ToList();

            var orderedElementsBinary = elementsBinary.OrderBy(o => o.Value).ToDictionary(f => f.Key, f => f.Value);
            int binaryValue = 0;
            for (int ndx = 0; ndx < orderedElementsBinary.Count; ndx++)
            {
                var item = orderedElementsBinary.ElementAt(ndx);
                if (ndx == 0) binaryValue = item.Value;
                if (ndx > 0 && item.Value > binaryValue)
                {
                    binaryValue = item.Value;
                    result1.Add(item.Key);
                }
                else
                {
                    binaryValue = item.Value;
                    result2.Add(item.Key);
                }
            }
            return result.ToArray();
        }


        // DO NOT MODIFY CODE BELOW THIS LINE!
        static void Main(String[] args)
        {
            int[] res;

            int _elements_size = 0;
            _elements_size = Convert.ToInt32(Console.ReadLine());
            int[] _elements = new int[_elements_size];
            int _elements_item;
            for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++)
            {
                _elements_item = Convert.ToInt32(Console.ReadLine());
                _elements[_elements_i] = _elements_item;
            }

            res = rearrange(_elements);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }
    }
}