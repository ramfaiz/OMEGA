using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("NOTIFICATION")]
public partial class Notification
{
    [Key]
    [Column("notifcation_id")]
    public int NotifcationId { get; set; }

    [Column("emp_ref_no")]
    public long? EmpRefNo { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("notification_date", TypeName = "date")]
    public DateTime? NotificationDate { get; set; }

    [Column("nofication_msg")]
    [StringLength(500)]
    public string? NoficationMsg { get; set; }

    [Column("status")]
    public byte? Status { get; set; }
}
