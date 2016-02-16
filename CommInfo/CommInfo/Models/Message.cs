﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommInfo.Models
{
    public class Message
    {
        List<Member> members = new List<Member>();
        
        public int MessageID { get; set; }
        public int ThreadID { get; set; }
        public int MemberID { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime Date { get; set; }
        //public List<Member> From
        //{
        //    get { return members; }
        //    set { value = members.Where(MemberID == Username); }  // not right
        //}
        public string From { get; set; }
        [StringLength(160)]
        public string Subject { get; set; }
        public string Body { get; set; }

        //public List<Member> Members 
        //{
        //    get { return members; }
        //}

    }
}