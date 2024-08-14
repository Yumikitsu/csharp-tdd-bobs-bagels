using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        List<string> basket = new List<string>();
        public bool Add(string bagel)
        {
            basket.Add(bagel);
            return true;
        }

        public bool Remove()
        {
            throw new NotImplementedException();
        }
    }
}
