using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7EFCodeFirst.ModelClasses
{
    public class SelfReference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SelfReferenceId { get; private set; }
        public string Name { get; set; }
        public int? ParentSelfReferenceId { get; private set; }
        [ForeignKey("ParentSelfReferenceId")]
        public SelfReference ParentSelfReference { get; set; }
        public virtual ICollection<SelfReference> References { get; set; }


        public SelfReference()
        {
            References = new HashSet<SelfReference>();
        }
        public SelfReference(string name) : this()
        {
            Name = name;
        }

        public void AddReference(List<SelfReference> refs)
        {
            foreach (var r in refs)
            {
                r.ParentSelfReferenceId = SelfReferenceId;
                r.ParentSelfReference = ParentSelfReference;
                References.Add(r);
            }
        }
    }
}
