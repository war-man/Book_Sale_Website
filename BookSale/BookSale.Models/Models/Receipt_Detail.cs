﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.Models.Models
{
    [Table("Receipt_Details")]
    public class Receipt_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rec_Det_ID { set; get; }

        public int Rec_ID { set; get; }
        public int? Pro_ID { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }

        [ForeignKey("Rec_ID")]
        public virtual Receipt Receipts { set; get; }

        [ForeignKey("Pro_ID")]
        public virtual Product Products { set; get; }
    }
}