using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("FAQ_HELP_MASTER")]
public partial class FaqHelpMaster
{
    [Key]
    [Column("faq_id")]
    public long FaqId { get; set; }

    [Column("faq_question")]
    public string? FaqQuestion { get; set; }

    [Column("faq_answer")]
    public string? FaqAnswer { get; set; }

    [Column("posted_by")]
    public long? PostedBy { get; set; }

    [Column("ans_posted_date", TypeName = "date")]
    public DateTime? AnsPostedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("que_posted_date", TypeName = "date")]
    public DateTime? QuePostedDate { get; set; }
}
