using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHWebApp.Shared.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Le champ Nom est obligatoire.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Le champ de description est obligatoire.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Le prix du champ doit être compris entre 0,1 et 99999,99."), Range(0.1, 99999.99), Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Le champ Image du produit est obligatoire."), DisplayName("Image du Produit")]
        public string? Base64Img { get; set; }
        [Required(ErrorMessage = "La quantité de champ doit être comprise entre 1 et 99999."), Range(1, 99999)]
        public int Quantity { get; set; }
        public bool Featured { get; set; } = false;
        public DateTime DateUpLoad { get; set; } = DateTime.Now;
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
        public int CategoryId { get; set; }    
        bool IsActive { get; set; }
    }
}
