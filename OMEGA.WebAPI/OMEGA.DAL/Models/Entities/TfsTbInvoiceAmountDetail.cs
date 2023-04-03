using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("TFS_TB_INVOICE_AMOUNT_DETAILS")]
public partial class TfsTbInvoiceAmountDetail
{
    [Column("ref_no")]
    public int? RefNo { get; set; }

    [Column("inv_year")]
    public int? InvYear { get; set; }

    [Column("jan_inv_amt")]
    public double? JanInvAmt { get; set; }

    [Column("jan_paid_amt")]
    public double? JanPaidAmt { get; set; }

    [Column("jan_due_amt")]
    public double? JanDueAmt { get; set; }

    [Column("jan_inv_status")]
    public int? JanInvStatus { get; set; }

    [Column("feb_inv_amt")]
    public double? FebInvAmt { get; set; }

    [Column("feb_paid_amt")]
    public double? FebPaidAmt { get; set; }

    [Column("feb_due_amt")]
    public double? FebDueAmt { get; set; }

    [Column("feb_inv_status")]
    public int? FebInvStatus { get; set; }

    [Column("mar_inv_amt")]
    public double? MarInvAmt { get; set; }

    [Column("mar_paid_amt")]
    public double? MarPaidAmt { get; set; }

    [Column("mar_due_amt")]
    public double? MarDueAmt { get; set; }

    [Column("mar_inv_status")]
    public int? MarInvStatus { get; set; }

    [Column("apr_inv_amt")]
    public double? AprInvAmt { get; set; }

    [Column("apr_paid_amt")]
    public double? AprPaidAmt { get; set; }

    [Column("apr_due_amt")]
    public double? AprDueAmt { get; set; }

    [Column("apr_inv_status")]
    public int? AprInvStatus { get; set; }

    [Column("may_inv_amt")]
    public double? MayInvAmt { get; set; }

    [Column("may_paid_amt")]
    public double? MayPaidAmt { get; set; }

    [Column("may_due_amt")]
    public double? MayDueAmt { get; set; }

    [Column("may_inv_status")]
    public int? MayInvStatus { get; set; }

    [Column("jun_inv_amt")]
    public double? JunInvAmt { get; set; }

    [Column("jun_paid_amt")]
    public double? JunPaidAmt { get; set; }

    [Column("jun_due_amt")]
    public double? JunDueAmt { get; set; }

    [Column("jun_inv_status")]
    public int? JunInvStatus { get; set; }

    [Column("jul_inv_amt")]
    public double? JulInvAmt { get; set; }

    [Column("jul_paid_amt")]
    public double? JulPaidAmt { get; set; }

    [Column("jul_due_amt")]
    public double? JulDueAmt { get; set; }

    [Column("jul_inv_status")]
    public int? JulInvStatus { get; set; }

    [Column("aug_inv_amt")]
    public double? AugInvAmt { get; set; }

    [Column("aug_paid_amt")]
    public double? AugPaidAmt { get; set; }

    [Column("aug_due_amt")]
    public double? AugDueAmt { get; set; }

    [Column("aug_inv_status")]
    public int? AugInvStatus { get; set; }

    [Column("sep_inv_amt")]
    public double? SepInvAmt { get; set; }

    [Column("sep_paid_amt")]
    public double? SepPaidAmt { get; set; }

    [Column("sep_due_amt")]
    public double? SepDueAmt { get; set; }

    [Column("sep_inv_status")]
    public int? SepInvStatus { get; set; }

    [Column("oct_inv_amt")]
    public double? OctInvAmt { get; set; }

    [Column("oct_paid_amt")]
    public double? OctPaidAmt { get; set; }

    [Column("oct_due_amt")]
    public double? OctDueAmt { get; set; }

    [Column("oct_inv_status")]
    public int? OctInvStatus { get; set; }

    [Column("nov_inv_amt")]
    public double? NovInvAmt { get; set; }

    [Column("nov_paid_amt")]
    public double? NovPaidAmt { get; set; }

    [Column("nov_due_amt")]
    public double? NovDueAmt { get; set; }

    [Column("nov_inv_status")]
    public int? NovInvStatus { get; set; }

    [Column("dec_inv_amt")]
    public double? DecInvAmt { get; set; }

    [Column("dec_paid_amt")]
    public double? DecPaidAmt { get; set; }

    [Column("dec_due_amt")]
    public double? DecDueAmt { get; set; }

    [Column("dec_inv_status")]
    public int? DecInvStatus { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("updated_date", TypeName = "datetime")]
    public DateTime? UpdatedDate { get; set; }
}
