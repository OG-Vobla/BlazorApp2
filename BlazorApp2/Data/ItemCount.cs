using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp2.Data
{
    public class ItemCount
    {
        public ItemCount(int count, Item item)
        {
            Count = count;
            Item = item;
        }

        
        public Item Item { get; set; }
        public int Count { get; set; }
    }
}
