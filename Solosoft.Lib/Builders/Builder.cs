using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solosoft.Lib.Builders
{
    public class Builder
    {
        public IEnumerable<int> BuildIntegerSequence()
        {
            var integers = Enumerable.Range(1, 10)
                .Select(i=> (i *i));
            return integers;

        }

        public IEnumerable<string> BuildStringSequence()
        {

            var rand = new Random();

          //  var randomdomm random.Next(1, 26);

            var strings = Enumerable.Range(0, 10)
               .Select(i=>((char)('A' + rand.Next(0,26))).ToString());

            return strings;
        }

        public IEnumerable<int> CompareSequensence()
        {
           var seq1 = Enumerable.Range(0, 10);
            var seq2 = Enumerable.Range(0, 10)
                .Select(i => (i*i));

          // return seq1.Concat(seq2).Distinct();
            return seq1.Except(seq2);

        } 

    }
}
