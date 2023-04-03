using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_IGNORED_ORDERS_RPT")]
public partial class TfsTbIgnoredOrdersRpt
{
    [Column("sl_no")]
    public int? SlNo { get; set; }

    [Column("added_date", TypeName = "datetime")]
    public DateTime? AddedDate { get; set; }

    [Column("added_by")]
    public long? AddedBy { get; set; }

    [Column("employee_name")]
    public string? EmployeeName { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("client_name")]
    public string? ClientName { get; set; }

    [Column("portal_id")]
    public int? PortalId { get; set; }

    [Column("portal_name")]
    public string? PortalName { get; set; }

    [Column("order_type")]
    public int? OrderType { get; set; }

    [Column("order_type_name")]
    public string? OrderTypeName { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("zip_code")]
    public long? ZipCode { get; set; }

    [Column("order_fee")]
    public double? OrderFee { get; set; }

    [Column("ignored_reason")]
    public string? IgnoredReason { get; set; }

    [Column("no_of_photographers")]
    public int? NoOfPhotographers { get; set; }
}
