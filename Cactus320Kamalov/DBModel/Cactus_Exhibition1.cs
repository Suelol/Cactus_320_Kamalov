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
    
    public partial class Cactus_Exhibition1
    {
        public int Id { get; set; }
        public int IdCactus { get; set; }
        public int IdExhibition { get; set; }
    
        public virtual Cactus Cactus { get; set; }
        public virtual Exhibition Exhibition { get; set; }
    }
}
