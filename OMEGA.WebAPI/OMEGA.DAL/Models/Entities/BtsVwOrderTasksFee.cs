using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwOrderTasksFee
{
    public double? OrderPrice { get; set; }

    [Column("MainOrderID")]
    public long? MainOrderId { get; set; }
}
