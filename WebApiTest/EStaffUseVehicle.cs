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
    
    public partial class EStaffUseVehicle
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> IsPermitUse { get; set; }
        public Nullable<int> IsUsing { get; set; }
        public int VehicleID { get; set; }
        public Nullable<System.DateTime> LastUseTime { get; set; }
        public Nullable<System.DateTime> NextUseTime { get; set; }
        public Nullable<int> CurMonthTimes { get; set; }
    }
}
