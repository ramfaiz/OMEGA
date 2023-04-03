using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class AdVwHelpTemplate
{
    [Column("faq_id")]
    public long FaqId { get; set; }

    [Column("faq_question")]
    public string? FaqQuestion { get; set; }

    [Column("faq_answer")]
    public string? FaqAnswer { get; set; }

    [Column("ans_posted_date")]
    [StringLength(30)]
    [Unicode(false)]
    public string? AnsPostedDate { get; set; }

    [Column("delete_status")]
    public byte? DeleteStatus { get; set; }

    [Column("posted_by")]
    [StringLength(102)]
    public string PostedBy { get; set; } = null!;

    [Column("que_posted_date", TypeName = "date")]
    public DateTime? QuePostedDate { get; set; }
}
