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
    
    public partial class Cactus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cactus()
        {
            this.Cactus_Exhibition1 = new HashSet<Cactus_Exhibition1>();
        }
    
        public int IdCactus { get; set; }
        public string Species { get; set; }
        public string Origin { get; set; }
        public int Age { get; set; }
        public decimal Cost { get; set; }
        public string CareInstructions { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cactus_Exhibition1> Cactus_Exhibition1 { get; set; }
    }
}
