using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("CM_EMPORDERLIST")]
public partial class CmEmporderlist
{
    [Column("TCM_EMP_ID")]
    public int? TcmEmpId { get; set; }

    [Column("TCM_EMP_CODE")]
    [StringLength(100)]
    public string? TcmEmpCode { get; set; }

    [Column("TCM_EMP_NAME")]
    [StringLength(100)]
    public string? TcmEmpName { get; set; }

    [Column("TCM_EMP_LOCATION")]
    [StringLength(100)]
    public string? TcmEmpLocation { get; set; }

    [Column("TTOTAL_ORDERS")]
    [StringLength(100)]
    public string? TtotalOrders { get; set; }

    [Column("ASSIGNED_ORDERS")]
    [StringLength(100)]
    public string? AssignedOrders { get; set; }

    [Column("UNASSIGNED_ORDERS")]
    [StringLength(100)]
    public string? UnassignedOrders { get; set; }
}
