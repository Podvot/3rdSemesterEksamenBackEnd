using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Models.MenuItems;

public class MenuItem
{ 
        [Column(TypeName = "uniqueidentifier")]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double? Price { get; set; }
}