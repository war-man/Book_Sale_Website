﻿using BookSale.Models.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookSale.Models.Models
{
    [Table("account")]
    public class Account : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Acc_ID { set; get; }

        [MaxLength(50)]
        [Required]
        public string Acc_Name { set; get; }

        [MaxLength(20)]
        [Required]
        public string Acc_Password { set; get; }

        [MaxLength(50)]
        [Required]
        public string Acc_Status { set; get; }

        [MaxLength(30)]
        [Required]
        public string Acc_AccountType { set; get; }

        public virtual IEnumerable<Auditable> Auditables { set; get; }

        public virtual IEnumerable<Account_permission> Account_Permissions{ set; get; }

        public virtual IEnumerable<Account_profile> Account_Profiles { set; get; }
    }
}