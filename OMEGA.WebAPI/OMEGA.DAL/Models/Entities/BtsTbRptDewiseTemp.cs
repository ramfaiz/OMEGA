using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_RPT_DEWISE_TEMP")]
public partial class BtsTbRptDewiseTemp
{
    [Column("order_no")]
    public long OrderNo { get; set; }

    [Column("ordercode")]
    public long? Ordercode { get; set; }

    [Column("orderpstby")]
    public long? Orderpstby { get; set; }

    [Column("order_post_name")]
    public string? OrderPostName { get; set; }

    [Column("order_date", TypeName = "date")]
    public DateTime? OrderDate { get; set; }

    [Column("order_due_date", TypeName = "date")]
    public DateTime? OrderDueDate { get; set; }

    [Column("order_pht_dt", TypeName = "date")]
    public DateTime? OrderPhtDt { get; set; }

    [Column("sub_addrs")]
    public string? SubAddrs { get; set; }

    [Column("state_id")]
    public long? StateId { get; set; }

    [Column("city_id")]
    public long? CityId { get; set; }

    [Column("zipcode")]
    public long? Zipcode { get; set; }

    [Column("portal_id")]
    public long? PortalId { get; set; }

    [Column("portal_name")]
    public string? PortalName { get; set; }

    [Column("state_name")]
    public string? StateName { get; set; }

    [Column("city_name")]
    public string? CityName { get; set; }

    [Column("pht_id")]
    public long? PhtId { get; set; }

    [Column("pht_name")]
    public string? PhtName { get; set; }

    [Column("status_id")]
    public long? StatusId { get; set; }

    [Column("status_name")]
    public string? StatusName { get; set; }

    [Column("dt_id")]
    public long? DtId { get; set; }

    [Column("dt_name")]
    public string? DtName { get; set; }

    [Column("data_fee", TypeName = "numeric(18, 2)")]
    public decimal? DataFee { get; set; }

    [Column("pht_fee", TypeName = "numeric(18, 2)")]
    public decimal? PhtFee { get; set; }

    [Column("total_fee", TypeName = "numeric(18, 2)")]
    public decimal? TotalFee { get; set; }

    [Column("order_type")]
    public long? OrderType { get; set; }

    [Column("ordertype_name")]
    public string? OrdertypeName { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }
}
