﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolos2.Models;

[Table("backpacks")]
[PrimaryKey(nameof(CharacterId), nameof(ItemId))]
public class Backpack
{
    public int CharacterId { get; set; }
    
    public int ItemId { get; set; }
    
    [Required] public int Amount { get; set; }

    [ForeignKey(nameof(CharacterId))] public Character CharacterNavigation { get; set; } = null!;
    
    [ForeignKey(nameof(ItemId))] public Item ItemNavigation { get; set; } = null!;

}