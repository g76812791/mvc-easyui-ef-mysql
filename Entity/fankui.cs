//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class fankui:Pager
    {
        public fankui()
        {
            
            
            
            
            
            
            CreateTime =DateTime.Now;
            UpdateTime =DateTime.Now;
            
            
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public string Context { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<short> Flag { get; set; }
        public string Remark { get; set; }
    }
}
