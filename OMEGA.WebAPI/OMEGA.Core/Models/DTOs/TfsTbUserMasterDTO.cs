using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMEGA.Core.Model.DTOs
{
    public partial class TfsTbUserMasterDTO
    {
        public long UserId { get; set; }
        public long? RefNo { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? PasswordHint { get; set; }
        public DateTime? PasswordExpiry { get; set; }
        public long? CompanyCode { get; set; }
        public long? RoleId { get; set; }
        public byte? AccessLevel { get; set; }

        public DateTime? ActiveDate { get; set; }
        public DateTime? InactiveDate { get; set; }
        public byte? StatusId { get; set; }

        public byte? ThemePreference { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte? DeleteStatus { get; set; }
        public byte? IsFirstLogin { get; set; }
    }
}
