//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiteOrder.db_context
{
    using System;
    using System.Collections.Generic;
    
    public partial class LayoutAccess
    {
        public int id { get; set; }
        public int executerId { get; set; }
        public int siteLayoutId { get; set; }
        public bool haveAccess { get; set; }
        public bool isOwner { get; set; }
    
        public virtual Logbook Logbook { get; set; }
        public virtual SiteLayout SiteLayout { get; set; }
    }
}
