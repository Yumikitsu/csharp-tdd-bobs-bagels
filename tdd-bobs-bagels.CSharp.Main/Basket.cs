using Microsoft.Win32.SafeHandles;
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
        int capacity = 1;
        public bool Add(string bagel)
        {
            if(IsFull())
            {
                return false;
            }
            basket.Add(bagel);
            return true;
        }

        public bool Remove()
        {
            if (basket.Count > 0)
            {
                basket.RemoveAt(0);
                return true;
            }
            return false;
        }

        public bool IsFull()
        {
            if(basket.Count == capacity)
            {
                return true;
            }
            return false;
        }

        public bool SetCapacity(int size)
        {
            if (basket.Count < size)
            {
                basket.Capacity = size;
                return true;
            }
            return false;
        }

        public bool Remove(string bagel)
        {
            throw new NotImplementedException();
        }
    }
}
