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
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class DetaliiComanda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetaliiComanda()
        {
            this.Materiale = new HashSet<Material>();
            this.Imagini = new HashSet<Imagine>();
        }

        [DataMember]
        public int DetaliuComandaId { get; set; }
        [DataMember]
        public int ComandaId { get; set; }
        [DataMember]
        public int MecanicId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Material> Materiale { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Imagine> Imagini { get; set; }
        [DataMember]
        public virtual Operatie Operatie { get; set; }
        [DataMember]
        public virtual Mecanic Mecanic { get; set; }
        [DataMember]
        public virtual Comanda Comanda { get; set; }
    }
}
