using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("BTS_TB_ORDER_FEES")]
public partial class BtsTbOrderFee
{
    [Key]
    [Column("ref_no")]
    public long RefNo { get; set; }

    [Column("client_id")]
    public long? ClientId { get; set; }

    [Column("data_int_fee", TypeName = "numeric(18, 2)")]
    public decimal? DataIntFee { get; set; }

    [Column("data_ext_fee", TypeName = "numeric(18, 2)")]
    public decimal? DataExtFee { get; set; }

    [Column("photo_int_fee", TypeName = "numeric(18, 2)")]
    public decimal? PhotoIntFee { get; set; }

    [Column("photo_ext_fee", TypeName = "numeric(18, 2)")]
    public decimal? PhotoExtFee { get; set; }

    [Column("qa_fee", TypeName = "numeric(18, 2)")]
    public decimal? QaFee { get; set; }

    [Column("created_date", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }
}
