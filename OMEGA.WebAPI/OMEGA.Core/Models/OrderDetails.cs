using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMEGA.Core.Models
{
    public class OrderDetails
    {
        public long OrderId { get; set; }

        //public string? OrderNo { get; set; }

        //public long? EmpRefNo { get; set; }

        //public long? MasterAccountNo { get; set; }

        //public byte DeleteStatus { get; set; }

        public string? FullName { get; set; }

        public DateTime? OrderDate { get; set; }

        //public long? OrderRevNo { get; set; }

        //public byte? OrderType { get; set; }

        public short? StatusId { get; set; }

        public short? StatusReasonId { get; set; }

        public string? StatusReasonDesc { get; set; }

        public string? StatusDesc { get; set; }

        //public string? EmpFirstName { get; set; }

        public string? Ordertypename { get; set; }

        public string? SubjectAddress { get; set; }

        //public byte? IsReviewFlag { get; set; }

        //public short? ClarificationStatus { get; set; }

        //public string? CStatusDesc { get; set; }

        //public short? PhotoReqStatus { get; set; }

        //public byte? OrdRevisionFlag { get; set; }

        //public byte? IsReviewChecked { get; set; }

        public string? PhotoReqStatusDesc { get; set; }

        //public byte? IsQaSubmit { get; set; }

        //public long? SiteRefNo { get; set; }

        public string? PortalName { get; set; }

        //public string? DueDate { get; set; }

        //public long? BtsOrderId { get; set; }

        //public byte? IsFromBts { get; set; }

        //public int? ParentOrdId { get; set; }

        //public string? Remarks { get; set; }

        //public long? HierarchyId { get; set; }

        //public long? EmpCompId { get; set; }

        public string? Subclient { get; set; }

        //public byte? IsClientSubmission { get; set; }

        //public long? OrderAcceptedBy { get; set; }

        //public byte? IsComment { get; set; }

        //public string? OrderPostedBy { get; set; }

        //public string? OrderDueDate { get; set; }

        //public string? StateName { get; set; }

        //public string? StateAbb { get; set; }

        //public DateTime? UpdatedDate { get; set; }

        //public string? CreatedBy { get; set; }

        //public string? OrderDates { get; set; }

        //public string? ZipCode { get; set; }

        //public long? StateId { get; set; }

        //public long? PortalId { get; set; }

        //public string? AutoBpoStatusDesc { get; set; }

        //public int? AutoBpoStatusId { get; set; }

        //public bool? IsProcessing { get; set; }

        //public int? GroupId { get; set; }

        //public int? MlsId { get; set; }

        //public DateTime? IstDueTime { get; set; }

        //public string? ReassignedNotes { get; set; }

        //public DateTime? ReassignedDate { get; set; }

        //public long? CancelledBy { get; set; }

        //public string? CancelledNotes { get; set; }

        //public string? City { get; set; }

        //public string? State { get; set; }

        //public string? Check { get; set; }

        //public string? NotesForClient { get; set; }

        //public decimal? OrderValue { get; set; }

        //public byte? IsPaid { get; set; }

        //public string? Latitude { get; set; }

        //public string? Longitude { get; set; }

        //public string? MlsSiteRefNo { get; set; }

        //public string? Instructions { get; set; }

        //public string? FilePath { get; set; }

        //public string? SplInstructions { get; set; }

    }
}
