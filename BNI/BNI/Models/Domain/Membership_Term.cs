﻿using System.ComponentModel.DataAnnotations;

namespace BNI.Models.Domain
{
    public class Membership_Term
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng điền người thanh toán.")]
        public string PayerName { get; set; }
        public bool CoC { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Member_Id { get; set; }
        public Member Member { get; set; }

    }
}
