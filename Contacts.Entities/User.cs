using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contacts.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity) ]
        public string Id { get; set; }
        [StringLength(50)]
        public string Ad { get; set; }
        [StringLength(50)]
        public string Soyad { get; set; }
        [StringLength(50)]
        public string Firma { get; set; }
    }
}
