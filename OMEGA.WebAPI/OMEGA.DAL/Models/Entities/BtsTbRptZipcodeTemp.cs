using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_RPT_ZIPCODE_TEMP")]
public partial class BtsTbRptZipcodeTemp
{
    [Column("order_no")]
    public long OrderNo { get; set; }

    [Column("order_date", TypeName = "date")]
    public DateTime? OrderDate { get; set; }

    [Column("zipcode")]
    [StringLength(50)]
    public string? Zipcode { get; set; }

    [Column("city_id")]
    public long? CityId { get; set; }

    [Column("city_name")]
    [StringLength(300)]
    public string? CityName { get; set; }

    [Column("order_posted_by")]
    public long? OrderPostedBy { get; set; }

    [Column("No_Of_Orders")]
    public long? NoOfOrders { get; set; }

    [Column("Total_Count")]
    public long? TotalCount { get; set; }

    [Column("from_date", TypeName = "date")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "date")]
    public DateTime? ToDate { get; set; }
}
