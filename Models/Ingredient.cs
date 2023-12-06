﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Ingredient
{
    [Column(TypeName = "uniqueidentifier")]
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Available { get; set; }
}