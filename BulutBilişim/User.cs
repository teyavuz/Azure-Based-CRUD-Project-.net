//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BulutBilişim
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mission { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public string Adress { get; set; }
        public string Reference { get; set; }
        public int UserTypeID { get; set; }
    
        public virtual UserType UserType { get; set; }
    }
}
