//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkOracle
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COUR()
        {
            this.SEMINAIREs = new HashSet<SEMINAIRE>();
        }
    
        public string CODECOURS { get; set; }
        public string LIBELLECOURS { get; set; }
        public decimal NBJOURS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEMINAIRE> SEMINAIREs { get; set; }
    }
}