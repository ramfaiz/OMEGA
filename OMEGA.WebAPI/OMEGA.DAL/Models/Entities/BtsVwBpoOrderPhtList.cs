using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class BtsVwBpoOrderPhtList
{
    [Column("order_no")]
    public long OrderNo { get; set; }

    [Column("order_code")]
    [StringLength(500)]
    public string? OrderCode { get; set; }

    [Column("order_due_date", TypeName = "datetime")]
    public DateTime? OrderDueDate { get; set; }

    [Column("photo_due_date", TypeName = "datetime")]
    public DateTime? PhotoDueDate { get; set; }

    [Column("subject_address")]
    public string? SubjectAddress { get; set; }

    [Column("client_id")]
    [StringLength(500)]
    public string? ClientId { get; set; }

    [Column("client_name")]
    [StringLength(100)]
    public string? ClientName { get; set; }

    [Column("client_email_id")]
    [StringLength(500)]
    public string? ClientEmailId { get; set; }

    [Column("pht_name")]
    [StringLength(100)]
    public string? PhtName { get; set; }

    [Column("pht_email_id")]
    [StringLength(500)]
    public string? PhtEmailId { get; set; }

    [Column("photographer_id")]
    public long? PhotographerId { get; set; }

    [Column("count_photo_upload")]
    public long? CountPhotoUpload { get; set; }

    [Column("is_mail_remaind")]
    public byte? IsMailRemaind { get; set; }

    [Column("is_photo_upload")]
    public byte? IsPhotoUpload { get; set; }

    [Column("is_entry_comp")]
    public byte? IsEntryComp { get; set; }
}
