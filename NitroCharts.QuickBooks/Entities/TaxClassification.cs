
using System.ComponentModel.DataAnnotations;
using System.Reactive;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class TaxClassification 
    {
        
        public long ConnectionId { get; set; }

        
                public string Id { get; set; }

                public string ParentId { get; set; }

                public string Code { get; set; }

        [MaxLength(2048)]
        public string Name { get; set; }

        [MaxLength(4096)]
        public string Description { get; set; }

        public byte? Level { get; set; }

        [MaxLength(512)]
        public string ApplicableToJSON { get; set; }

    }
}
