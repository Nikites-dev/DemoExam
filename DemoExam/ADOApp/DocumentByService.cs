//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoExam.ADOApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocumentByService
    {
        public int ID { get; set; }
        public int ClientServiceID { get; set; }
        public string DocumentPath { get; set; }
    
        public virtual ClientService ClientService { get; set; }
    }
}
