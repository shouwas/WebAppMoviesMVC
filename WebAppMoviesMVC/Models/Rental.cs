//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppMoviesMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rental
    {
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public int MovieID { get; set; }
        public System.DateTime DateRental { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Movy Movy { get; set; }
    }
}