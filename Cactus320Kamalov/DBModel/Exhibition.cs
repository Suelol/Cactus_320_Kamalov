//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cactus320Kamalov.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exhibition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exhibition()
        {
            this.Cactus_Exhibition1 = new HashSet<Cactus_Exhibition1>();
        }
    
        public int IdExhibition { get; set; }
        public System.DateTime Date { get; set; }
        public string Location { get; set; }
        public string Awards { get; set; }
        public string Comments { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cactus_Exhibition1> Cactus_Exhibition1 { get; set; }
    }
}