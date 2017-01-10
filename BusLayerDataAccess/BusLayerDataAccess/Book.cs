//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusLayerDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.BookAuthors = new HashSet<BookAuthor>();
            this.BookCategories = new HashSet<BookCategory>();
            this.Copies = new HashSet<Copy>();
            this.Ratings = new HashSet<Rating>();
        }
    
        public decimal BookId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string OriginTitle { get; set; }
        public string Description { get; set; }
        public Nullable<int> PublishYear { get; set; }
        public Nullable<int> Pages { get; set; }
        public string ISBN { get; set; }
        public string ISBNSet { get; set; }
        public decimal PublisherId { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
    
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookCategory> BookCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Copy> Copies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
