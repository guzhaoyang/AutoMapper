//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLocationHistory
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int TypeBelongsID { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string LocPointName { get; set; }
        public Nullable<System.DateTime> OccTime { get; set; }
        public Nullable<int> InitiativeReportOrNot { get; set; }
        public Nullable<int> IsValid { get; set; }
    }
}