//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceAutoClassLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetaliiComanda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetaliiComanda()
        {
            this.Materiale = new HashSet<Material>();
            this.Imagini = new HashSet<Imagine>();
        }
    
        public int DetaliuComandaId { get; set; }
        public int ComandaId { get; set; }
        public int MecanicId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Materiale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Imagine> Imagini { get; set; }
        public virtual Operatie Operatie { get; set; }
        public virtual Mecanic Mecanic { get; set; }
        public virtual Comanda Comanda { get; set; }
    }
}
