using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUygulama1.Models
{
    public class KitapTuru
    {
        [Key] // primary key
        public int Id { get; set; }

        [Required(ErrorMessage ="Kitap Tür Adı boş bırakılama ")] // not null
        [MaxLength(25)]
        [DisplayName("KitapTuru Türü Adı")]
        public string Ad { get; set; }    
    }
}
