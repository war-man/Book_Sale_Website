﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookSale.WEB.Models
{
    public class ReceiptViewModel
    {

        public int ReceiptID { set; get; }

        public int SupplyhouseID { set; get; }

        public int WarehouseID { set; get; }

        public decimal ToTalCost { set; get; }

        public DateTime created_date { set; get; }
        public int created_by { set; get; }

        public DateTime updated_date { set; get; }
        public int updated_by { set; get; }
        public virtual IEnumerable<ReceiptDetailViewModel> ReceiptDetails { set; get; }
    }
}