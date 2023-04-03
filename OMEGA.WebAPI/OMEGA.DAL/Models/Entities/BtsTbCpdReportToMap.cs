using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
[Table("BTS_TB_CPD_REPORT_TO_MAP")]
public partial class BtsTbCpdReportToMap
{
    [Column("cpd_ref_no")]
    public long? CpdRefNo { get; set; }

    [Column("cpd_report_to")]
    public long? CpdReportTo { get; set; }

    [Column("report_to_seq_no")]
    public long? ReportToSeqNo { get; set; }
}
