using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Keyless]
public partial class HrVwEmployeeapprisalSelect
{
    [Column("emp_ref_code")]
    [StringLength(100)]
    public string? EmpRefCode { get; set; }

    [Column("emp_title")]
    [StringLength(50)]
    public string? EmpTitle { get; set; }

    [Column("first_name")]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Column("emp_org_id")]
    public long? EmpOrgId { get; set; }

    [Column("emp_comp_id")]
    public long? EmpCompId { get; set; }

    [Column("file_path")]
    [StringLength(100)]
    public string? FilePath { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("empt_desig_id")]
    public int? EmptDesigId { get; set; }

    [StringLength(240)]
    public string? Designation { get; set; }

    [StringLength(240)]
    public string? Department { get; set; }

    [Column("role_id")]
    public int? RoleId { get; set; }

    [Column("c1")]
    public long C1 { get; set; }

    [Column("c2")]
    public long? C2 { get; set; }

    [Column("c3", TypeName = "datetime")]
    public DateTime? C3 { get; set; }

    [Column("c4")]
    public long? C4 { get; set; }

    [Column("c5", TypeName = "datetime")]
    public DateTime? C5 { get; set; }

    [Column("c6")]
    [StringLength(100)]
    public string? C6 { get; set; }

    [Column("c7")]
    [StringLength(100)]
    public string? C7 { get; set; }

    [Column("c8")]
    [StringLength(100)]
    public string? C8 { get; set; }

    [Column("c9")]
    [StringLength(100)]
    public string? C9 { get; set; }

    [Column("c10")]
    [StringLength(100)]
    public string? C10 { get; set; }

    [Column("c11")]
    [StringLength(100)]
    public string? C11 { get; set; }

    [Column("c12")]
    [StringLength(100)]
    public string? C12 { get; set; }

    [Column("c13")]
    [StringLength(100)]
    public string? C13 { get; set; }

    [Column("c14")]
    [StringLength(100)]
    public string? C14 { get; set; }

    [Column("c15")]
    [StringLength(100)]
    public string? C15 { get; set; }

    [Column("c16")]
    [StringLength(100)]
    public string? C16 { get; set; }

    [Column("c17")]
    [StringLength(100)]
    public string? C17 { get; set; }

    [Column("c18")]
    public long? C18 { get; set; }

    [Column("c19")]
    [StringLength(100)]
    public string? C19 { get; set; }

    [Column("c20")]
    [StringLength(100)]
    public string? C20 { get; set; }

    [Column("c21")]
    [StringLength(100)]
    public string? C21 { get; set; }

    [Column("c22")]
    [StringLength(100)]
    public string? C22 { get; set; }

    [Column("c23")]
    [StringLength(100)]
    public string? C23 { get; set; }

    [Column("c24")]
    [StringLength(100)]
    public string? C24 { get; set; }

    [Column("c25")]
    [StringLength(100)]
    public string? C25 { get; set; }

    [Column("c26")]
    [StringLength(100)]
    public string? C26 { get; set; }

    [Column("c27")]
    [StringLength(100)]
    public string? C27 { get; set; }

    [Column("c28")]
    public long? C28 { get; set; }

    [Column("c29")]
    [StringLength(100)]
    public string? C29 { get; set; }

    [Column("c30")]
    [StringLength(100)]
    public string? C30 { get; set; }

    [Column("c31")]
    [StringLength(100)]
    public string? C31 { get; set; }

    [Column("c32")]
    [StringLength(100)]
    public string? C32 { get; set; }

    [Column("c33")]
    [StringLength(100)]
    public string? C33 { get; set; }

    [Column("c34")]
    [StringLength(100)]
    public string? C34 { get; set; }

    [Column("c35")]
    [StringLength(100)]
    public string? C35 { get; set; }

    [Column("c36")]
    [StringLength(100)]
    public string? C36 { get; set; }

    [Column("c37")]
    [StringLength(100)]
    public string? C37 { get; set; }

    [Column("c38")]
    public long? C38 { get; set; }

    [Column("c39")]
    [StringLength(100)]
    public string? C39 { get; set; }

    [Column("c40")]
    [StringLength(100)]
    public string? C40 { get; set; }

    [Column("c41")]
    [StringLength(100)]
    public string? C41 { get; set; }

    [Column("c42")]
    [StringLength(100)]
    public string? C42 { get; set; }

    [Column("c43")]
    [StringLength(100)]
    public string? C43 { get; set; }

    [Column("c44")]
    [StringLength(100)]
    public string? C44 { get; set; }

    [Column("c45")]
    [StringLength(100)]
    public string? C45 { get; set; }

    [Column("c46")]
    [StringLength(100)]
    public string? C46 { get; set; }

    [Column("c47")]
    [StringLength(100)]
    public string? C47 { get; set; }

    [Column("c48", TypeName = "datetime")]
    public DateTime? C48 { get; set; }

    [Column("c49")]
    [StringLength(100)]
    public string? C49 { get; set; }

    [Column("c50", TypeName = "datetime")]
    public DateTime? C50 { get; set; }

    [Column("c51")]
    [StringLength(100)]
    public string? C51 { get; set; }

    [Column("c52", TypeName = "datetime")]
    public DateTime? C52 { get; set; }

    [Column("c53")]
    public string? C53 { get; set; }

    [Column("c54")]
    public string? C54 { get; set; }

    [Column("c55")]
    public string? C55 { get; set; }

    [Column("c56")]
    public string? C56 { get; set; }

    [Column("c57")]
    public string? C57 { get; set; }

    [Column("c58")]
    public string? C58 { get; set; }

    [Column("c59")]
    public string? C59 { get; set; }

    [Column("c60")]
    public string? C60 { get; set; }

    [Column("c61")]
    public string? C61 { get; set; }

    [Column("c62")]
    public string? C62 { get; set; }

    [Column("c63")]
    public string? C63 { get; set; }

    [Column("c64")]
    public string? C64 { get; set; }

    [Column("c65")]
    public string? C65 { get; set; }

    [Column("c66")]
    public string? C66 { get; set; }

    [Column("c67")]
    public string? C67 { get; set; }

    [Column("c68")]
    public string? C68 { get; set; }

    [Column("c69")]
    public string? C69 { get; set; }

    [Column("c70")]
    public string? C70 { get; set; }

    [Column("c71")]
    public string? C71 { get; set; }

    [Column("c72")]
    public string? C72 { get; set; }

    [Column("c73")]
    public string? C73 { get; set; }

    [Column("c74")]
    public string? C74 { get; set; }

    [Column("c75")]
    public string? C75 { get; set; }

    [Column("c76")]
    public string? C76 { get; set; }

    [Column("c77")]
    public string? C77 { get; set; }

    [Column("c78")]
    public string? C78 { get; set; }

    [Column("c79")]
    public string? C79 { get; set; }

    [Column("c80")]
    public string? C80 { get; set; }

    [Column("c81")]
    public string? C81 { get; set; }

    [Column("c82")]
    public string? C82 { get; set; }

    [Column("c83")]
    public string? C83 { get; set; }

    [Column("c84")]
    public string? C84 { get; set; }

    [Column("c85")]
    public string? C85 { get; set; }

    [Column("c86")]
    public string? C86 { get; set; }

    [Column("c87")]
    public string? C87 { get; set; }

    [Column("c88", TypeName = "datetime")]
    public DateTime? C88 { get; set; }

    [Column("c89")]
    [StringLength(100)]
    public string? C89 { get; set; }

    [Column("c90")]
    public long? C90 { get; set; }

    [Column("c91")]
    public long? C91 { get; set; }

    [Column("c92", TypeName = "datetime")]
    public DateTime? C92 { get; set; }

    [Column("c93")]
    public byte? C93 { get; set; }

    [Column("c94")]
    public long? C94 { get; set; }

    [Column("c95")]
    public long? C95 { get; set; }
}
