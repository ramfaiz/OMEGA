using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OMEGA.DAL.Models.Entities;

namespace OMEGA.DAL.DBContext;

public partial class OMEGADBContext : DbContext
{
    public OMEGADBContext()
    {
    }

    public OMEGADBContext(DbContextOptions<OMEGADBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdFinYr> AdFinYrs { get; set; }

    public virtual DbSet<AdTbCompanyMaster> AdTbCompanyMasters { get; set; }

    public virtual DbSet<AdTbFinancialYear> AdTbFinancialYears { get; set; }

    public virtual DbSet<AdVwAnnouncement> AdVwAnnouncements { get; set; }

    public virtual DbSet<AdVwAnnouncementList> AdVwAnnouncementLists { get; set; }

    public virtual DbSet<AdVwClientOrder> AdVwClientOrders { get; set; }

    public virtual DbSet<AdVwClientOrder1> AdVwClientOrder1s { get; set; }

    public virtual DbSet<AdVwClientService> AdVwClientServices { get; set; }

    public virtual DbSet<AdVwClientServices1> AdVwClientServices1s { get; set; }

    public virtual DbSet<AdVwCurrentUserDet> AdVwCurrentUserDets { get; set; }

    public virtual DbSet<AdVwCurrentUserRole> AdVwCurrentUserRoles { get; set; }

    public virtual DbSet<AdVwEmployeeAnnouncement> AdVwEmployeeAnnouncements { get; set; }

    public virtual DbSet<AdVwFinyearCreate> AdVwFinyearCreates { get; set; }

    public virtual DbSet<AdVwFinyearId> AdVwFinyearIds { get; set; }

    public virtual DbSet<AdVwFinyearNewFinyid> AdVwFinyearNewFinyids { get; set; }

    public virtual DbSet<AdVwHelpTemplate> AdVwHelpTemplates { get; set; }

    public virtual DbSet<AdVwModule> AdVwModules { get; set; }

    public virtual DbSet<AdVwModulesSubModule> AdVwModulesSubModules { get; set; }

    public virtual DbSet<AdVwRoleMaster> AdVwRoleMasters { get; set; }

    public virtual DbSet<AdVwRolePermissionTemplate> AdVwRolePermissionTemplates { get; set; }

    public virtual DbSet<AdVwSubModule> AdVwSubModules { get; set; }

    public virtual DbSet<AdVwUser> AdVwUsers { get; set; }

    public virtual DbSet<AdVwUser1> AdVwUser1s { get; set; }

    public virtual DbSet<AdVwUserAccess> AdVwUserAccesses { get; set; }

    public virtual DbSet<AdVwUserRole> AdVwUserRoles { get; set; }

    public virtual DbSet<AdVwUserRole1> AdVwUserRoles1 { get; set; }

    public virtual DbSet<AdVwUserRolePermission> AdVwUserRolePermissions { get; set; }

    public virtual DbSet<AutoBpoStatusRef> AutoBpoStatusRefs { get; set; }

    public virtual DbSet<BankMasterRef> BankMasterRefs { get; set; }

    public virtual DbSet<BankMasterValue> BankMasterValues { get; set; }

    public virtual DbSet<BtsBgClientDetail> BtsBgClientDetails { get; set; }

    public virtual DbSet<BtsBgClientTaskType> BtsBgClientTaskTypes { get; set; }

    public virtual DbSet<BtsBgCompanyDetail> BtsBgCompanyDetails { get; set; }

    public virtual DbSet<BtsBgContactU> BtsBgContactUs { get; set; }

    public virtual DbSet<BtsBgCustomerDetail> BtsBgCustomerDetails { get; set; }

    public virtual DbSet<BtsBgOrderImage> BtsBgOrderImages { get; set; }

    public virtual DbSet<BtsBgOrderLog> BtsBgOrderLogs { get; set; }

    public virtual DbSet<BtsBgOrderTask> BtsBgOrderTasks { get; set; }

    public virtual DbSet<BtsBgPmb> BtsBgPmbs { get; set; }

    public virtual DbSet<BtsBgRole> BtsBgRoles { get; set; }

    public virtual DbSet<BtsBgStaffMaster> BtsBgStaffMasters { get; set; }

    public virtual DbSet<BtsBgTaskType> BtsBgTaskTypes { get; set; }

    public virtual DbSet<BtsBgTempUser> BtsBgTempUsers { get; set; }

    public virtual DbSet<BtsBgVwZipCodeDetail> BtsBgVwZipCodeDetails { get; set; }

    public virtual DbSet<BtsBgZip> BtsBgZips { get; set; }

    public virtual DbSet<BtsTbAdvNote> BtsTbAdvNotes { get; set; }

    public virtual DbSet<BtsTbAttachment> BtsTbAttachments { get; set; }

    public virtual DbSet<BtsTbAutoMailLog> BtsTbAutoMailLogs { get; set; }

    public virtual DbSet<BtsTbBpoOrder> BtsTbBpoOrders { get; set; }

    public virtual DbSet<BtsTbCityMaster> BtsTbCityMasters { get; set; }

    public virtual DbSet<BtsTbClPortalTemp> BtsTbClPortalTemps { get; set; }

    public virtual DbSet<BtsTbClientDoc> BtsTbClientDocs { get; set; }

    public virtual DbSet<BtsTbClientDocument> BtsTbClientDocuments { get; set; }

    public virtual DbSet<BtsTbClientFile> BtsTbClientFiles { get; set; }

    public virtual DbSet<BtsTbClientOrderTypePrice> BtsTbClientOrderTypePrices { get; set; }

    public virtual DbSet<BtsTbClientOrderTypePrice1> BtsTbClientOrderTypePrice1s { get; set; }

    public virtual DbSet<BtsTbClientOrderTypePrice2> BtsTbClientOrderTypePrice2s { get; set; }

    public virtual DbSet<BtsTbClientOrderTypePrice3> BtsTbClientOrderTypePrice3s { get; set; }

    public virtual DbSet<BtsTbClientPhotoghrMap> BtsTbClientPhotoghrMaps { get; set; }

    public virtual DbSet<BtsTbClientPhotoghrMap1> BtsTbClientPhotoghrMap1s { get; set; }

    public virtual DbSet<BtsTbClientPortalMap> BtsTbClientPortalMaps { get; set; }

    public virtual DbSet<BtsTbClientPortalMap1> BtsTbClientPortalMap1s { get; set; }

    public virtual DbSet<BtsTbClientwiseTemp> BtsTbClientwiseTemps { get; set; }

    public virtual DbSet<BtsTbCountyMaster> BtsTbCountyMasters { get; set; }

    public virtual DbSet<BtsTbCpdMaster> BtsTbCpdMasters { get; set; }

    public virtual DbSet<BtsTbCpdMasterRam> BtsTbCpdMasterRams { get; set; }

    public virtual DbSet<BtsTbCpdMasterWorking> BtsTbCpdMasterWorkings { get; set; }

    public virtual DbSet<BtsTbCpdReportToMap> BtsTbCpdReportToMaps { get; set; }

    public virtual DbSet<BtsTbInvoicePaidStatus> BtsTbInvoicePaidStatuses { get; set; }

    public virtual DbSet<BtsTbMailLogDatum> BtsTbMailLogData { get; set; }

    public virtual DbSet<BtsTbMailTemplate> BtsTbMailTemplates { get; set; }

    public virtual DbSet<BtsTbModule> BtsTbModules { get; set; }

    public virtual DbSet<BtsTbMonthlyOrderTemp> BtsTbMonthlyOrderTemps { get; set; }

    public virtual DbSet<BtsTbOrderFee> BtsTbOrderFees { get; set; }

    public virtual DbSet<BtsTbOrderTask> BtsTbOrderTasks { get; set; }

    public virtual DbSet<BtsTbOrderTemp> BtsTbOrderTemps { get; set; }

    public virtual DbSet<BtsTbOrdersTemp> BtsTbOrdersTemps { get; set; }

    public virtual DbSet<BtsTbPhotographerFee> BtsTbPhotographerFees { get; set; }

    public virtual DbSet<BtsTbPortalMaster> BtsTbPortalMasters { get; set; }

    public virtual DbSet<BtsTbReportDatum> BtsTbReportData { get; set; }

    public virtual DbSet<BtsTbRoleMaster> BtsTbRoleMasters { get; set; }

    public virtual DbSet<BtsTbRolePermission> BtsTbRolePermissions { get; set; }

    public virtual DbSet<BtsTbRptCitywiseTemp> BtsTbRptCitywiseTemps { get; set; }

    public virtual DbSet<BtsTbRptClientIncomeTemp> BtsTbRptClientIncomeTemps { get; set; }

    public virtual DbSet<BtsTbRptDewiseTemp> BtsTbRptDewiseTemps { get; set; }

    public virtual DbSet<BtsTbRptPhtorderTemp> BtsTbRptPhtorderTemps { get; set; }

    public virtual DbSet<BtsTbRptPhtwiseTemp> BtsTbRptPhtwiseTemps { get; set; }

    public virtual DbSet<BtsTbRptPortalTemp> BtsTbRptPortalTemps { get; set; }

    public virtual DbSet<BtsTbRptStatuswiseTemp> BtsTbRptStatuswiseTemps { get; set; }

    public virtual DbSet<BtsTbRptZipcodeTemp> BtsTbRptZipcodeTemps { get; set; }

    public virtual DbSet<BtsTbStateMaster> BtsTbStateMasters { get; set; }

    public virtual DbSet<BtsTbSubClientMaster> BtsTbSubClientMasters { get; set; }

    public virtual DbSet<BtsTbSubModule> BtsTbSubModules { get; set; }

    public virtual DbSet<BtsTbUserMaster> BtsTbUserMasters { get; set; }

    public virtual DbSet<BtsTbWeeklyOrderTemp> BtsTbWeeklyOrderTemps { get; set; }

    public virtual DbSet<BtsTbZipcodeMaster> BtsTbZipcodeMasters { get; set; }

    public virtual DbSet<BtsVwBpoOrderList> BtsVwBpoOrderLists { get; set; }

    public virtual DbSet<BtsVwBpoOrderList1> BtsVwBpoOrderList1s { get; set; }

    public virtual DbSet<BtsVwBpoOrderListOld> BtsVwBpoOrderListOlds { get; set; }

    public virtual DbSet<BtsVwBpoOrderListRam> BtsVwBpoOrderListRams { get; set; }

    public virtual DbSet<BtsVwBpoOrderPhtList> BtsVwBpoOrderPhtLists { get; set; }

    public virtual DbSet<BtsVwCityList> BtsVwCityLists { get; set; }

    public virtual DbSet<BtsVwClPortalMap> BtsVwClPortalMaps { get; set; }

    public virtual DbSet<BtsVwClientPhtList> BtsVwClientPhtLists { get; set; }

    public virtual DbSet<BtsVwClientVsPhotoghr> BtsVwClientVsPhotoghrs { get; set; }

    public virtual DbSet<BtsVwCountyList> BtsVwCountyLists { get; set; }

    public virtual DbSet<BtsVwCpdMaster> BtsVwCpdMasters { get; set; }

    public virtual DbSet<BtsVwCpdUserList> BtsVwCpdUserLists { get; set; }

    public virtual DbSet<BtsVwGetReportToClient> BtsVwGetReportToClients { get; set; }

    public virtual DbSet<BtsVwOrderTasksFee> BtsVwOrderTasksFees { get; set; }

    public virtual DbSet<BtsVwPhotoClientMap> BtsVwPhotoClientMaps { get; set; }

    public virtual DbSet<BtsVwPhotographerListing> BtsVwPhotographerListings { get; set; }

    public virtual DbSet<BtsVwPhotographerListing1> BtsVwPhotographerListing1s { get; set; }

    public virtual DbSet<BtsVwPhotographerListingOld> BtsVwPhotographerListingOlds { get; set; }

    public virtual DbSet<BtsVwRoleListDataWithModule> BtsVwRoleListDataWithModules { get; set; }

    public virtual DbSet<BtsVwRoleListDatum> BtsVwRoleListData { get; set; }

    public virtual DbSet<BtsVwRolePermission> BtsVwRolePermissions { get; set; }

    public virtual DbSet<BtsVwRptDailyOrder> BtsVwRptDailyOrders { get; set; }

    public virtual DbSet<BtsVwUserMenu> BtsVwUserMenus { get; set; }

    public virtual DbSet<BtsVwUserSession> BtsVwUserSessions { get; set; }

    public virtual DbSet<BtsVwZipcodeMaster> BtsVwZipcodeMasters { get; set; }

    public virtual DbSet<ClientAssignDashboard> ClientAssignDashboards { get; set; }

    public virtual DbSet<ClientCoverageView> ClientCoverageViews { get; set; }

    public virtual DbSet<ClientGroupMaster> ClientGroupMasters { get; set; }

    public virtual DbSet<ClientMlsPortalView> ClientMlsPortalViews { get; set; }

    public virtual DbSet<ClientOrderSummary> ClientOrderSummaries { get; set; }

    public virtual DbSet<ClientService> ClientServices { get; set; }

    public virtual DbSet<ClientSubmissionStatus> ClientSubmissionStatuses { get; set; }

    public virtual DbSet<CmCustorderlist> CmCustorderlists { get; set; }

    public virtual DbSet<CmCustorderlistClientReport> CmCustorderlistClientReports { get; set; }

    public virtual DbSet<CmCustorderlistGad> CmCustorderlistGads { get; set; }

    public virtual DbSet<CmCustorderlistSubTotal> CmCustorderlistSubTotals { get; set; }

    public virtual DbSet<CmCustorderlistSubTrial> CmCustorderlistSubTrials { get; set; }

    public virtual DbSet<CmCustorderlistSubmission> CmCustorderlistSubmissions { get; set; }

    public virtual DbSet<CmCustorderlistTotal> CmCustorderlistTotals { get; set; }

    public virtual DbSet<CmCustorderlistTotal1> CmCustorderlistTotals1 { get; set; }

    public virtual DbSet<CmCustorderlistTrial> CmCustorderlistTrials { get; set; }

    public virtual DbSet<CmEmporderlist> CmEmporderlists { get; set; }

    public virtual DbSet<CmTbLastidmaster> CmTbLastidmasters { get; set; }

    public virtual DbSet<CmTbModuleMap> CmTbModuleMaps { get; set; }

    public virtual DbSet<CmVwCurrentUser> CmVwCurrentUsers { get; set; }

    public virtual DbSet<CmVwCurrentUserDetail> CmVwCurrentUserDetails { get; set; }

    public virtual DbSet<CmVwEmporderslist> CmVwEmporderslists { get; set; }

    public virtual DbSet<CmVwLanguage> CmVwLanguages { get; set; }

    public virtual DbSet<CmVwMenu1> CmVwMenu1s { get; set; }

    public virtual DbSet<CmVwOrderslist> CmVwOrderslists { get; set; }

    public virtual DbSet<CmVwUserMenu> CmVwUserMenus { get; set; }

    public virtual DbSet<CommonSearchConfig> CommonSearchConfigs { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<CountryCodeRef> CountryCodeRefs { get; set; }

    public virtual DbSet<CountryCodeValue> CountryCodeValues { get; set; }

    public virtual DbSet<CustOrderCountTemp> CustOrderCountTemps { get; set; }

    public virtual DbSet<CustomerOrder1> CustomerOrder1s { get; set; }

    public virtual DbSet<CustomerOrderAutoLog> CustomerOrderAutoLogs { get; set; }

    public virtual DbSet<CustomerOrderComment> CustomerOrderComments { get; set; }

    public virtual DbSet<CustomerOrderStatus> CustomerOrderStatuses { get; set; }

    public virtual DbSet<DepartmentRef> DepartmentRefs { get; set; }

    public virtual DbSet<DepartmentValue> DepartmentValues { get; set; }

    public virtual DbSet<EmpDesignationMasterRef> EmpDesignationMasterRefs { get; set; }

    public virtual DbSet<EmpDesignationMasterValue> EmpDesignationMasterValues { get; set; }

    public virtual DbSet<ErrorLog1> ErrorLog1s { get; set; }

    public virtual DbSet<FaqHelpMaster> FaqHelpMasters { get; set; }

    public virtual DbSet<GenericEnumerationValue> GenericEnumerationValues { get; set; }

    public virtual DbSet<GlSelectDept> GlSelectDepts { get; set; }

    public virtual DbSet<GlVwBank> GlVwBanks { get; set; }

    public virtual DbSet<GlVwBankMaster> GlVwBankMasters { get; set; }

    public virtual DbSet<GlVwBindDepartment> GlVwBindDepartments { get; set; }

    public virtual DbSet<GlVwDepartmentMaster> GlVwDepartmentMasters { get; set; }

    public virtual DbSet<Greeting> Greetings { get; set; }

    public virtual DbSet<HolidayMasterRef> HolidayMasterRefs { get; set; }

    public virtual DbSet<HolidayMasterValue> HolidayMasterValues { get; set; }

    public virtual DbSet<HolidayType> HolidayTypes { get; set; }

    public virtual DbSet<HrAdVwUserlist> HrAdVwUserlists { get; set; }

    public virtual DbSet<HrTbAnnouncement> HrTbAnnouncements { get; set; }

    public virtual DbSet<HrTbAnnouncementReadby> HrTbAnnouncementReadbies { get; set; }

    public virtual DbSet<HrTbAnnouncementSpecific> HrTbAnnouncementSpecifics { get; set; }

    public virtual DbSet<HrTbAnnouncementTmp> HrTbAnnouncementTmps { get; set; }

    public virtual DbSet<HrTbClientCoverageArea> HrTbClientCoverageAreas { get; set; }

    public virtual DbSet<HrTbDocument> HrTbDocuments { get; set; }

    public virtual DbSet<HrTbDocumentField> HrTbDocumentFields { get; set; }

    public virtual DbSet<HrTbDocumentMasterRef> HrTbDocumentMasterRefs { get; set; }

    public virtual DbSet<HrTbEmpEmployment> HrTbEmpEmployments { get; set; }

    public virtual DbSet<HrTbEmpExperience> HrTbEmpExperiences { get; set; }

    public virtual DbSet<HrTbEmployeeAppraisal> HrTbEmployeeAppraisals { get; set; }

    public virtual DbSet<HrTbEmployeeExperience> HrTbEmployeeExperiences { get; set; }

    public virtual DbSet<HrTbEmployeeFamilyDetail> HrTbEmployeeFamilyDetails { get; set; }

    public virtual DbSet<HrTbEmployeeLeave> HrTbEmployeeLeaves { get; set; }

    public virtual DbSet<HrTbEmployeeLeaveEntry> HrTbEmployeeLeaveEntries { get; set; }

    public virtual DbSet<HrTbEmployeeMaster> HrTbEmployeeMasters { get; set; }

    public virtual DbSet<HrTbEmployeeOrderPriority> HrTbEmployeeOrderPriorities { get; set; }

    public virtual DbSet<HrTbEmployeeShiftDefault> HrTbEmployeeShiftDefaults { get; set; }

    public virtual DbSet<HrTbEmploymentDetail> HrTbEmploymentDetails { get; set; }

    public virtual DbSet<HrTbEmploymentHistory> HrTbEmploymentHistories { get; set; }

    public virtual DbSet<HrTbEmploymentLeave> HrTbEmploymentLeaves { get; set; }

    public virtual DbSet<HrTbEmploymentSetting> HrTbEmploymentSettings { get; set; }

    public virtual DbSet<HrTbEmploymentShift> HrTbEmploymentShifts { get; set; }

    public virtual DbSet<HrTbEmploymentShiftTemplate> HrTbEmploymentShiftTemplates { get; set; }

    public virtual DbSet<HrTbLeavePlan> HrTbLeavePlans { get; set; }

    public virtual DbSet<HrTbResignation> HrTbResignations { get; set; }

    public virtual DbSet<HrTbShiftViewerTemp> HrTbShiftViewerTemps { get; set; }

    public virtual DbSet<HrTbSiteCredential> HrTbSiteCredentials { get; set; }

    public virtual DbSet<HrVwApp> HrVwApps { get; set; }

    public virtual DbSet<HrVwAttendance> HrVwAttendances { get; set; }

    public virtual DbSet<HrVwBindBankdetail> HrVwBindBankdetails { get; set; }

    public virtual DbSet<HrVwBindCompany> HrVwBindCompanies { get; set; }

    public virtual DbSet<HrVwBindDepartment> HrVwBindDepartments { get; set; }

    public virtual DbSet<HrVwClientCredential> HrVwClientCredentials { get; set; }

    public virtual DbSet<HrVwCommonEmpList> HrVwCommonEmpLists { get; set; }

    public virtual DbSet<HrVwDesignationlist> HrVwDesignationlists { get; set; }

    public virtual DbSet<HrVwEmpAutoAssign> HrVwEmpAutoAssigns { get; set; }

    public virtual DbSet<HrVwEmpDetail> HrVwEmpDetails { get; set; }

    public virtual DbSet<HrVwEmpDetail1> HrVwEmpDetails1 { get; set; }

    public virtual DbSet<HrVwEmpLeaveDetail> HrVwEmpLeaveDetails { get; set; }

    public virtual DbSet<HrVwEmpLeaveEntPopup> HrVwEmpLeaveEntPopups { get; set; }

    public virtual DbSet<HrVwEmpLeaveEntry> HrVwEmpLeaveEntries { get; set; }

    public virtual DbSet<HrVwEmpLeaveInfo> HrVwEmpLeaveInfos { get; set; }

    public virtual DbSet<HrVwEmpOrderAssignShift> HrVwEmpOrderAssignShifts { get; set; }

    public virtual DbSet<HrVwEmpOrderPriority> HrVwEmpOrderPriorities { get; set; }

    public virtual DbSet<HrVwEmpShiftDetail> HrVwEmpShiftDetails { get; set; }

    public virtual DbSet<HrVwEmployeeCompoff> HrVwEmployeeCompoffs { get; set; }

    public virtual DbSet<HrVwEmployeeExperienceSelect> HrVwEmployeeExperienceSelects { get; set; }

    public virtual DbSet<HrVwEmployeeLeave> HrVwEmployeeLeaves { get; set; }

    public virtual DbSet<HrVwEmployeeOrderPriorityDetail> HrVwEmployeeOrderPriorityDetails { get; set; }

    public virtual DbSet<HrVwEmployeeapprisalSelect> HrVwEmployeeapprisalSelects { get; set; }

    public virtual DbSet<HrVwEmployeelist> HrVwEmployeelists { get; set; }

    public virtual DbSet<HrVwEmployeelistEncodedTable> HrVwEmployeelistEncodedTables { get; set; }

    public virtual DbSet<HrVwEmployeemasterSelect> HrVwEmployeemasterSelects { get; set; }

    public virtual DbSet<HrVwEmploymentDetailsSelect> HrVwEmploymentDetailsSelects { get; set; }

    public virtual DbSet<HrVwEmploymentHistory> HrVwEmploymentHistories { get; set; }

    public virtual DbSet<HrVwEmptShiftDetail> HrVwEmptShiftDetails { get; set; }

    public virtual DbSet<HrVwHolidayList> HrVwHolidayLists { get; set; }

    public virtual DbSet<HrVwLeaveDateCheck> HrVwLeaveDateChecks { get; set; }

    public virtual DbSet<HrVwLeaveEntryEmpList> HrVwLeaveEntryEmpLists { get; set; }

    public virtual DbSet<HrVwLeaveEntryNotification> HrVwLeaveEntryNotifications { get; set; }

    public virtual DbSet<HrVwLeaveNotification> HrVwLeaveNotifications { get; set; }

    public virtual DbSet<HrVwLocation> HrVwLocations { get; set; }

    public virtual DbSet<HrVwRejectedLeaveList> HrVwRejectedLeaveLists { get; set; }

    public virtual DbSet<HrVwResignation> HrVwResignations { get; set; }

    public virtual DbSet<HrVwRptAppraisalForm> HrVwRptAppraisalForms { get; set; }

    public virtual DbSet<HrVwSelectInternalCompany> HrVwSelectInternalCompanies { get; set; }

    public virtual DbSet<HrVwSelectReasonType> HrVwSelectReasonTypes { get; set; }

    public virtual DbSet<LangaugeCodeRef> LangaugeCodeRefs { get; set; }

    public virtual DbSet<LangaugeCodeValue> LangaugeCodeValues { get; set; }

    public virtual DbSet<LanguageCodeRefView> LanguageCodeRefViews { get; set; }

    public virtual DbSet<LanguageLocationView> LanguageLocationViews { get; set; }

    public virtual DbSet<LanguageStationView> LanguageStationViews { get; set; }

    public virtual DbSet<LeaveCompoffDay> LeaveCompoffDays { get; set; }

    public virtual DbSet<LeaveEntry> LeaveEntries { get; set; }

    public virtual DbSet<LeaveEntryDetail> LeaveEntryDetails { get; set; }

    public virtual DbSet<LeaveTypeRef> LeaveTypeRefs { get; set; }

    public virtual DbSet<LeaveTypeValue> LeaveTypeValues { get; set; }

    public virtual DbSet<MailLogDatum> MailLogData { get; set; }

    public virtual DbSet<MailTemplate> MailTemplates { get; set; }

    public virtual DbSet<MenuRef> MenuRefs { get; set; }

    public virtual DbSet<MenuValue> MenuValues { get; set; }

    public virtual DbSet<MlsAssignDashboard> MlsAssignDashboards { get; set; }

    public virtual DbSet<MlsMasterView> MlsMasterViews { get; set; }

    public virtual DbSet<MlsProfilesView> MlsProfilesViews { get; set; }

    public virtual DbSet<MlsSiteRef> MlsSiteRefs { get; set; }

    public virtual DbSet<MlsSiteValue> MlsSiteValues { get; set; }

    public virtual DbSet<ModuleValue> ModuleValues { get; set; }

    public virtual DbSet<ModulesRef> ModulesRefs { get; set; }

    public virtual DbSet<MonthClosing> MonthClosings { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OmEmpOrderListTest> OmEmpOrderListTests { get; set; }

    public virtual DbSet<OmEmpOrderListTest1> OmEmpOrderListTest1s { get; set; }

    public virtual DbSet<OmEmpOrderListTest2> OmEmpOrderListTest2s { get; set; }

    public virtual DbSet<OmEmpOrderListTest3> OmEmpOrderListTest3s { get; set; }

    public virtual DbSet<OmEmpOrderListTestBefAutoBpoStatus> OmEmpOrderListTestBefAutoBpoStatuses { get; set; }

    public virtual DbSet<OmEmpOrderListTestBefCreatedBy> OmEmpOrderListTestBefCreatedBies { get; set; }

    public virtual DbSet<OmEmpOrderListTestCreatedBy> OmEmpOrderListTestCreatedBies { get; set; }

    public virtual DbSet<OmEmpOrderListTestRam> OmEmpOrderListTestRams { get; set; }

    public virtual DbSet<OmVwAcceptOrderlist> OmVwAcceptOrderlists { get; set; }

    public virtual DbSet<OmVwAcceptOrderlist1> OmVwAcceptOrderlist1s { get; set; }

    public virtual DbSet<OmVwCmCustorderlist> OmVwCmCustorderlists { get; set; }

    public virtual DbSet<OmVwComment> OmVwComments { get; set; }

    public virtual DbSet<OmVwComments1> OmVwComments1s { get; set; }

    public virtual DbSet<OmVwCustWorkingOrd> OmVwCustWorkingOrds { get; set; }

    public virtual DbSet<OmVwCustomerOrderStatus> OmVwCustomerOrderStatuses { get; set; }

    public virtual DbSet<OmVwCustomerOrderStatus1> OmVwCustomerOrderStatus1s { get; set; }

    public virtual DbSet<OmVwEmpDesigStatus> OmVwEmpDesigStatuses { get; set; }

    public virtual DbSet<OmVwGridList> OmVwGridLists { get; set; }

    public virtual DbSet<OmVwOrdStatusCheck> OmVwOrdStatusChecks { get; set; }

    public virtual DbSet<OmVwOrderlist> OmVwOrderlists { get; set; }

    public virtual DbSet<OmVwSoftOrderlist> OmVwSoftOrderlists { get; set; }

    public virtual DbSet<OmVwSoftOrderlistBefOrderDueDate> OmVwSoftOrderlistBefOrderDueDates { get; set; }

    public virtual DbSet<OrderHistoryTemp> OrderHistoryTemps { get; set; }

    public virtual DbSet<OrderIncentiveCalc> OrderIncentiveCalcs { get; set; }

    public virtual DbSet<OwningCostCtrRef> OwningCostCtrRefs { get; set; }

    public virtual DbSet<OwningCostCtrValue> OwningCostCtrValues { get; set; }

    public virtual DbSet<PriorityTierMapping> PriorityTierMappings { get; set; }

    public virtual DbSet<ReportCustomField> ReportCustomFields { get; set; }

    public virtual DbSet<ReportFile> ReportFiles { get; set; }

    public virtual DbSet<ReportMasterDatasource> ReportMasterDatasources { get; set; }

    public virtual DbSet<ReportMasterRef> ReportMasterRefs { get; set; }

    public virtual DbSet<ReportMasterValue> ReportMasterValues { get; set; }

    public virtual DbSet<ReportStyle> ReportStyles { get; set; }

    public virtual DbSet<ReportStyleRef> ReportStyleRefs { get; set; }

    public virtual DbSet<ReportStyleValue> ReportStyleValues { get; set; }

    public virtual DbSet<RoleMasterRef> RoleMasterRefs { get; set; }

    public virtual DbSet<RoleMasterValue> RoleMasterValues { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<RptEmpwiseQcTemp> RptEmpwiseQcTemps { get; set; }

    public virtual DbSet<RptVwClientDetail> RptVwClientDetails { get; set; }

    public virtual DbSet<RptVwClientList> RptVwClientLists { get; set; }

    public virtual DbSet<RptVwClientOrder> RptVwClientOrders { get; set; }

    public virtual DbSet<RptVwClientOrder1> RptVwClientOrder1s { get; set; }

    public virtual DbSet<RptVwClientOrderSummary> RptVwClientOrderSummaries { get; set; }

    public virtual DbSet<RptVwClientOrderSummary1> RptVwClientOrderSummary1s { get; set; }

    public virtual DbSet<RptVwDailyOrderStatusEmp> RptVwDailyOrderStatusEmps { get; set; }

    public virtual DbSet<RptVwDailyOrderStatusEmp1> RptVwDailyOrderStatusEmp1s { get; set; }

    public virtual DbSet<RptVwEmpOrganisationDetail> RptVwEmpOrganisationDetails { get; set; }

    public virtual DbSet<RptVwEmpPendingOrder> RptVwEmpPendingOrders { get; set; }

    public virtual DbSet<RptVwEmpPendingOrders1> RptVwEmpPendingOrders1s { get; set; }

    public virtual DbSet<RptVwEmployeeAbsentee> RptVwEmployeeAbsentees { get; set; }

    public virtual DbSet<RptVwEmployeeAttendance> RptVwEmployeeAttendances { get; set; }

    public virtual DbSet<RptVwEmployeeDetail> RptVwEmployeeDetails { get; set; }

    public virtual DbSet<RptVwEmployeePersonalDetailL> RptVwEmployeePersonalDetailLs { get; set; }

    public virtual DbSet<RptVwEmployeeReport> RptVwEmployeeReports { get; set; }

    public virtual DbSet<RptVwEmployeelist> RptVwEmployeelists { get; set; }

    public virtual DbSet<RptVwEmploymentDetail> RptVwEmploymentDetails { get; set; }

    public virtual DbSet<RptVwGstDetail> RptVwGstDetails { get; set; }

    public virtual DbSet<RptVwInvoiceReport> RptVwInvoiceReports { get; set; }

    public virtual DbSet<RptVwInvoiceReport1> RptVwInvoiceReport1s { get; set; }

    public virtual DbSet<RptVwInvoiceReportAmt> RptVwInvoiceReportAmts { get; set; }

    public virtual DbSet<RptVwInvoiceReportAmt1> RptVwInvoiceReportAmt1s { get; set; }

    public virtual DbSet<RptVwInvoiceReportAmtInv> RptVwInvoiceReportAmtInvs { get; set; }

    public virtual DbSet<RptVwInvoiceReportInv> RptVwInvoiceReportInvs { get; set; }

    public virtual DbSet<RptVwInvoiceReportOld> RptVwInvoiceReportOlds { get; set; }

    public virtual DbSet<RptVwInvoiceReportWorking> RptVwInvoiceReportWorkings { get; set; }

    public virtual DbSet<RptVwLeaveReport> RptVwLeaveReports { get; set; }

    public virtual DbSet<RptVwPicWaiting> RptVwPicWaitings { get; set; }

    public virtual DbSet<RptVwPicWaiting1> RptVwPicWaiting1s { get; set; }

    public virtual DbSet<RptVwSelectemployee> RptVwSelectemployees { get; set; }

    public virtual DbSet<SalaryTypeRef> SalaryTypeRefs { get; set; }

    public virtual DbSet<ServerCategoryRef> ServerCategoryRefs { get; set; }

    public virtual DbSet<SessionManagement> SessionManagements { get; set; }

    public virtual DbSet<ShiftMaster> ShiftMasters { get; set; }

    public virtual DbSet<ShiftSetStatus> ShiftSetStatuses { get; set; }

    public virtual DbSet<SiteMasterView> SiteMasterViews { get; set; }

    public virtual DbSet<SiteRef> SiteRefs { get; set; }

    public virtual DbSet<SiteValue> SiteValues { get; set; }

    public virtual DbSet<SiteValues1> SiteValues1s { get; set; }

    public virtual DbSet<SiteValuesWorking> SiteValuesWorkings { get; set; }

    public virtual DbSet<SlTbAreaMaster> SlTbAreaMasters { get; set; }

    public virtual DbSet<SlTbAreaValue> SlTbAreaValues { get; set; }

    public virtual DbSet<SlTbBrowserMaster> SlTbBrowserMasters { get; set; }

    public virtual DbSet<SlTbClientEmailConfig> SlTbClientEmailConfigs { get; set; }

    public virtual DbSet<SlTbClientPaymentType> SlTbClientPaymentTypes { get; set; }

    public virtual DbSet<SlTbClientPaymentTypeInv> SlTbClientPaymentTypeInvs { get; set; }

    public virtual DbSet<SlTbCompanyDetail> SlTbCompanyDetails { get; set; }

    public virtual DbSet<SlTbContactMaster> SlTbContactMasters { get; set; }

    public virtual DbSet<SlTbCustomerMaster> SlTbCustomerMasters { get; set; }

    public virtual DbSet<SlTbDistrictMaster> SlTbDistrictMasters { get; set; }

    public virtual DbSet<SlTbDistrictValue> SlTbDistrictValues { get; set; }

    public virtual DbSet<SlTbEmirateMaster> SlTbEmirateMasters { get; set; }

    public virtual DbSet<SlTbEmirateValue> SlTbEmirateValues { get; set; }

    public virtual DbSet<SlTbEmployeeSite> SlTbEmployeeSites { get; set; }

    public virtual DbSet<SlTbInvoiceAmount> SlTbInvoiceAmounts { get; set; }

    public virtual DbSet<SlTbInvoiceAmount1> SlTbInvoiceAmount1s { get; set; }

    public virtual DbSet<SlTbInvoiceDetaile> SlTbInvoiceDetailes { get; set; }

    public virtual DbSet<SlTbInvoiceDetailes1> SlTbInvoiceDetailes1s { get; set; }

    public virtual DbSet<SlTbInvoiceMaster> SlTbInvoiceMasters { get; set; }

    public virtual DbSet<SlTbInvoiceMaster1> SlTbInvoiceMaster1s { get; set; }

    public virtual DbSet<SlTbLocationMaster> SlTbLocationMasters { get; set; }

    public virtual DbSet<SlTbStationMaster> SlTbStationMasters { get; set; }

    public virtual DbSet<SlTbVwMarketMaster> SlTbVwMarketMasters { get; set; }

    public virtual DbSet<SlVwAreaMaster> SlVwAreaMasters { get; set; }

    public virtual DbSet<SlVwBindCountry> SlVwBindCountries { get; set; }

    public virtual DbSet<SlVwClientGroupMap> SlVwClientGroupMaps { get; set; }

    public virtual DbSet<SlVwClientGroupMap1> SlVwClientGroupMap1s { get; set; }

    public virtual DbSet<SlVwClientMailInfo> SlVwClientMailInfos { get; set; }

    public virtual DbSet<SlVwClientMailInfo1> SlVwClientMailInfo1s { get; set; }

    public virtual DbSet<SlVwCountryMaster> SlVwCountryMasters { get; set; }

    public virtual DbSet<SlVwLanguageMaster> SlVwLanguageMasters { get; set; }

    public virtual DbSet<SlVwMlsSiteValue> SlVwMlsSiteValues { get; set; }

    public virtual DbSet<SlVwRegionMaster> SlVwRegionMasters { get; set; }

    public virtual DbSet<SlVwSiteMlsDetail> SlVwSiteMlsDetails { get; set; }

    public virtual DbSet<SlVwStation> SlVwStations { get; set; }

    public virtual DbSet<StatusDesignationMap> StatusDesignationMaps { get; set; }

    public virtual DbSet<StatusReasonMap> StatusReasonMaps { get; set; }

    public virtual DbSet<StatusReasonRef> StatusReasonRefs { get; set; }

    public virtual DbSet<StatusRef> StatusRefs { get; set; }

    public virtual DbSet<StatusUserFilter> StatusUserFilters { get; set; }

    public virtual DbSet<StyleProperty> StyleProperties { get; set; }

    public virtual DbSet<SubModuleValue> SubModuleValues { get; set; }

    public virtual DbSet<SubModulesRef> SubModulesRefs { get; set; }

    public virtual DbSet<SystemParameter> SystemParameters { get; set; }

    public virtual DbSet<TbRptEmpDailyOrderStatusTemp> TbRptEmpDailyOrderStatusTemps { get; set; }

    public virtual DbSet<TbRptEmpDailyWorkOrderStatusTemp> TbRptEmpDailyWorkOrderStatusTemps { get; set; }

    public virtual DbSet<TfsTbAcceptedByList> TfsTbAcceptedByLists { get; set; }

    public virtual DbSet<TfsTbAcceptedByStatus> TfsTbAcceptedByStatuses { get; set; }

    public virtual DbSet<TfsTbAccountsUserMaster> TfsTbAccountsUserMasters { get; set; }

    public virtual DbSet<TfsTbAssignedCountClient> TfsTbAssignedCountClients { get; set; }

    public virtual DbSet<TfsTbAtsPercentage> TfsTbAtsPercentages { get; set; }

    public virtual DbSet<TfsTbAutoBpoBed> TfsTbAutoBpoBeds { get; set; }

    public virtual DbSet<TfsTbAutoBpoClientMap> TfsTbAutoBpoClientMaps { get; set; }

    public virtual DbSet<TfsTbAutoBpoOrderHistory> TfsTbAutoBpoOrderHistories { get; set; }

    public virtual DbSet<TfsTbAutoBpoZipcode> TfsTbAutoBpoZipcodes { get; set; }

    public virtual DbSet<TfsTbAutoBpoZipcodes1> TfsTbAutoBpoZipcodes1s { get; set; }

    public virtual DbSet<TfsTbBranchWiseEmployeeCount> TfsTbBranchWiseEmployeeCounts { get; set; }

    public virtual DbSet<TfsTbClientDueAmount> TfsTbClientDueAmounts { get; set; }

    public virtual DbSet<TfsTbClientZipcodeCount> TfsTbClientZipcodeCounts { get; set; }

    public virtual DbSet<TfsTbClientwiseRpt> TfsTbClientwiseRpts { get; set; }

    public virtual DbSet<TfsTbDailyAtsCount> TfsTbDailyAtsCounts { get; set; }

    public virtual DbSet<TfsTbDailyManualCount> TfsTbDailyManualCounts { get; set; }

    public virtual DbSet<TfsTbEmployeeJoiningDate> TfsTbEmployeeJoiningDates { get; set; }

    public virtual DbSet<TfsTbEmployeeWorkAssigned> TfsTbEmployeeWorkAssigneds { get; set; }

    public virtual DbSet<TfsTbEmployeeWorkAssigned1> TfsTbEmployeeWorkAssigned1s { get; set; }

    public virtual DbSet<TfsTbEmployeeWorkCountClientWise> TfsTbEmployeeWorkCountClientWises { get; set; }

    public virtual DbSet<TfsTbEmployeeWorkCountClientWise1> TfsTbEmployeeWorkCountClientWise1s { get; set; }

    public virtual DbSet<TfsTbFipsCountyIdMaster> TfsTbFipsCountyIdMasters { get; set; }

    public virtual DbSet<TfsTbGroupMap> TfsTbGroupMaps { get; set; }

    public virtual DbSet<TfsTbGroupMap1> TfsTbGroupMap1s { get; set; }

    public virtual DbSet<TfsTbGroupMaster> TfsTbGroupMasters { get; set; }

    public virtual DbSet<TfsTbIgnoredOrder> TfsTbIgnoredOrders { get; set; }

    public virtual DbSet<TfsTbIgnoredOrdersRpt> TfsTbIgnoredOrdersRpts { get; set; }

    public virtual DbSet<TfsTbInvoiceAmountDetail> TfsTbInvoiceAmountDetails { get; set; }

    public virtual DbSet<TfsTbInvoiceCodeMaster> TfsTbInvoiceCodeMasters { get; set; }

    public virtual DbSet<TfsTbMlsMaster> TfsTbMlsMasters { get; set; }

    public virtual DbSet<TfsTbModule> TfsTbModules { get; set; }

    public virtual DbSet<TfsTbModules1> TfsTbModules1s { get; set; }

    public virtual DbSet<TfsTbOrderAssignAvgCount> TfsTbOrderAssignAvgCounts { get; set; }

    public virtual DbSet<TfsTbOrderInstructionsFile> TfsTbOrderInstructionsFiles { get; set; }

    public virtual DbSet<TfsTbOrderNotification> TfsTbOrderNotifications { get; set; }

    public virtual DbSet<TfsTbOrderUserFilter> TfsTbOrderUserFilters { get; set; }

    public virtual DbSet<TfsTbPortalClientOrderCount> TfsTbPortalClientOrderCounts { get; set; }

    public virtual DbSet<TfsTbPortalOrderCount> TfsTbPortalOrderCounts { get; set; }

    public virtual DbSet<TfsTbRoleMaster> TfsTbRoleMasters { get; set; }

    public virtual DbSet<TfsTbRoleMaster1> TfsTbRoleMaster1s { get; set; }

    public virtual DbSet<TfsTbRolePermission> TfsTbRolePermissions { get; set; }

    public virtual DbSet<TfsTbRolePermission1> TfsTbRolePermission1s { get; set; }

    public virtual DbSet<TfsTbRptEmpAbsenteesTemp> TfsTbRptEmpAbsenteesTemps { get; set; }

    public virtual DbSet<TfsTbRptEmpPerfomanceTemp> TfsTbRptEmpPerfomanceTemps { get; set; }

    public virtual DbSet<TfsTbRptEmpPerfomanceTemp1> TfsTbRptEmpPerfomanceTemp1s { get; set; }

    public virtual DbSet<TfsTbRptEmpwiseTrackingTemp> TfsTbRptEmpwiseTrackingTemps { get; set; }

    public virtual DbSet<TfsTbRptIncentiveTemp> TfsTbRptIncentiveTemps { get; set; }

    public virtual DbSet<TfsTbSoftexDetail> TfsTbSoftexDetails { get; set; }

    public virtual DbSet<TfsTbStateWiseCount> TfsTbStateWiseCounts { get; set; }

    public virtual DbSet<TfsTbSubModule> TfsTbSubModules { get; set; }

    public virtual DbSet<TfsTbUnassignedOrder> TfsTbUnassignedOrders { get; set; }

    public virtual DbSet<TfsTbUserMaster> TfsTbUserMasters { get; set; }

    public virtual DbSet<TfsTbZipcodeMlsMap> TfsTbZipcodeMlsMaps { get; set; }

    public virtual DbSet<TfsTbZipcodeTrend> TfsTbZipcodeTrends { get; set; }

    public virtual DbSet<TfsUserLoginLog> TfsUserLoginLogs { get; set; }

    public virtual DbSet<TfsVwAssignedCountClient> TfsVwAssignedCountClients { get; set; }

    public virtual DbSet<TfsVwAssignedCountClient1> TfsVwAssignedCountClient1s { get; set; }

    public virtual DbSet<TfsVwAutoBpoClientMap> TfsVwAutoBpoClientMaps { get; set; }

    public virtual DbSet<TfsVwAutoBpoHistory> TfsVwAutoBpoHistories { get; set; }

    public virtual DbSet<TfsVwAutoBpoOrder> TfsVwAutoBpoOrders { get; set; }

    public virtual DbSet<TfsVwClientDashboard> TfsVwClientDashboards { get; set; }

    public virtual DbSet<TfsVwEmpUserList> TfsVwEmpUserLists { get; set; }

    public virtual DbSet<TfsVwEmpUserListBefBug> TfsVwEmpUserListBefBugs { get; set; }

    public virtual DbSet<TfsVwEmpUserListEncodedUserMaster> TfsVwEmpUserListEncodedUserMasters { get; set; }

    public virtual DbSet<TfsVwEmployeeAssignedWork> TfsVwEmployeeAssignedWorks { get; set; }

    public virtual DbSet<TfsVwEmployeeAssignedWorks1> TfsVwEmployeeAssignedWorks1s { get; set; }

    public virtual DbSet<TfsVwEmployeeAssignedWorks2> TfsVwEmployeeAssignedWorks2s { get; set; }

    public virtual DbSet<TfsVwEmployeeAttendanceGroup> TfsVwEmployeeAttendanceGroups { get; set; }

    public virtual DbSet<TfsVwEmployeeAttendanceGroup1> TfsVwEmployeeAttendanceGroup1s { get; set; }

    public virtual DbSet<TfsVwEmployeeAttendanceGroupCrct> TfsVwEmployeeAttendanceGroupCrcts { get; set; }

    public virtual DbSet<TfsVwEmployeeDetail> TfsVwEmployeeDetails { get; set; }

    public virtual DbSet<TfsVwEmployeeDetailsEncodedUserMaster> TfsVwEmployeeDetailsEncodedUserMasters { get; set; }

    public virtual DbSet<TfsVwEmployeelist> TfsVwEmployeelists { get; set; }

    public virtual DbSet<TfsVwInvoiceAmountDetail> TfsVwInvoiceAmountDetails { get; set; }

    public virtual DbSet<TfsVwMlsZipGroupMap> TfsVwMlsZipGroupMaps { get; set; }

    public virtual DbSet<TfsVwRoleListDatum> TfsVwRoleListData { get; set; }

    public virtual DbSet<TfsVwUnassignedOrder> TfsVwUnassignedOrders { get; set; }

    public virtual DbSet<TfsVwUserMenu> TfsVwUserMenus { get; set; }

    public virtual DbSet<TimeTakenTmp> TimeTakenTmps { get; set; }

    public virtual DbSet<TimeTakenTmp1> TimeTakenTmp1s { get; set; }

    public virtual DbSet<TimeclockDetail> TimeclockDetails { get; set; }

    public virtual DbSet<TimeclockEntry> TimeclockEntries { get; set; }

    public virtual DbSet<TimeclockMaster> TimeclockMasters { get; set; }

    public virtual DbSet<TlSelectCountry> TlSelectCountries { get; set; }

    public virtual DbSet<TlVwSelectAreaList> TlVwSelectAreaLists { get; set; }

    public virtual DbSet<TlVwSelectMarketList> TlVwSelectMarketLists { get; set; }

    public virtual DbSet<TlVwSelectRegionList> TlVwSelectRegionLists { get; set; }

    public virtual DbSet<UploadLogDatum> UploadLogData { get; set; }

    public virtual DbSet<UserAccessDetail> UserAccessDetails { get; set; }

    public virtual DbSet<UserCompany> UserCompanies { get; set; }

    public virtual DbSet<UserCustomRole> UserCustomRoles { get; set; }

    public virtual DbSet<UserMaster> UserMasters { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<VwChkFieldReference> VwChkFieldReferences { get; set; }

    public virtual DbSet<VwClientDuePendingDetail> VwClientDuePendingDetails { get; set; }

    public virtual DbSet<VwDefDept> VwDefDepts { get; set; }

    public virtual DbSet<VwEmployeeSite> VwEmployeeSites { get; set; }

    public virtual DbSet<VwEmployeeSite1> VwEmployeeSite1s { get; set; }

    public virtual DbSet<VwInvoiceGenOrderList> VwInvoiceGenOrderLists { get; set; }

    public virtual DbSet<VwInvoiceGenOrderListOld> VwInvoiceGenOrderListOlds { get; set; }

    public virtual DbSet<VwInvoiceList> VwInvoiceLists { get; set; }

    public virtual DbSet<VwInvoiceList1> VwInvoiceList1s { get; set; }

    public virtual DbSet<VwInvoiceListBefSendMail> VwInvoiceListBefSendMails { get; set; }

    public virtual DbSet<VwSiteUserCredential> VwSiteUserCredentials { get; set; }

    public virtual DbSet<VwSubmissionCount> VwSubmissionCounts { get; set; }

    public virtual DbSet<VwSubmissionCountSchedule> VwSubmissionCountSchedules { get; set; }

    public virtual DbSet<WsAssettypeRef> WsAssettypeRefs { get; set; }

    public virtual DbSet<WsVwLeavelist> WsVwLeavelists { get; set; }

    public virtual DbSet<YearUpdate> YearUpdates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=D3ES-07;Database=NEW_GEN_TFS_DB;Integrated Security=False;User ID=sa;Password=admin1;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AI");

        modelBuilder.Entity<AdFinYr>(entity =>
        {
            entity.ToView("AD_Fin_Yr");

            entity.Property(e => e.FinYearid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdTbCompanyMaster>(entity =>
        {
            entity.HasKey(e => e.CmCompanyId).HasName("PK_COMPANY_MASTER");
        });

        modelBuilder.Entity<AdTbFinancialYear>(entity =>
        {
            entity.HasKey(e => e.FinYearid).HasName("PK_M909_AD_TB_FINANCIAL_YEAR");

            entity.Property(e => e.FinCloseFlag).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<AdVwAnnouncement>(entity =>
        {
            entity.ToView("AD_VW_ANNOUNCEMENT");

            entity.Property(e => e.EntryRefNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdVwAnnouncementList>(entity =>
        {
            entity.ToView("AD_VW_ANNOUNCEMENT_LIST");
        });

        modelBuilder.Entity<AdVwClientOrder>(entity =>
        {
            entity.ToView("AD_VW_CLIENT_ORDER");
        });

        modelBuilder.Entity<AdVwClientOrder1>(entity =>
        {
            entity.ToView("AD_VW_CLIENT_ORDER_1");
        });

        modelBuilder.Entity<AdVwClientService>(entity =>
        {
            entity.ToView("AD_VW_CLIENT_SERVICES");
        });

        modelBuilder.Entity<AdVwClientServices1>(entity =>
        {
            entity.ToView("AD_VW_CLIENT_SERVICES_1");
        });

        modelBuilder.Entity<AdVwCurrentUserDet>(entity =>
        {
            entity.ToView("AD_VW_CURRENT_USER_DET");
        });

        modelBuilder.Entity<AdVwCurrentUserRole>(entity =>
        {
            entity.ToView("AD_VW_CURRENT_USER_ROLES");
        });

        modelBuilder.Entity<AdVwEmployeeAnnouncement>(entity =>
        {
            entity.ToView("AD_VW_EMPLOYEE_ANNOUNCEMENT");
        });

        modelBuilder.Entity<AdVwFinyearCreate>(entity =>
        {
            entity.ToView("AD_VW_FINYEAR_CREATE");
        });

        modelBuilder.Entity<AdVwFinyearId>(entity =>
        {
            entity.ToView("AD_VW_FINYEAR_ID");
        });

        modelBuilder.Entity<AdVwFinyearNewFinyid>(entity =>
        {
            entity.ToView("AD_VW_FINYEAR_NEW_FINYID");
        });

        modelBuilder.Entity<AdVwHelpTemplate>(entity =>
        {
            entity.ToView("AD_VW_HELP_TEMPLATE");
        });

        modelBuilder.Entity<AdVwModule>(entity =>
        {
            entity.ToView("AD_VW_MODULES");
        });

        modelBuilder.Entity<AdVwModulesSubModule>(entity =>
        {
            entity.ToView("AD_VW_MODULES_SUB_MODULES");
        });

        modelBuilder.Entity<AdVwRoleMaster>(entity =>
        {
            entity.ToView("AD_VW_ROLE_MASTER");
        });

        modelBuilder.Entity<AdVwRolePermissionTemplate>(entity =>
        {
            entity.ToView("AD_VW_ROLE_PERMISSION_TEMPLATE");
        });

        modelBuilder.Entity<AdVwSubModule>(entity =>
        {
            entity.ToView("AD_VW_SUB_MODULES");
        });

        modelBuilder.Entity<AdVwUser>(entity =>
        {
            entity.ToView("AD_VW_USER");

            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdVwUser1>(entity =>
        {
            entity.ToView("AD_VW_USER_1");

            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AdVwUserAccess>(entity =>
        {
            entity.ToView("AD_VW_USER_ACCESS");
        });

        modelBuilder.Entity<AdVwUserRole>(entity =>
        {
            entity.ToView("AD_VW_USER_ROLE");
        });

        modelBuilder.Entity<AdVwUserRole1>(entity =>
        {
            entity.ToView("AD_VW_USER_ROLES");
        });

        modelBuilder.Entity<AdVwUserRolePermission>(entity =>
        {
            entity.ToView("AD_VW_USER_ROLE_PERMISSION");
        });

        modelBuilder.Entity<AutoBpoStatusRef>(entity =>
        {
            entity.HasKey(e => e.AutoBpoStatusId).HasName("PK_AUTO_BPO_STATUS_REF_1");

            entity.Property(e => e.AutoBpoStatusId).ValueGeneratedNever();
        });

        modelBuilder.Entity<BankMasterRef>(entity =>
        {
            entity.ToTable("BANK_MASTER_REF", tb => tb.HasTrigger("gs_trigChkIsDefaultOnBankMaster"));
        });

        modelBuilder.Entity<BankMasterValue>(entity =>
        {
            entity.HasOne(d => d.Bank).WithMany(p => p.BankMasterValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BANK_MASTER_VALUES_BANK_MASTER_REF");
        });

        modelBuilder.Entity<BtsBgClientDetail>(entity =>
        {
            entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");
            entity.Property(e => e.Verified).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<BtsBgClientTaskType>(entity =>
        {
            entity.Property(e => e.AddedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasComment("1- Active, 2- Deleted, 3- InActive");
        });

        modelBuilder.Entity<BtsBgCompanyDetail>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PK_BTS_BG_ComapanyDetails");

            entity.Property(e => e.AddedDat).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BtsBgContactU>(entity =>
        {
            entity.Property(e => e.AddedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BtsBgCustomerDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BTS_Customer_Details");
        });

        modelBuilder.Entity<BtsBgOrderImage>(entity =>
        {
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BtsBgOrderLog>(entity =>
        {
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<BtsBgOrderTask>(entity =>
        {
            entity.Property(e => e.Dat).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Fee).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<BtsBgPmb>(entity =>
        {
            entity.Property(e => e.Dat).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<BtsBgRole>(entity =>
        {
            entity.Property(e => e.RoleId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BtsBgStaffMaster>(entity =>
        {
            entity.Property(e => e.RegDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("((1))")
                .HasComment("1-Active,2-Deletetd,3-InActive");
            entity.Property(e => e.Verified).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<BtsBgTaskType>(entity =>
        {
            entity.Property(e => e.Dat).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Fee).HasDefaultValueSql("((0))");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<BtsBgVwZipCodeDetail>(entity =>
        {
            entity.ToView("BTS_BG_VW_ZipCodeDetails");
        });

        modelBuilder.Entity<BtsTbBpoOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).IsClustered(false);

            entity.HasIndex(e => e.StatusId, "IX_BPO_Status").IsClustered();

            entity.Property(e => e.CancelledBy).HasDefaultValueSql("((0))");
            entity.Property(e => e.OrderNotified).HasDefaultValueSql("((0))");
            entity.Property(e => e.RentalValue).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<BtsTbClientDoc>(entity =>
        {
            entity.Property(e => e.AttachmentId).ValueGeneratedOnAdd();
            entity.Property(e => e.UploadOn).IsFixedLength();
        });

        modelBuilder.Entity<BtsTbClientPhotoghrMap>(entity =>
        {
            entity.HasKey(e => e.RefNo).HasName("PK_BTS_TB_CLIENT_PHOTOGHR_MAP_1");
        });

        modelBuilder.Entity<BtsTbClientPhotoghrMap1>(entity =>
        {
            entity.HasKey(e => e.RefNo).HasName("PK_BTS_TB_CLIENT_PHOTOGHR_MAP");
        });

        modelBuilder.Entity<BtsTbClientPortalMap>(entity =>
        {
            entity.HasKey(e => e.RefNo).HasName("PK_BTS_TB_CLIENT_PORTAL_MAP_2");
        });

        modelBuilder.Entity<BtsTbClientPortalMap1>(entity =>
        {
            entity.HasKey(e => e.RefNo).HasName("PK_BTS_TB_CLIENT_PORTAL_MAP");
        });

        modelBuilder.Entity<BtsTbCpdMaster>(entity =>
        {
            entity.HasKey(e => e.RefNo).HasName("PK_BTS_TB_CPD_MASTER_6");
        });

        modelBuilder.Entity<BtsTbCpdMasterRam>(entity =>
        {
            entity.HasKey(e => e.RefNo).HasName("PK_BTS_TB_CPD_MASTER");
        });

        modelBuilder.Entity<BtsTbCpdMasterWorking>(entity =>
        {
            entity.HasKey(e => e.RefNo).HasName("PK_BTS_TB_CPD_MASTER_2");
        });

        modelBuilder.Entity<BtsTbMailTemplate>(entity =>
        {
            entity.HasKey(e => e.MailTempNo).HasName("PK_BTS_TB_MAIL_TEMPLATE_1");
        });

        modelBuilder.Entity<BtsTbOrderTask>(entity =>
        {
            entity.Property(e => e.PhotoUpdatedDate).IsFixedLength();
        });

        modelBuilder.Entity<BtsTbPortalMaster>(entity =>
        {
            entity.HasKey(e => e.PortalId).HasName("PK_BTS_TB_PORTAL_MASTER_2");
        });

        modelBuilder.Entity<BtsTbReportDatum>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK_BTS_TB_REPORTDATA_1");
        });

        modelBuilder.Entity<BtsTbRolePermission>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK_BTS_TB_ROLE_PERMISSION1");
        });

        modelBuilder.Entity<BtsTbUserMaster>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_BTS_TB_USER_MASTER_2");
        });

        modelBuilder.Entity<BtsVwBpoOrderList>(entity =>
        {
            entity.ToView("BTS_VW_BPO_ORDER_LIST");
        });

        modelBuilder.Entity<BtsVwBpoOrderList1>(entity =>
        {
            entity.ToView("BTS_VW_BPO_ORDER_LIST_1");
        });

        modelBuilder.Entity<BtsVwBpoOrderListOld>(entity =>
        {
            entity.ToView("BTS_VW_BPO_ORDER_LIST_old");
        });

        modelBuilder.Entity<BtsVwBpoOrderListRam>(entity =>
        {
            entity.ToView("BTS_VW_BPO_ORDER_LIST_ram");
        });

        modelBuilder.Entity<BtsVwBpoOrderPhtList>(entity =>
        {
            entity.ToView("BTS_VW_BPO_ORDER_PHT_LIST");
        });

        modelBuilder.Entity<BtsVwCityList>(entity =>
        {
            entity.ToView("BTS_VW_CITY_LIST");
        });

        modelBuilder.Entity<BtsVwClPortalMap>(entity =>
        {
            entity.ToView("BTS_VW_CL_PORTAL_MAP");
        });

        modelBuilder.Entity<BtsVwClientPhtList>(entity =>
        {
            entity.ToView("BTS_VW_CLIENT_PHT_LIST");
        });

        modelBuilder.Entity<BtsVwClientVsPhotoghr>(entity =>
        {
            entity.ToView("BTS_VW_CLIENT_VS_PHOTOGHR");
        });

        modelBuilder.Entity<BtsVwCountyList>(entity =>
        {
            entity.ToView("BTS_VW_COUNTY_LIST");
        });

        modelBuilder.Entity<BtsVwCpdMaster>(entity =>
        {
            entity.ToView("BTS_VW_CPD_MASTER");
        });

        modelBuilder.Entity<BtsVwCpdUserList>(entity =>
        {
            entity.ToView("BTS_VW_CPD_USER_LIST");
        });

        modelBuilder.Entity<BtsVwGetReportToClient>(entity =>
        {
            entity.ToView("BTS_VW_GET_REPORT_TO_CLIENT");
        });

        modelBuilder.Entity<BtsVwOrderTasksFee>(entity =>
        {
            entity.ToView("BTS_VW_ORDER_TASKS_FEE");
        });

        modelBuilder.Entity<BtsVwPhotoClientMap>(entity =>
        {
            entity.ToView("BTS_VW_PHOTO_CLIENT_MAP");
        });

        modelBuilder.Entity<BtsVwPhotographerListing>(entity =>
        {
            entity.ToView("BTS_VW_PHOTOGRAPHER_LISTING");
        });

        modelBuilder.Entity<BtsVwPhotographerListing1>(entity =>
        {
            entity.ToView("BTS_VW_PHOTOGRAPHER_LISTING_1");
        });

        modelBuilder.Entity<BtsVwPhotographerListingOld>(entity =>
        {
            entity.ToView("BTS_VW_PHOTOGRAPHER_LISTING_old");
        });

        modelBuilder.Entity<BtsVwRoleListDataWithModule>(entity =>
        {
            entity.ToView("BTS_VW_ROLE_LIST_DATA_WITH_MODULES");
        });

        modelBuilder.Entity<BtsVwRoleListDatum>(entity =>
        {
            entity.ToView("BTS_VW_ROLE_LIST_DATA");

            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BtsVwRolePermission>(entity =>
        {
            entity.ToView("BTS_VW_ROLE_PERMISSION");
        });

        modelBuilder.Entity<BtsVwRptDailyOrder>(entity =>
        {
            entity.ToView("BTS_VW_RPT_DAILY_ORDER");
        });

        modelBuilder.Entity<BtsVwUserMenu>(entity =>
        {
            entity.ToView("BTS_VW_USER_MENU");
        });

        modelBuilder.Entity<BtsVwUserSession>(entity =>
        {
            entity.ToView("BTS_VW_USER_SESSION");
        });

        modelBuilder.Entity<BtsVwZipcodeMaster>(entity =>
        {
            entity.ToView("BTS_VW_ZIPCODE_MASTER");
        });

        modelBuilder.Entity<ClientCoverageView>(entity =>
        {
            entity.ToView("CLIENT_COVERAGE_VIEW");
        });

        modelBuilder.Entity<ClientMlsPortalView>(entity =>
        {
            entity.ToView("CLIENT_MLS_PORTAL_VIEW");
        });

        modelBuilder.Entity<CmVwCurrentUser>(entity =>
        {
            entity.ToView("CM_VW_CURRENT_USERS");
        });

        modelBuilder.Entity<CmVwCurrentUserDetail>(entity =>
        {
            entity.ToView("CM_VW_CURRENT_USER_DETAIL");
        });

        modelBuilder.Entity<CmVwEmporderslist>(entity =>
        {
            entity.ToView("CM_VW_EMPORDERSLIST");
        });

        modelBuilder.Entity<CmVwLanguage>(entity =>
        {
            entity.ToView("CM_VW_LANGUAGE");
        });

        modelBuilder.Entity<CmVwMenu1>(entity =>
        {
            entity.ToView("CM_VW_MENU_1");
        });

        modelBuilder.Entity<CmVwOrderslist>(entity =>
        {
            entity.ToView("CM_VW_ORDERSLIST");
        });

        modelBuilder.Entity<CmVwUserMenu>(entity =>
        {
            entity.ToView("CM_VW_USER_MENU");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__Contacts__5C6625BB513E7D5D");
        });

        modelBuilder.Entity<CustomerOrder1>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK_CUSTOMER_ORDER");
        });

        modelBuilder.Entity<CustomerOrderComment>(entity =>
        {
            entity.HasKey(e => e.CommentId).HasName("PK_COMMENTS");
        });

        modelBuilder.Entity<DepartmentRef>(entity =>
        {
            entity.ToTable("DEPARTMENT_REF", tb => tb.HasTrigger("gs_trigChkIsDefaultOnDepartmentMaster"));
        });

        modelBuilder.Entity<EmpDesignationMasterRef>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK_EMP_DESIGANTION_MASTER_REF");

            entity.ToTable("EMP_DESIGNATION_MASTER_REF", tb => tb.HasTrigger("gs_trigChkIsDefaultOnEmpDesignationMaster"));
        });

        modelBuilder.Entity<EmpDesignationMasterValue>(entity =>
        {
            entity.HasOne(d => d.Designation).WithMany(p => p.EmpDesignationMasterValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMP_DESIGNATION_MASTER_VALUES_EMP_DESIGANTION_MASTER_REF");
        });

        modelBuilder.Entity<ErrorLog1>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_ERROR_LOG");
        });

        modelBuilder.Entity<GlSelectDept>(entity =>
        {
            entity.ToView("GL_SelectDept");
        });

        modelBuilder.Entity<GlVwBank>(entity =>
        {
            entity.ToView("GL_VW_BANK");
        });

        modelBuilder.Entity<GlVwBankMaster>(entity =>
        {
            entity.ToView("GL_VW_BANK_MASTER");
        });

        modelBuilder.Entity<GlVwBindDepartment>(entity =>
        {
            entity.ToView("GL_VW_BIND_DEPARTMENT");
        });

        modelBuilder.Entity<GlVwDepartmentMaster>(entity =>
        {
            entity.ToView("GL_VW_DEPARTMENT_MASTER");
        });

        modelBuilder.Entity<HolidayMasterValue>(entity =>
        {
            entity.HasOne(d => d.Holiday).WithMany(p => p.HolidayMasterValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOLIDAY_MASTER_VALUES_HOLIDAY_MASTER_REF");
        });

        modelBuilder.Entity<HrAdVwUserlist>(entity =>
        {
            entity.ToView("HR_AD_VW_USERLIST");

            entity.Property(e => e.UserId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrTbAnnouncementTmp>(entity =>
        {
            entity.Property(e => e.EntryRefNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HrTbDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK_hr_tb_documents");
        });

        modelBuilder.Entity<HrTbDocumentField>(entity =>
        {
            entity.HasKey(e => e.FieldId).HasName("PK_hr_tb_document_fields");
        });

        modelBuilder.Entity<HrTbDocumentMasterRef>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK_hr_tb_document_master_ref");
        });

        modelBuilder.Entity<HrTbEmployeeExperience>(entity =>
        {
            entity.HasOne(d => d.EmpExp).WithMany(p => p.HrTbEmployeeExperiences).HasConstraintName("FK_HR_TB_EMPLOYEE_EXPERIENCE_HR_TB_EMP_EXPERIENCE");
        });

        modelBuilder.Entity<HrTbEmployeeLeaveEntry>(entity =>
        {
            entity.Property(e => e.NoOfDays).IsFixedLength();
        });

        modelBuilder.Entity<HrTbEmployeeOrderPriority>(entity =>
        {
            entity.HasKey(e => e.OrdPriorityId).HasName("PK_EMPLOYEE_ORDER_PRIORITY");
        });

        modelBuilder.Entity<HrTbEmploymentSetting>(entity =>
        {
            entity.Property(e => e.EmptSetRefNo).ValueGeneratedNever();
        });

        modelBuilder.Entity<HrVwApp>(entity =>
        {
            entity.ToView("HR_VW_APP");
        });

        modelBuilder.Entity<HrVwAttendance>(entity =>
        {
            entity.ToView("HR_VW_ATTENDANCE");
        });

        modelBuilder.Entity<HrVwBindBankdetail>(entity =>
        {
            entity.ToView("HR_VW_BIND_BANKDETAILS");
        });

        modelBuilder.Entity<HrVwBindCompany>(entity =>
        {
            entity.ToView("HR_VW_BindCompany");
        });

        modelBuilder.Entity<HrVwBindDepartment>(entity =>
        {
            entity.ToView("HR_VW_BindDepartment");
        });

        modelBuilder.Entity<HrVwClientCredential>(entity =>
        {
            entity.ToView("HR_VW_CLIENT_CREDENTIALS");
        });

        modelBuilder.Entity<HrVwCommonEmpList>(entity =>
        {
            entity.ToView("HR_VW_COMMON_EMP_LIST");
        });

        modelBuilder.Entity<HrVwDesignationlist>(entity =>
        {
            entity.ToView("HR_VW_DESIGNATIONLIST");
        });

        modelBuilder.Entity<HrVwEmpAutoAssign>(entity =>
        {
            entity.ToView("HR_VW_EMP_AUTO_ASSIGN");
        });

        modelBuilder.Entity<HrVwEmpDetail>(entity =>
        {
            entity.ToView("HR_VW_EMP_DETAIL");
        });

        modelBuilder.Entity<HrVwEmpDetail1>(entity =>
        {
            entity.ToView("HR_VW_EMP_DETAILS");
        });

        modelBuilder.Entity<HrVwEmpLeaveDetail>(entity =>
        {
            entity.ToView("HR_VW_EMP_LEAVE_DETAILS");
        });

        modelBuilder.Entity<HrVwEmpLeaveEntPopup>(entity =>
        {
            entity.ToView("HR_VW_EMP_LEAVE_ENT_POPUP");
        });

        modelBuilder.Entity<HrVwEmpLeaveEntry>(entity =>
        {
            entity.ToView("HR_VW_EMP_LEAVE_ENTRY");
        });

        modelBuilder.Entity<HrVwEmpLeaveInfo>(entity =>
        {
            entity.ToView("HR_VW_EMP_LEAVE_INFO");
        });

        modelBuilder.Entity<HrVwEmpOrderAssignShift>(entity =>
        {
            entity.ToView("HR_VW_EMP_ORDER_ASSIGN_SHIFT");
        });

        modelBuilder.Entity<HrVwEmpOrderPriority>(entity =>
        {
            entity.ToView("HR_VW_EMP_ORDER_PRIORITY");
        });

        modelBuilder.Entity<HrVwEmpShiftDetail>(entity =>
        {
            entity.ToView("HR_VW_EMP_SHIFT_DETAILS");
        });

        modelBuilder.Entity<HrVwEmployeeCompoff>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEE_COMPOFF");
        });

        modelBuilder.Entity<HrVwEmployeeExperienceSelect>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEE_EXPERIENCE_SELECT");
        });

        modelBuilder.Entity<HrVwEmployeeLeave>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEE_LEAVE");

            entity.Property(e => e.NoOfDays).IsFixedLength();
        });

        modelBuilder.Entity<HrVwEmployeeOrderPriorityDetail>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEE_ORDER_PRIORITY_DETAIL");
        });

        modelBuilder.Entity<HrVwEmployeeapprisalSelect>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEEAPPRISAL_SELECT");
        });

        modelBuilder.Entity<HrVwEmployeelist>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEELIST");
        });

        modelBuilder.Entity<HrVwEmployeelistEncodedTable>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEELIST_encoded_table");
        });

        modelBuilder.Entity<HrVwEmployeemasterSelect>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYEEMASTER_SELECT");
        });

        modelBuilder.Entity<HrVwEmploymentDetailsSelect>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYMENT_DETAILS_SELECT");
        });

        modelBuilder.Entity<HrVwEmploymentHistory>(entity =>
        {
            entity.ToView("HR_VW_EMPLOYMENT_HISTORY");
        });

        modelBuilder.Entity<HrVwEmptShiftDetail>(entity =>
        {
            entity.ToView("HR_VW_EMPT_SHIFT_DETAILS");
        });

        modelBuilder.Entity<HrVwHolidayList>(entity =>
        {
            entity.ToView("HR_VW_HOLIDAY_LIST");
        });

        modelBuilder.Entity<HrVwLeaveDateCheck>(entity =>
        {
            entity.ToView("HR_VW_LEAVE_DATE_CHECK");
        });

        modelBuilder.Entity<HrVwLeaveEntryEmpList>(entity =>
        {
            entity.ToView("HR_VW_LEAVE_ENTRY_EMP_LIST");
        });

        modelBuilder.Entity<HrVwLeaveEntryNotification>(entity =>
        {
            entity.ToView("HR_VW_LEAVE_ENTRY_NOTIFICATION");
        });

        modelBuilder.Entity<HrVwLeaveNotification>(entity =>
        {
            entity.ToView("HR_VW_LEAVE_NOTIFICATION");
        });

        modelBuilder.Entity<HrVwLocation>(entity =>
        {
            entity.ToView("HR_VW_LOCATION");
        });

        modelBuilder.Entity<HrVwRejectedLeaveList>(entity =>
        {
            entity.ToView("HR_VW_REJECTED_LEAVE_LIST");

            entity.Property(e => e.NoOfDays).IsFixedLength();
        });

        modelBuilder.Entity<HrVwResignation>(entity =>
        {
            entity.ToView("HR_VW_RESIGNATION");
        });

        modelBuilder.Entity<HrVwRptAppraisalForm>(entity =>
        {
            entity.ToView("HR_VW_RPT_APPRAISAL_FORM");
        });

        modelBuilder.Entity<HrVwSelectInternalCompany>(entity =>
        {
            entity.ToView("HR_VW_SELECT_INTERNAL_COMPANY");
        });

        modelBuilder.Entity<HrVwSelectReasonType>(entity =>
        {
            entity.ToView("HR_VW_SELECT_REASON_TYPE");
        });

        modelBuilder.Entity<LangaugeCodeRef>(entity =>
        {
            entity.ToTable("LANGAUGE_CODE_REF", tb => tb.HasTrigger("gs_trigChkIsDefaultOnLanguageMaster"));
        });

        modelBuilder.Entity<LanguageCodeRefView>(entity =>
        {
            entity.ToView("LanguageCodeRefView");
        });

        modelBuilder.Entity<LanguageLocationView>(entity =>
        {
            entity.ToView("LanguageLocationView");
        });

        modelBuilder.Entity<LanguageStationView>(entity =>
        {
            entity.ToView("LanguageStationView");
        });

        modelBuilder.Entity<LeaveEntryDetail>(entity =>
        {
            entity.HasOne(d => d.LeaveRefNoNavigation).WithMany(p => p.LeaveEntryDetails).HasConstraintName("FK_LEAVE_ENTRY_DETAILS_LEAVE_ENTRY1");
        });

        modelBuilder.Entity<LeaveTypeRef>(entity =>
        {
            entity.ToTable("LEAVE_TYPE_REF", tb => tb.HasTrigger("gs_trigChkIsDefaultOnLeaveTypeMaster"));
        });

        modelBuilder.Entity<LeaveTypeValue>(entity =>
        {
            entity.HasOne(d => d.LeaveType).WithMany(p => p.LeaveTypeValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LEAVE_TYPE_VALUES_LEAVE_TYPE_REF");
        });

        modelBuilder.Entity<MailLogDatum>(entity =>
        {
            entity.HasKey(e => e.MailId).HasName("PK_MAIL_LOG_DATA_1");
        });

        modelBuilder.Entity<MenuRef>(entity =>
        {
            entity.Property(e => e.MenuId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MenuValue>(entity =>
        {
            entity.HasOne(d => d.Menu).WithMany(p => p.MenuValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MENU_VALUES_MENU_REF");
        });

        modelBuilder.Entity<MlsMasterView>(entity =>
        {
            entity.ToView("MLS_MASTER_VIEW");
        });

        modelBuilder.Entity<MlsProfilesView>(entity =>
        {
            entity.ToView("MLS_PROFILES_VIEW");
        });

        modelBuilder.Entity<ModuleValue>(entity =>
        {
            entity.HasOne(d => d.Module).WithMany(p => p.ModuleValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MODULE_VALUES_MODULES_REF");
        });

        modelBuilder.Entity<ModulesRef>(entity =>
        {
            entity.Property(e => e.ModuleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<OmEmpOrderListTest>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST");
        });

        modelBuilder.Entity<OmEmpOrderListTest1>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST_1");
        });

        modelBuilder.Entity<OmEmpOrderListTest2>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST_2");
        });

        modelBuilder.Entity<OmEmpOrderListTest3>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST_3");
        });

        modelBuilder.Entity<OmEmpOrderListTestBefAutoBpoStatus>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST_bef_auto_bpo_status");
        });

        modelBuilder.Entity<OmEmpOrderListTestBefCreatedBy>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST_bef_created_by");
        });

        modelBuilder.Entity<OmEmpOrderListTestCreatedBy>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST_created_by");
        });

        modelBuilder.Entity<OmEmpOrderListTestRam>(entity =>
        {
            entity.ToView("OM_EMP_ORDER_LIST_TEST_ram");
        });

        modelBuilder.Entity<OmVwAcceptOrderlist>(entity =>
        {
            entity.ToView("OM_VW_ACCEPT_ORDERLIST");
        });

        modelBuilder.Entity<OmVwAcceptOrderlist1>(entity =>
        {
            entity.ToView("OM_VW_ACCEPT_ORDERLIST_1");
        });

        modelBuilder.Entity<OmVwCmCustorderlist>(entity =>
        {
            entity.ToView("OM_VW_CM_CUSTORDERLIST");
        });

        modelBuilder.Entity<OmVwComment>(entity =>
        {
            entity.ToView("OM_VW_COMMENTS");
        });

        modelBuilder.Entity<OmVwComments1>(entity =>
        {
            entity.ToView("OM_VW_COMMENTS_1");
        });

        modelBuilder.Entity<OmVwCustWorkingOrd>(entity =>
        {
            entity.ToView("OM_VW_CUST_WORKING_ORD");
        });

        modelBuilder.Entity<OmVwCustomerOrderStatus>(entity =>
        {
            entity.ToView("OM_VW_CUSTOMER_ORDER_STATUS");
        });

        modelBuilder.Entity<OmVwCustomerOrderStatus1>(entity =>
        {
            entity.ToView("OM_VW_CUSTOMER_ORDER_STATUS_1");
        });

        modelBuilder.Entity<OmVwEmpDesigStatus>(entity =>
        {
            entity.ToView("OM_VW_EMP_DESIG_STATUS");
        });

        modelBuilder.Entity<OmVwGridList>(entity =>
        {
            entity.ToView("OM_VW_GRID_LIST");
        });

        modelBuilder.Entity<OmVwOrdStatusCheck>(entity =>
        {
            entity.ToView("OM_VW_ORD_STATUS_CHECK");
        });

        modelBuilder.Entity<OmVwOrderlist>(entity =>
        {
            entity.ToView("OM_VW_ORDERLIST");
        });

        modelBuilder.Entity<OmVwSoftOrderlist>(entity =>
        {
            entity.ToView("OM_VW_SOFT_ORDERLIST");
        });

        modelBuilder.Entity<OmVwSoftOrderlistBefOrderDueDate>(entity =>
        {
            entity.ToView("OM_VW_SOFT_ORDERLIST_bef_order_due_date");
        });

        modelBuilder.Entity<OwningCostCtrRef>(entity =>
        {
            entity.Property(e => e.OwningCostCtr).ValueGeneratedNever();
        });

        modelBuilder.Entity<OwningCostCtrValue>(entity =>
        {
            entity.HasOne(d => d.OwningCostCtrNavigation).WithMany(p => p.OwningCostCtrValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OWNING_COST_CTR_VALUES_OWNING_COST_CTR_REF");
        });

        modelBuilder.Entity<ReportCustomField>(entity =>
        {
            entity.HasKey(e => e.CustomFieldId).HasName("PK_CUSTOM_FIELD_ID");
        });

        modelBuilder.Entity<ReportMasterDatasource>(entity =>
        {
            entity.HasOne(d => d.Report).WithMany(p => p.ReportMasterDatasources).HasConstraintName("FK_REPORT_MASTER_DATASOURCE_REPORT_MASTER_REF");
        });

        modelBuilder.Entity<ReportMasterRef>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PK_ReportMaster");
        });

        modelBuilder.Entity<ReportStyleValue>(entity =>
        {
            entity.HasOne(d => d.Style).WithMany(p => p.ReportStyleValues).HasConstraintName("FK_REPORT_STYLE_VALUES_REPORT_STYLE_REF");
        });

        modelBuilder.Entity<RoleMasterValue>(entity =>
        {
            entity.HasOne(d => d.Role).WithMany(p => p.RoleMasterValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROLE_MASTER_VALUES_ROLE_MASTER_REF");
        });

        modelBuilder.Entity<RptVwClientDetail>(entity =>
        {
            entity.ToView("RPT_VW_CLIENT_DETAIL");
        });

        modelBuilder.Entity<RptVwClientList>(entity =>
        {
            entity.ToView("RPT_VW_CLIENT_LIST");
        });

        modelBuilder.Entity<RptVwClientOrder>(entity =>
        {
            entity.ToView("RPT_VW_CLIENT_ORDER");
        });

        modelBuilder.Entity<RptVwClientOrder1>(entity =>
        {
            entity.ToView("RPT_VW_CLIENT_ORDER_1");
        });

        modelBuilder.Entity<RptVwClientOrderSummary>(entity =>
        {
            entity.ToView("RPT_VW_CLIENT_ORDER_SUMMARY");
        });

        modelBuilder.Entity<RptVwClientOrderSummary1>(entity =>
        {
            entity.ToView("RPT_VW_CLIENT_ORDER_SUMMARY_1");
        });

        modelBuilder.Entity<RptVwDailyOrderStatusEmp>(entity =>
        {
            entity.ToView("RPT_VW_DAILY_ORDER_STATUS_EMP");
        });

        modelBuilder.Entity<RptVwDailyOrderStatusEmp1>(entity =>
        {
            entity.ToView("RPT_VW_DAILY_ORDER_STATUS_EMP_1");
        });

        modelBuilder.Entity<RptVwEmpOrganisationDetail>(entity =>
        {
            entity.ToView("RPT_VW_EMP_ORGANISATION_DETAIL");
        });

        modelBuilder.Entity<RptVwEmpPendingOrder>(entity =>
        {
            entity.ToView("RPT_VW_EMP_PENDING_ORDERS");
        });

        modelBuilder.Entity<RptVwEmpPendingOrders1>(entity =>
        {
            entity.ToView("RPT_VW_EMP_PENDING_ORDERS_1");
        });

        modelBuilder.Entity<RptVwEmployeeAbsentee>(entity =>
        {
            entity.ToView("RPT_VW_EMPLOYEE_ABSENTEES");
        });

        modelBuilder.Entity<RptVwEmployeeAttendance>(entity =>
        {
            entity.ToView("RPT_VW_EMPLOYEE_ATTENDANCE");
        });

        modelBuilder.Entity<RptVwEmployeeDetail>(entity =>
        {
            entity.ToView("RPT_VW_EMPLOYEE_DETAILS");
        });

        modelBuilder.Entity<RptVwEmployeePersonalDetailL>(entity =>
        {
            entity.ToView("RPT_VW_EMPLOYEE_PERSONAL_DETAIlL");
        });

        modelBuilder.Entity<RptVwEmployeeReport>(entity =>
        {
            entity.ToView("RPT_VW_EMPLOYEE_REPORT");
        });

        modelBuilder.Entity<RptVwEmployeelist>(entity =>
        {
            entity.ToView("RPT_VW_EMPLOYEELIST");
        });

        modelBuilder.Entity<RptVwEmploymentDetail>(entity =>
        {
            entity.ToView("RPT_VW_EMPLOYMENT_DETAILS");
        });

        modelBuilder.Entity<RptVwGstDetail>(entity =>
        {
            entity.ToView("RPT_VW_GST_DETAILS");
        });

        modelBuilder.Entity<RptVwInvoiceReport>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT");
        });

        modelBuilder.Entity<RptVwInvoiceReport1>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT_1");
        });

        modelBuilder.Entity<RptVwInvoiceReportAmt>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT_AMT");
        });

        modelBuilder.Entity<RptVwInvoiceReportAmt1>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT_AMT_1");
        });

        modelBuilder.Entity<RptVwInvoiceReportAmtInv>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT_AMT_INV");
        });

        modelBuilder.Entity<RptVwInvoiceReportInv>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT_INV");
        });

        modelBuilder.Entity<RptVwInvoiceReportOld>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT_old");
        });

        modelBuilder.Entity<RptVwInvoiceReportWorking>(entity =>
        {
            entity.ToView("RPT_VW_INVOICE_REPORT_working");
        });

        modelBuilder.Entity<RptVwLeaveReport>(entity =>
        {
            entity.ToView("RPT_VW_LEAVE_REPORT");
        });

        modelBuilder.Entity<RptVwPicWaiting>(entity =>
        {
            entity.ToView("RPT_VW_PIC_WAITING");
        });

        modelBuilder.Entity<RptVwPicWaiting1>(entity =>
        {
            entity.ToView("RPT_VW_PIC_WAITING_1");
        });

        modelBuilder.Entity<RptVwSelectemployee>(entity =>
        {
            entity.ToView("RPT_VW_SELECTEMPLOYEE");
        });

        modelBuilder.Entity<SalaryTypeRef>(entity =>
        {
            entity.ToTable("SALARY_TYPE_REF", tb => tb.HasTrigger("gs_trigChkIsDefaultSalaryTypeMaster"));
        });

        modelBuilder.Entity<SessionManagement>(entity =>
        {
            entity.Property(e => e.Sessionid).ValueGeneratedNever();
        });

        modelBuilder.Entity<SiteMasterView>(entity =>
        {
            entity.ToView("SITE_MASTER_VIEW");
        });

        modelBuilder.Entity<SiteValue>(entity =>
        {
            entity.Property(e => e.SiteRefNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SiteValuesWorking>(entity =>
        {
            entity.Property(e => e.SiteRefNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SlTbAreaMaster>(entity =>
        {
            entity.HasKey(e => e.AmAreaId).HasName("PK_M307_SL_TB_AREA_MASTER");
        });

        modelBuilder.Entity<SlTbAreaValue>(entity =>
        {
            entity.HasOne(d => d.AmArea).WithMany(p => p.SlTbAreaValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SL_TB_AREA_VALUES_SL_TB_AREA_MASTER");
        });

        modelBuilder.Entity<SlTbContactMaster>(entity =>
        {
            entity.HasKey(e => e.CmContactId).HasName("PK_M306_SL_TB_CONTACT_MASTER1");
        });

        modelBuilder.Entity<SlTbCustomerMaster>(entity =>
        {
            entity.HasKey(e => e.CmCustomerId).HasName("PK_M301_SL_TB_CUSTOMER_MASTER");

            entity.Property(e => e.CmLcNo).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<SlTbDistrictMaster>(entity =>
        {
            entity.HasKey(e => e.DmDistrictId).HasName("PK_M307_SL_TB_DISTRICT_MASTER");
        });

        modelBuilder.Entity<SlTbDistrictValue>(entity =>
        {
            entity.HasOne(d => d.DmDistrict).WithMany(p => p.SlTbDistrictValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SL_TB_DISTRICT_VALUES_SL_TB_DISTRICT_MASTER");
        });

        modelBuilder.Entity<SlTbEmirateMaster>(entity =>
        {
            entity.HasKey(e => e.EmEmirateId).HasName("PK_M307_SL_TB__EMIRATE_MASTER");
        });

        modelBuilder.Entity<SlTbEmirateValue>(entity =>
        {
            entity.HasOne(d => d.EmEmirate).WithMany(p => p.SlTbEmirateValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SL_TB_EMIRATE_VALUES_SL_TB_EMIRATE_MASTER");
        });

        modelBuilder.Entity<SlTbInvoiceAmount>(entity =>
        {
            entity.Property(e => e.IamtId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SlTbInvoiceAmount1>(entity =>
        {
            entity.Property(e => e.IamtId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SlTbInvoiceDetaile>(entity =>
        {
            entity.Property(e => e.IdetId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SlTbInvoiceDetailes1>(entity =>
        {
            entity.Property(e => e.IdetId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SlTbInvoiceMaster>(entity =>
        {
            entity.Property(e => e.InvId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SlTbInvoiceMaster1>(entity =>
        {
            entity.Property(e => e.InvId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SlTbLocationMaster>(entity =>
        {
            entity.ToTable("SL_TB_LOCATION_MASTER", tb => tb.HasTrigger("gs_trigChkIsDefaultOnLocationMaster"));
        });

        modelBuilder.Entity<SlTbStationMaster>(entity =>
        {
            entity.HasKey(e => new { e.SmStationId, e.LanguageCode }).HasName("PK_SL_TB_STATION_MASTER_1");

            entity.ToTable("SL_TB_STATION_MASTER", tb => tb.HasTrigger("gs_trigChkIsDefaultOnStationMaster"));
        });

        modelBuilder.Entity<SlTbVwMarketMaster>(entity =>
        {
            entity.ToView("SL_TB_VW_Market_Master");
        });

        modelBuilder.Entity<SlVwAreaMaster>(entity =>
        {
            entity.ToView("SL_VW_AreaMaster");
        });

        modelBuilder.Entity<SlVwBindCountry>(entity =>
        {
            entity.ToView("SL_VW_BindCountry");
        });

        modelBuilder.Entity<SlVwClientGroupMap>(entity =>
        {
            entity.ToView("SL_VW_CLIENT_GROUP_MAP");
        });

        modelBuilder.Entity<SlVwClientGroupMap1>(entity =>
        {
            entity.ToView("SL_VW_CLIENT_GROUP_MAP_1");
        });

        modelBuilder.Entity<SlVwClientMailInfo>(entity =>
        {
            entity.ToView("SL_VW_CLIENT_MAIL_INFO");
        });

        modelBuilder.Entity<SlVwClientMailInfo1>(entity =>
        {
            entity.ToView("SL_VW_CLIENT_MAIL_INFO_1");
        });

        modelBuilder.Entity<SlVwCountryMaster>(entity =>
        {
            entity.ToView("SL_VW_CountryMaster");
        });

        modelBuilder.Entity<SlVwLanguageMaster>(entity =>
        {
            entity.ToView("SL_VW_LANGUAGE_MASTER");
        });

        modelBuilder.Entity<SlVwMlsSiteValue>(entity =>
        {
            entity.ToView("SL_VW_MLS_SITE_VALUES");
        });

        modelBuilder.Entity<SlVwRegionMaster>(entity =>
        {
            entity.ToView("SL_VW_RegionMaster");
        });

        modelBuilder.Entity<SlVwSiteMlsDetail>(entity =>
        {
            entity.ToView("SL_VW_SITE_MLS_DETAILS");
        });

        modelBuilder.Entity<SlVwStation>(entity =>
        {
            entity.ToView("SL_VW_STATION");
        });

        modelBuilder.Entity<StatusReasonRef>(entity =>
        {
            entity.Property(e => e.StatusReasonId).ValueGeneratedNever();
        });

        modelBuilder.Entity<StatusRef>(entity =>
        {
            entity.Property(e => e.StatusId).ValueGeneratedNever();
        });

        modelBuilder.Entity<StatusUserFilter>(entity =>
        {
            entity.ToView("STATUS_USER_FILTER");
        });

        modelBuilder.Entity<StyleProperty>(entity =>
        {
            entity.HasKey(e => e.StylePropertyId).HasName("PK_StyleProperties");
        });

        modelBuilder.Entity<SubModuleValue>(entity =>
        {
            entity.HasOne(d => d.SubModule).WithMany(p => p.SubModuleValues).HasConstraintName("FK_SUB_MODULE_VALUES_SUB_MODULES_REF");
        });

        modelBuilder.Entity<SubModulesRef>(entity =>
        {
            entity.Property(e => e.SubModuleId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TfsTbAccountsUserMaster>(entity =>
        {
            entity.Property(e => e.RefNo).ValueGeneratedOnAdd();
            entity.Property(e => e.Username).IsFixedLength();
        });

        modelBuilder.Entity<TfsTbAutoBpoBed>(entity =>
        {
            entity.Property(e => e.Bath).HasDefaultValueSql("((0))");
            entity.Property(e => e.Bed).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Gla).HasDefaultValueSql("((0))");
            entity.Property(e => e.LotSize).HasDefaultValueSql("((0))");
            entity.Property(e => e.PriorValue).HasDefaultValueSql("((0))");
            entity.Property(e => e.PurchasePrice).HasDefaultValueSql("((0))");
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
            entity.Property(e => e.YearBuilt).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<TfsTbAutoBpoClientMap>(entity =>
        {
            entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsTbAutoBpoOrderHistory>(entity =>
        {
            entity.Property(e => e.UpdatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TfsTbAutoBpoZipcode>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK_TFS_TB_AUTO_BPO_ZIPCODES1");

            entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<TfsTbAutoBpoZipcodes1>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK_TFS_TB_AUTO_BPO_ZIPCODES");
        });

        modelBuilder.Entity<TfsTbEmployeeJoiningDate>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsTbGroupMap>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsTbGroupMap1>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsTbGroupMaster>(entity =>
        {
            entity.Property(e => e.IsEnable).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TfsTbIgnoredOrder>(entity =>
        {
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsTbModule>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK_TFS_TB_MODULES12");
        });

        modelBuilder.Entity<TfsTbModules1>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK_TFS_TB_MODULES");
        });

        modelBuilder.Entity<TfsTbOrderUserFilter>(entity =>
        {
            entity.Property(e => e.AutoBpoStatusId).HasDefaultValueSql("((0))");
            entity.Property(e => e.DeleteStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.FilterId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsTbRoleMaster>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_TFS_TB_ROLE_MASTER_1");
        });

        modelBuilder.Entity<TfsTbRoleMaster1>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_TFS_TB_ROLE_MASTER");
        });

        modelBuilder.Entity<TfsTbRolePermission>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK_TFS_TB_ROLE_PERMISSION12");
        });

        modelBuilder.Entity<TfsTbRolePermission1>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK_TFS_TB_ROLE_PERMISSION1");
        });

        modelBuilder.Entity<TfsTbRptEmpAbsenteesTemp>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__TFS_TB_R__7E16F9500DD09EEF");
        });

        modelBuilder.Entity<TfsTbRptEmpwiseTrackingTemp>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__TFS_TB_R__7E16F9507A653EF5");
        });

        modelBuilder.Entity<TfsTbRptIncentiveTemp>(entity =>
        {
            entity.HasKey(e => e.SlNo).HasName("PK__TFS_TB_R__7E16F9502F1BB8CA");
        });

        modelBuilder.Entity<TfsTbUserMaster>(entity =>
        {
            entity.Property(e => e.ActiveDate).HasComment("This is the active date");
        });

        modelBuilder.Entity<TfsUserLoginLog>(entity =>
        {
            entity.Property(e => e.EmpId).IsFixedLength();
            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsVwAssignedCountClient>(entity =>
        {
            entity.ToView("TFS_VW_ASSIGNED_COUNT_CLIENT");
        });

        modelBuilder.Entity<TfsVwAssignedCountClient1>(entity =>
        {
            entity.ToView("TFS_VW_ASSIGNED_COUNT_CLIENT_1");
        });

        modelBuilder.Entity<TfsVwAutoBpoClientMap>(entity =>
        {
            entity.ToView("TFS_VW_AUTO_BPO_CLIENT_MAP");
        });

        modelBuilder.Entity<TfsVwAutoBpoHistory>(entity =>
        {
            entity.ToView("TFS_VW_AUTO_BPO_HISTORY");
        });

        modelBuilder.Entity<TfsVwAutoBpoOrder>(entity =>
        {
            entity.ToView("TFS_VW_AUTO_BPO_ORDERS");
        });

        modelBuilder.Entity<TfsVwClientDashboard>(entity =>
        {
            entity.ToView("TFS_VW_CLIENT_DASHBOARD");
        });

        modelBuilder.Entity<TfsVwEmpUserList>(entity =>
        {
            entity.ToView("TFS_VW_EMP_USER_LIST");
        });

        modelBuilder.Entity<TfsVwEmpUserListBefBug>(entity =>
        {
            entity.ToView("TFS_VW_EMP_USER_LIST_bef_bug");
        });

        modelBuilder.Entity<TfsVwEmpUserListEncodedUserMaster>(entity =>
        {
            entity.ToView("TFS_VW_EMP_USER_LIST_encoded_userMaster");
        });

        modelBuilder.Entity<TfsVwEmployeeAssignedWork>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_ASSIGNED_WORKS");
        });

        modelBuilder.Entity<TfsVwEmployeeAssignedWorks1>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_ASSIGNED_WORKS_1");
        });

        modelBuilder.Entity<TfsVwEmployeeAssignedWorks2>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_ASSIGNED_WORKS_2");
        });

        modelBuilder.Entity<TfsVwEmployeeAttendanceGroup>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_ATTENDANCE_GROUP");
        });

        modelBuilder.Entity<TfsVwEmployeeAttendanceGroup1>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_ATTENDANCE_GROUP_1");
        });

        modelBuilder.Entity<TfsVwEmployeeAttendanceGroupCrct>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_ATTENDANCE_GROUP_CRCT");
        });

        modelBuilder.Entity<TfsVwEmployeeDetail>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_DETAILS");
        });

        modelBuilder.Entity<TfsVwEmployeeDetailsEncodedUserMaster>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEE_DETAILS_encoded_userMaster");
        });

        modelBuilder.Entity<TfsVwEmployeelist>(entity =>
        {
            entity.ToView("TFS_VW_EMPLOYEELIST");
        });

        modelBuilder.Entity<TfsVwInvoiceAmountDetail>(entity =>
        {
            entity.ToView("TFS_VW_INVOICE_AMOUNT_DETAILS");
        });

        modelBuilder.Entity<TfsVwMlsZipGroupMap>(entity =>
        {
            entity.ToView("TFS_VW_MLS_ZIP_GROUP_MAP");
        });

        modelBuilder.Entity<TfsVwRoleListDatum>(entity =>
        {
            entity.ToView("TFS_VW_ROLE_LIST_DATA");

            entity.Property(e => e.SlNo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TfsVwUnassignedOrder>(entity =>
        {
            entity.ToView("TFS_VW_UNASSIGNED_ORDERS");
        });

        modelBuilder.Entity<TfsVwUserMenu>(entity =>
        {
            entity.ToView("TFS_VW_USER_MENU");
        });

        modelBuilder.Entity<TlSelectCountry>(entity =>
        {
            entity.ToView("TL_SelectCountry");
        });

        modelBuilder.Entity<TlVwSelectAreaList>(entity =>
        {
            entity.ToView("TL_VW_SelectAreaList");
        });

        modelBuilder.Entity<TlVwSelectMarketList>(entity =>
        {
            entity.ToView("TL_VW_SelectMarketList");
        });

        modelBuilder.Entity<TlVwSelectRegionList>(entity =>
        {
            entity.ToView("TL_VW_SelectRegionList");
        });

        modelBuilder.Entity<UserMaster>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_01_USER_MASTER");
        });

        modelBuilder.Entity<VwChkFieldReference>(entity =>
        {
            entity.ToView("VW_ChkFieldReference");
        });

        modelBuilder.Entity<VwClientDuePendingDetail>(entity =>
        {
            entity.ToView("VW_CLIENT_DUE_PENDING_DETAILS");
        });

        modelBuilder.Entity<VwDefDept>(entity =>
        {
            entity.ToView("VW_Def_Dept");
        });

        modelBuilder.Entity<VwEmployeeSite>(entity =>
        {
            entity.ToView("VW_EMPLOYEE_SITE");
        });

        modelBuilder.Entity<VwEmployeeSite1>(entity =>
        {
            entity.ToView("VW_EMPLOYEE_SITE_1");
        });

        modelBuilder.Entity<VwInvoiceGenOrderList>(entity =>
        {
            entity.ToView("VW_INVOICE_GEN_ORDER_LIST");
        });

        modelBuilder.Entity<VwInvoiceGenOrderListOld>(entity =>
        {
            entity.ToView("VW_INVOICE_GEN_ORDER_LIST_old");
        });

        modelBuilder.Entity<VwInvoiceList>(entity =>
        {
            entity.ToView("VW_INVOICE_LIST");
        });

        modelBuilder.Entity<VwInvoiceList1>(entity =>
        {
            entity.ToView("VW_INVOICE_LIST_1");
        });

        modelBuilder.Entity<VwInvoiceListBefSendMail>(entity =>
        {
            entity.ToView("VW_INVOICE_LIST_bef_send_mail");
        });

        modelBuilder.Entity<VwSiteUserCredential>(entity =>
        {
            entity.ToView("VW_SITE_USER_CREDENTIALS");
        });

        modelBuilder.Entity<VwSubmissionCount>(entity =>
        {
            entity.ToView("VW_Submission_Count");
        });

        modelBuilder.Entity<VwSubmissionCountSchedule>(entity =>
        {
            entity.ToView("VW_Submission_Count_schedule");
        });

        modelBuilder.Entity<WsAssettypeRef>(entity =>
        {
            entity.ToTable("WS_ASSETTYPE_REF", tb => tb.HasTrigger("gs_trigChkIsDefaultOnAssetTypeMaster"));
        });

        modelBuilder.Entity<WsVwLeavelist>(entity =>
        {
            entity.ToView("WS_VW_LEAVELIST");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
