using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMEGA.Core.Models.DTOs
{
    public partial class BtsTbBpoOrderDTO
    {
        public string? OrderNo { get; set; }
        public string? OrderCode { get; set; }
        public string? OrderPostedBy { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? OrderDueDate { get; set; }
        public DateTime? PhotoDueDate { get; set; }
        public string? SubjectAddress { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }
        public string? ZipCode { get; set; }
        public long? CountyId { get; set; }
        public long? PortalId { get; set; }
        public long? PhotographerId { get; set; }
        public long? DataentryId { get; set; }
        public long? QaId { get; set; }
        public long? IsQaRequired { get; set; }
        public byte? OrderType { get; set; }
        public byte? OrderUrgency { get; set; }
        public byte? OrderPriority { get; set; }
        public byte? OrderStatus { get; set; }
        public string? Remarks { get; set; }
        public string? NotesForClient { get; set; }
        public string? NotesForPht { get; set; }
        public string? NotesForDataentry { get; set; }
        public string? NotesForQa { get; set; }
        public decimal? PhotoFee { get; set; }
        public decimal? DataFee { get; set; }
        public decimal? QaFee { get; set; }
        public decimal? OrderValue { get; set; }
        public long? CountPhotoUpload { get; set; }
        public long? CountFileUpoad { get; set; }
        public byte? IsEntryComp { get; set; }
        public byte? IsPaid { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public byte? DeleteStatus { get; set; }
        public string? NotesFromPht { get; set; }
        public string? NotesFromDataentry { get; set; }
        public string? NotesFromQa { get; set; }
        public string? ReasonForDeletion { get; set; }
        public long? SubclientId { get; set; }
        public byte? IsMailRemaind { get; set; }

        public byte? IsPhotoUpload { get; set; }
        public byte? IsBulkOrder { get; set; }
        public string? OrderPortalNo { get; set; }
        public long OrderId { get; set; }
        public long? OrderRevNo { get; set; }
        public long? MasterAccountNo { get; set; }
        public long? HierarchyId { get; set; }
        public short? ClarificationStatus { get; set; }
        public short? PhotoReqStatus { get; set; }
        public short? StatusId { get; set; }
        public short? StatusReasonId { get; set; }

        public long? OrgRefNo { get; set; }
        public long? CompRefNo { get; set; }
        public long? EmpRefNo { get; set; }
        public long? ViewId { get; set; }
        public byte? PriorityParamId { get; set; }
        public short? EmpPriority { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateBy { get; set; }
        public long? SiteRefNo { get; set; }
        public int? ParentOrdId { get; set; }
        public int? OrdSeqNo { get; set; }
        public byte? IsReviewChecked { get; set; }
        public string? MlsSiteRefNo { get; set; }
        public byte? OrdRevisionFlag { get; set; }
        public DateTime? DueDate { get; set; }
        public byte? IsFromBts { get; set; }
        public byte? IsTransfer { get; set; }
        public byte? IsQaSubmit { get; set; }
        public byte? IsInvoiced { get; set; }
        public long? OrderAcceptedBy { get; set; }
        public long? TotalCount { get; set; }
        public byte? IsComment { get; set; }
        public long? BtsOrderId { get; set; }
        public DateTime? EstTime { get; set; }
        public short? IsOrdered { get; set; }
        public DateTime? IstDueTime { get; set; }
        public int? AutoBpoStatusId { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Check { get; set; }
        public string? TimeFormat { get; set; }
        public string? ReassignedNotes { get; set; }
        public DateTime? ReassignedDate { get; set; }
        public long? CancelledBy { get; set; }
        public string? CancelledNotes { get; set; }
        public DateTime? CancelledDate { get; set; }
        public bool? OrderNotified { get; set; }
        public bool? IsProcessing { get; set; }
        public int? GroupId { get; set; }
        public int? MlsId { get; set; }
        public DateTime? ResCompletedTime { get; set; }
        public short? IsAutoBpo { get; set; }
        public double? RentalValue { get; set; }
        public string? Instructions { get; set; }
        public string? SplInstructions { get; set; }

    }
}
