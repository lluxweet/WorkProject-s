//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BrexovaVar9
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pacient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pacient()
        {
            this.Jurnal_lecheniya = new HashSet<Jurnal_lecheniya>();
        }
    
        public int id { get; set; }
        public string Familia { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string sex { get; set; }
        public decimal phone { get; set; }
        public int id_Country { get; set; }
        public int id_City { get; set; }
        public int id_Street { get; set; }
        public string Number_Street { get; set; }
        public string Number_Kvartira { get; set; }
        public string Number_OMS { get; set; }
        public System.DateTime Date_birthday { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jurnal_lecheniya> Jurnal_lecheniya { get; set; }
        public virtual Streets Streets { get; set; }
    }
}