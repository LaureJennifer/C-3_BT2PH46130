﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace C_3_BT2.DomainClass;

[Table("LoaiXM")]
[Index("Ma", Name = "UQ__LoaiXM__3214CC9E6A38EB18", IsUnique = true)]
public partial class LoaiXm
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdLxmNavigation")]
    public virtual ICollection<XeMay> XeMays { get; set; } = new List<XeMay>();
}
