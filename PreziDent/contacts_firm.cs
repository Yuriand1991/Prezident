//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreziDent
{
    using System;
    using System.Collections.Generic;
    
    public partial class contacts_firm
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string notes { get; set; }
        public int id_firm { get; set; }
        public string post { get; set; }
    
        public virtual firm firm { get; set; }
    }
}
