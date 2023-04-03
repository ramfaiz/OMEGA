using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_RPT_CLIENT_INCOME_TEMP")]
public partial class BtsTbRptClientIncomeTemp
{
    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("client_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ClientName { get; set; }

    [Column("no_of_orders")]
    public int? NoOfOrders { get; set; }

    [Column("data_fee", TypeName = "numeric(18, 2)")]
    public decimal? DataFee { get; set; }

    [Column("photo_fee", TypeName = "numeric(18, 2)")]
    public decimal? PhotoFee { get; set; }

    [Column("qa_fee", TypeName = "numeric(18, 2)")]
    public decimal? QaFee { get; set; }

    [Column("acceptance_fee", TypeName = "numeric(18, 2)")]
    public decimal? AcceptanceFee { get; set; }

    [Column("total_order_value", TypeName = "numeric(18, 2)")]
    public decimal? TotalOrderValue { get; set; }

    [Column("total_income", TypeName = "numeric(18, 2)")]
    public decimal? TotalIncome { get; set; }

    [Column("total_expense", TypeName = "numeric(18, 2)")]
    public decimal? TotalExpense { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }
}
