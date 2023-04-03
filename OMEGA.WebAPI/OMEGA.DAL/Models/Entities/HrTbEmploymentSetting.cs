using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMEGA.DAL.Models.Entities;

[Table("HR_TB_EMPLOYMENT_SETTINGS")]
public partial class HrTbEmploymentSetting
{
    [Key]
    [Column("empt_set_ref_no")]
    public int EmptSetRefNo { get; set; }

    [Column("empt_org_id")]
    public int? EmptOrgId { get; set; }

    [Column("empt_comp_id")]
    public int? EmptCompId { get; set; }

    [Column("empt_dept_id")]
    public int? EmptDeptId { get; set; }

    [Column("overtime_payment_entitlement")]
    public byte? OvertimePaymentEntitlement { get; set; }

    [Column("entitled_holiday_pay")]
    public byte? EntitledHolidayPay { get; set; }

    [Column("entitled_holiday_pay_remarks")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EntitledHolidayPayRemarks { get; set; }

    [Column("entitled_annual_leave")]
    public int? EntitledAnnualLeave { get; set; }

    [Column("entitled_medical_leave")]
    public int? EntitledMedicalLeave { get; set; }

    [Column("entitled_hospitalization_leave")]
    public int? EntitledHospitalizationLeave { get; set; }

    [Column("entitled_off_in_lieu")]
    public int? EntitledOffInLieu { get; set; }

    [Column("entitled_carry_fwd_leave_days")]
    public int? EntitledCarryFwdLeaveDays { get; set; }

    [Column("is_entitled_leave_encashment")]
    public byte? IsEntitledLeaveEncashment { get; set; }

    [Column("is_leave_encash_on_cessation")]
    public byte? IsLeaveEncashOnCessation { get; set; }

    [Column("is_entitled_medical_benefit")]
    public byte? IsEntitledMedicalBenefit { get; set; }

    [Column("is_entitled_dental_benefit")]
    public byte? IsEntitledDentalBenefit { get; set; }

    [Column("medical_benefit_amount", TypeName = "numeric(18, 3)")]
    public decimal? MedicalBenefitAmount { get; set; }

    [Column("is_entitled_bonus1")]
    public byte? IsEntitledBonus1 { get; set; }

    [Column("bonus_type1")]
    public int? BonusType1 { get; set; }

    [Column("bonus_month1")]
    public int? BonusMonth1 { get; set; }

    [Column("bonus_amount1", TypeName = "numeric(18, 3)")]
    public decimal? BonusAmount1 { get; set; }

    [Column("is_entitled_bonus2")]
    public byte? IsEntitledBonus2 { get; set; }

    [Column("bonus_type2")]
    public int? BonusType2 { get; set; }

    [Column("bonus_month2")]
    public int? BonusMonth2 { get; set; }

    [Column("bonus_amount2", TypeName = "numeric(18, 3)")]
    public decimal? BonusAmount2 { get; set; }

    [Column("is_entitled_bonus3")]
    public byte? IsEntitledBonus3 { get; set; }

    [Column("bonus_type3")]
    public int? BonusType3 { get; set; }

    [Column("bonus_month3")]
    public int? BonusMonth3 { get; set; }

    [Column("bonus_amount3", TypeName = "numeric(18, 3)")]
    public decimal? BonusAmount3 { get; set; }

    [Column("is_entitled_bonus4")]
    public byte? IsEntitledBonus4 { get; set; }

    [Column("bonus_type4")]
    public int? BonusType4 { get; set; }

    [Column("bonus_month4")]
    public int? BonusMonth4 { get; set; }

    [Column("bonus_amount4", TypeName = "numeric(18, 3)")]
    public decimal? BonusAmount4 { get; set; }

    [Column("bonus_remarks")]
    [StringLength(500)]
    [Unicode(false)]
    public string? BonusRemarks { get; set; }

    [Column("is_entitled_insurance")]
    public byte? IsEntitledInsurance { get; set; }

    [Column("insurance_type1")]
    public int? InsuranceType1 { get; set; }

    [Column("insurance_type2")]
    public int? InsuranceType2 { get; set; }

    [Column("insurance_amount", TypeName = "numeric(18, 3)")]
    public decimal? InsuranceAmount { get; set; }

    [Column("empmt_payday_cycle")]
    [StringLength(18)]
    [Unicode(false)]
    public string? EmpmtPaydayCycle { get; set; }

    [Column("empmt_payday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtPayday { get; set; }

    [Column("empmt_monday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtMonday { get; set; }

    [Column("empmt_tuesday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtTuesday { get; set; }

    [Column("empmt_wednesday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtWednesday { get; set; }

    [Column("empmt_thursday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtThursday { get; set; }

    [Column("empmt_friday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtFriday { get; set; }

    [Column("empmt_saturday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtSaturday { get; set; }

    [Column("empmt_sunday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtSunday { get; set; }

    [Column("empmt_holiday", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtHoliday { get; set; }

    [Column("empmt_weekly_working_days", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtWeeklyWorkingDays { get; set; }

    [Column("empmt_monday_start_time")]
    public TimeSpan? EmpmtMondayStartTime { get; set; }

    [Column("empmt_monday_end_time")]
    public TimeSpan? EmpmtMondayEndTime { get; set; }

    [Column("empmt_tuesday_start_time")]
    public TimeSpan? EmpmtTuesdayStartTime { get; set; }

    [Column("empmt_tuesday_end_time")]
    public TimeSpan? EmpmtTuesdayEndTime { get; set; }

    [Column("empmt_wednesday_start_time")]
    public TimeSpan? EmpmtWednesdayStartTime { get; set; }

    [Column("empmt_wednesday_end_time")]
    public TimeSpan? EmpmtWednesdayEndTime { get; set; }

    [Column("empmt_thursday_start_time")]
    public TimeSpan? EmpmtThursdayStartTime { get; set; }

    [Column("empmt_thursday_end_time")]
    public TimeSpan? EmpmtThursdayEndTime { get; set; }

    [Column("empmt_friday_start_time")]
    public TimeSpan? EmpmtFridayStartTime { get; set; }

    [Column("empmt_friday_end_time")]
    public TimeSpan? EmpmtFridayEndTime { get; set; }

    [Column("empmt_saturday_start_time")]
    public TimeSpan? EmpmtSaturdayStartTime { get; set; }

    [Column("empmt_saturday_end_time")]
    public TimeSpan? EmpmtSaturdayEndTime { get; set; }

    [Column("empmt_sunday_start_time")]
    public TimeSpan? EmpmtSundayStartTime { get; set; }

    [Column("empmt_sunday_end_time")]
    public TimeSpan? EmpmtSundayEndTime { get; set; }

    [Column("empmt_alter_saturday")]
    public int? EmpmtAlterSaturday { get; set; }

    [Column("empmt_alter_sunday")]
    public int? EmpmtAlterSunday { get; set; }

    [Column("empmt_time_sections")]
    public int? EmpmtTimeSections { get; set; }

    [Column("empmt_break1_start_time")]
    public TimeSpan? EmpmtBreak1StartTime { get; set; }

    [Column("empmt_break1_duration")]
    public int? EmpmtBreak1Duration { get; set; }

    [Column("empmt_break2_start_time")]
    public TimeSpan? EmpmtBreak2StartTime { get; set; }

    [Column("empmt_break2_duration")]
    public int? EmpmtBreak2Duration { get; set; }

    [Column("empmt_flexible_working_days")]
    public byte? EmpmtFlexibleWorkingDays { get; set; }

    [Column("empmt_flexible_overtime")]
    public byte? EmpmtFlexibleOvertime { get; set; }

    [Column("empmt_is_entitled_overtime")]
    public byte? EmpmtIsEntitledOvertime { get; set; }

    [Column("empmt_is_weekly_overtime")]
    public byte? EmpmtIsWeeklyOvertime { get; set; }

    [Column("empmt_is_flat_rate_overtime")]
    public byte? EmpmtIsFlatRateOvertime { get; set; }

    [Column("empmt_is_flexible_working_hours")]
    public byte? EmpmtIsFlexibleWorkingHours { get; set; }

    [Column("empmt_monday_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtMondayWorkingHours { get; set; }

    [Column("empmt_tuesday_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtTuesdayWorkingHours { get; set; }

    [Column("empmt_wednesday_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtWednesdayWorkingHours { get; set; }

    [Column("empmt_thursday_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtThursdayWorkingHours { get; set; }

    [Column("empmt_friday_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtFridayWorkingHours { get; set; }

    [Column("empmt_saturday_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtSaturdayWorkingHours { get; set; }

    [Column("empmt_sunday_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtSundayWorkingHours { get; set; }

    [Column("empmt_daily_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtDailyWorkingHours { get; set; }

    [Column("empmt_weekly_working_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtWeeklyWorkingHours { get; set; }

    [Column("empmt_weekly_overtime_hours", TypeName = "numeric(18, 2)")]
    public decimal? EmpmtWeeklyOvertimeHours { get; set; }

    [Column("empmt_offday_indayofweek")]
    public byte? EmpmtOffdayIndayofweek { get; set; }

    [Column("empmt_restday_indayofweek")]
    public byte? EmpmtRestdayIndayofweek { get; set; }

    [Column("empmt_monday_overtime_rate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtMondayOvertimeRate { get; set; }

    [Column("empmt_tuesday_overtime_rate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtTuesdayOvertimeRate { get; set; }

    [Column("empmt_wednesday_overtimerate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtWednesdayOvertimerate { get; set; }

    [Column("empmt_thursday_overtimerate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtThursdayOvertimerate { get; set; }

    [Column("empmt_friday_overtime_rate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtFridayOvertimeRate { get; set; }

    [Column("empmt_saturday_overtime_rate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtSaturdayOvertimeRate { get; set; }

    [Column("empmt_sunday_overtime_rate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtSundayOvertimeRate { get; set; }

    [Column("empmt_holiday_overtime_rate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtHolidayOvertimeRate { get; set; }

    [Column("empmt_holiday_exceed_overtime_rate", TypeName = "numeric(18, 3)")]
    public decimal? EmpmtHolidayExceedOvertimeRate { get; set; }

    [Column("employed_by")]
    public int? EmployedBy { get; set; }

    [Column("placement_fee")]
    public byte? PlacementFee { get; set; }

    [Column("placement_fee_option")]
    public byte? PlacementFeeOption { get; set; }

    [Column("placement_fee_amount", TypeName = "numeric(18, 3)")]
    public decimal? PlacementFeeAmount { get; set; }

    [Column("placement_fee_remarks")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PlacementFeeRemarks { get; set; }

    [Column("is_wica")]
    public byte? IsWica { get; set; }

    [Column("wica_percentage", TypeName = "numeric(18, 3)")]
    public decimal? WicaPercentage { get; set; }

    [Column("wica_remarks")]
    [StringLength(500)]
    [Unicode(false)]
    public string? WicaRemarks { get; set; }

    [Column("is_sdl")]
    public byte? IsSdl { get; set; }

    [Column("sdl_percentage", TypeName = "numeric(18, 3)")]
    public decimal? SdlPercentage { get; set; }

    [Column("sdl_remarks")]
    [StringLength(500)]
    [Unicode(false)]
    public string? SdlRemarks { get; set; }

    [Column("is_fwf")]
    public byte? IsFwf { get; set; }

    [Column("fwf_amount", TypeName = "numeric(18, 3)")]
    public decimal? FwfAmount { get; set; }

    [Column("fwf_remarks")]
    [StringLength(500)]
    [Unicode(false)]
    public string? FwfRemarks { get; set; }

    [Column("is_enable_fee_percent1")]
    public byte? IsEnableFeePercent1 { get; set; }

    [Column("fee_percent_condition1")]
    [StringLength(60)]
    [Unicode(false)]
    public string? FeePercentCondition1 { get; set; }

    [Column("fee_percent1", TypeName = "numeric(18, 3)")]
    public decimal? FeePercent1 { get; set; }

    [Column("fee_percent_variable1", TypeName = "numeric(18, 3)")]
    public decimal? FeePercentVariable1 { get; set; }

    [Column("is_enable_fee_percent2")]
    public byte? IsEnableFeePercent2 { get; set; }

    [Column("fee_percent_condition2")]
    [StringLength(60)]
    [Unicode(false)]
    public string? FeePercentCondition2 { get; set; }

    [Column("fee_percent2", TypeName = "numeric(18, 3)")]
    public decimal? FeePercent2 { get; set; }

    [Column("fee_percent_variable2", TypeName = "numeric(18, 3)")]
    public decimal? FeePercentVariable2 { get; set; }

    [Column("is_enable_fee_percent3")]
    public byte? IsEnableFeePercent3 { get; set; }

    [Column("fee_percent_condition3")]
    [StringLength(60)]
    [Unicode(false)]
    public string? FeePercentCondition3 { get; set; }

    [Column("fee_percent3", TypeName = "numeric(18, 3)")]
    public decimal? FeePercent3 { get; set; }

    [Column("fee_percent_variable3", TypeName = "numeric(18, 3)")]
    public decimal? FeePercentVariable3 { get; set; }

    [Column("is_enable_fee_amount1")]
    public byte? IsEnableFeeAmount1 { get; set; }

    [Column("fee_amount_condition1")]
    [StringLength(60)]
    [Unicode(false)]
    public string? FeeAmountCondition1 { get; set; }

    [Column("fee_amount1", TypeName = "numeric(18, 3)")]
    public decimal? FeeAmount1 { get; set; }

    [Column("is_enable_fee_amount2")]
    public byte? IsEnableFeeAmount2 { get; set; }

    [Column("fee_amount_condition2")]
    [StringLength(60)]
    [Unicode(false)]
    public string? FeeAmountCondition2 { get; set; }

    [Column("fee_amount2", TypeName = "numeric(18, 3)")]
    public decimal? FeeAmount2 { get; set; }

    [Column("is_enable_fee_amount3")]
    public byte? IsEnableFeeAmount3 { get; set; }

    [Column("fee_amount_condition3")]
    [StringLength(60)]
    [Unicode(false)]
    public string? FeeAmountCondition3 { get; set; }

    [Column("fee_amount3", TypeName = "numeric(18, 3)")]
    public decimal? FeeAmount3 { get; set; }

    [Column("is_enable_service_model")]
    public byte? IsEnableServiceModel { get; set; }

    [Column("service_model_amount", TypeName = "numeric(18, 3)")]
    public decimal? ServiceModelAmount { get; set; }

    [Column("service_model_description")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ServiceModelDescription { get; set; }

    [Column("last_modifie_ddatetime", TypeName = "datetime")]
    public DateTime? LastModifieDdatetime { get; set; }

    [Column("last_modified_by")]
    public int? LastModifiedBy { get; set; }

    [Column("bonus_calc_type")]
    public int? BonusCalcType { get; set; }

    [Column("bonus_ispaid_endof_contract_dt")]
    public int? BonusIspaidEndofContractDt { get; set; }

    [Column("empt_shift_desc")]
    [StringLength(250)]
    public string? EmptShiftDesc { get; set; }
}
