
using QuickBooksSharp.Entities;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    
    public class BundleItemLine     {
        
        public long ConnectionId { get; set; }

        
        public long BundleItemId { get; set; }

        //used as uniquifier because docs says "An item can be listed more than once with same or different quantities."
        public short Index { get; set; }
        
        public long? ItemId { get; private set; }

        public decimal? Qty { get; private set; }


    }
}
