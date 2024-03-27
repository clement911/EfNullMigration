
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wish.Core;

namespace NitroCharts.QuickBooks
{
    public class TransactionLineDateChecksum
    {
        
        public long ConnectionId { get; set; }

        [DateOnly]
        public DateTime Date { get; set; }

        [Required]
        [Column(TypeName = "binary(32)")] //32 * 8 == 256
        public byte[] SHA256Checksum { get; set; }
    }
}
