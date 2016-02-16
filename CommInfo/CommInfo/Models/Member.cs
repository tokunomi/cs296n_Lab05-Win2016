using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommInfo.Models
{
    public class Member
    {
        List<Message> message = new List<Message>();
        public int MemberID { get; set; }
        public int MessageID { get; set; }
        [Required]
        [StringLength(160)]
        [Display(Name="First Name", Order=15000)]
        public string NameFirst { get; set; }
        [Required]
        [StringLength(160)]
        [Display(Name="Last Name", Order=15001)]
        public string NameLast { get; set; }
        [StringLength(160)]
        public string Username { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage="Please check your Email Address; it does not appear valid.")]
        public string email { get; set; }
    }
}