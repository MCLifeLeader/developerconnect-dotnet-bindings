/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.4.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractFhaVaLoanEem
    /// </summary>
    [DataContract]
    public partial class LoanContractFhaVaLoanEem :  IEquatable<LoanContractFhaVaLoanEem>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AppraisedValue
        /// </summary>
        [DataMember(Name="appraisedValue", EmitDefaultValue=false)]
        public double? AppraisedValue { get; set; }

        /// <summary>
        /// Gets or Sets AuditCost
        /// </summary>
        [DataMember(Name="auditCost", EmitDefaultValue=false)]
        public double? AuditCost { get; set; }

        /// <summary>
        /// Gets or Sets BackRatio
        /// </summary>
        [DataMember(Name="backRatio", EmitDefaultValue=false)]
        public double? BackRatio { get; set; }

        /// <summary>
        /// Gets or Sets BaseLoanAmtFromTsum
        /// </summary>
        [DataMember(Name="baseLoanAmtFromTsum", EmitDefaultValue=false)]
        public double? BaseLoanAmtFromTsum { get; set; }

        /// <summary>
        /// Gets or Sets CostEffectiveEnergyPackage
        /// </summary>
        [DataMember(Name="costEffectiveEnergyPackage", EmitDefaultValue=false)]
        public double? CostEffectiveEnergyPackage { get; set; }

        /// <summary>
        /// Gets or Sets EeCostMaximumAmount
        /// </summary>
        [DataMember(Name="eeCostMaximumAmount", EmitDefaultValue=false)]
        public double? EeCostMaximumAmount { get; set; }

        /// <summary>
        /// Gets or Sets EeImprovementsInstalledCost
        /// </summary>
        [DataMember(Name="eeImprovementsInstalledCost", EmitDefaultValue=false)]
        public double? EeImprovementsInstalledCost { get; set; }

        /// <summary>
        /// Gets or Sets EnergyCost
        /// </summary>
        [DataMember(Name="energyCost", EmitDefaultValue=false)]
        public double? EnergyCost { get; set; }

        /// <summary>
        /// Gets or Sets EnergySavings
        /// </summary>
        [DataMember(Name="energySavings", EmitDefaultValue=false)]
        public double? EnergySavings { get; set; }

        /// <summary>
        /// Gets or Sets Hoa
        /// </summary>
        [DataMember(Name="hoa", EmitDefaultValue=false)]
        public double? Hoa { get; set; }

        /// <summary>
        /// Gets or Sets ImprovementCostExceed2000
        /// </summary>
        [DataMember(Name="improvementCostExceed2000", EmitDefaultValue=false)]
        public double? ImprovementCostExceed2000 { get; set; }

        /// <summary>
        /// Gets or Sets InspectionCost
        /// </summary>
        [DataMember(Name="inspectionCost", EmitDefaultValue=false)]
        public double? InspectionCost { get; set; }

        /// <summary>
        /// Gets or Sets LesserC1ORC2
        /// </summary>
        [DataMember(Name="lesserC1ORC2", EmitDefaultValue=false)]
        public double? LesserC1ORC2 { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyHousingPayment
        /// </summary>
        [DataMember(Name="monthlyHousingPayment", EmitDefaultValue=false)]
        public double? MonthlyHousingPayment { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyMI
        /// </summary>
        [DataMember(Name="monthlyMI", EmitDefaultValue=false)]
        public double? MonthlyMI { get; set; }

        /// <summary>
        /// Gets or Sets MortgageAmountUsedForQualifyingRate
        /// </summary>
        [DataMember(Name="mortgageAmountUsedForQualifyingRate", EmitDefaultValue=false)]
        public double? MortgageAmountUsedForQualifyingRate { get; set; }

        /// <summary>
        /// Gets or Sets MortgageAmountUsedForQualifyingRateD1
        /// </summary>
        [DataMember(Name="mortgageAmountUsedForQualifyingRateD1", EmitDefaultValue=false)]
        public double? MortgageAmountUsedForQualifyingRateD1 { get; set; }

        /// <summary>
        /// Gets or Sets NewOrExisting
        /// </summary>
        [DataMember(Name="newOrExisting", EmitDefaultValue=false)]
        public bool? NewOrExisting { get; set; }

        /// <summary>
        /// Gets or Sets OriginalSalesPriceIfLess12Months
        /// </summary>
        [DataMember(Name="originalSalesPriceIfLess12Months", EmitDefaultValue=false)]
        public double? OriginalSalesPriceIfLess12Months { get; set; }

        /// <summary>
        /// Gets or Sets OtherHousingPayment
        /// </summary>
        [DataMember(Name="otherHousingPayment", EmitDefaultValue=false)]
        public double? OtherHousingPayment { get; set; }

        /// <summary>
        /// Gets or Sets SolarNotIncluded
        /// </summary>
        [DataMember(Name="solarNotIncluded", EmitDefaultValue=false)]
        public double? SolarNotIncluded { get; set; }

        /// <summary>
        /// Gets or Sets SolarSystemCostAllowance
        /// </summary>
        [DataMember(Name="solarSystemCostAllowance", EmitDefaultValue=false)]
        public double? SolarSystemCostAllowance { get; set; }

        /// <summary>
        /// Gets or Sets TotalActualAmount
        /// </summary>
        [DataMember(Name="totalActualAmount", EmitDefaultValue=false)]
        public double? TotalActualAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalAllowedAmount
        /// </summary>
        [DataMember(Name="totalAllowedAmount", EmitDefaultValue=false)]
        public double? TotalAllowedAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalBaseEemLoanAmount
        /// </summary>
        [DataMember(Name="totalBaseEemLoanAmount", EmitDefaultValue=false)]
        public double? TotalBaseEemLoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalCombinedLoanAmount
        /// </summary>
        [DataMember(Name="totalCombinedLoanAmount", EmitDefaultValue=false)]
        public double? TotalCombinedLoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalMonthlyHousingPayment
        /// </summary>
        [DataMember(Name="totalMonthlyHousingPayment", EmitDefaultValue=false)]
        public double? TotalMonthlyHousingPayment { get; set; }

        /// <summary>
        /// Gets or Sets TotalMonthlyObligations
        /// </summary>
        [DataMember(Name="totalMonthlyObligations", EmitDefaultValue=false)]
        public double? TotalMonthlyObligations { get; set; }

        /// <summary>
        /// Gets or Sets UfmipBasedOn
        /// </summary>
        [DataMember(Name="ufmipBasedOn", EmitDefaultValue=false)]
        public double? UfmipBasedOn { get; set; }

        /// <summary>
        /// Gets or Sets UfmipFactor
        /// </summary>
        [DataMember(Name="ufmipFactor", EmitDefaultValue=false)]
        public double? UfmipFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractFhaVaLoanEem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppraisedValue: ").Append(AppraisedValue).Append("\n");
            sb.Append("  AuditCost: ").Append(AuditCost).Append("\n");
            sb.Append("  BackRatio: ").Append(BackRatio).Append("\n");
            sb.Append("  BaseLoanAmtFromTsum: ").Append(BaseLoanAmtFromTsum).Append("\n");
            sb.Append("  CostEffectiveEnergyPackage: ").Append(CostEffectiveEnergyPackage).Append("\n");
            sb.Append("  EeCostMaximumAmount: ").Append(EeCostMaximumAmount).Append("\n");
            sb.Append("  EeImprovementsInstalledCost: ").Append(EeImprovementsInstalledCost).Append("\n");
            sb.Append("  EnergyCost: ").Append(EnergyCost).Append("\n");
            sb.Append("  EnergySavings: ").Append(EnergySavings).Append("\n");
            sb.Append("  Hoa: ").Append(Hoa).Append("\n");
            sb.Append("  ImprovementCostExceed2000: ").Append(ImprovementCostExceed2000).Append("\n");
            sb.Append("  InspectionCost: ").Append(InspectionCost).Append("\n");
            sb.Append("  LesserC1ORC2: ").Append(LesserC1ORC2).Append("\n");
            sb.Append("  MonthlyHousingPayment: ").Append(MonthlyHousingPayment).Append("\n");
            sb.Append("  MonthlyMI: ").Append(MonthlyMI).Append("\n");
            sb.Append("  MortgageAmountUsedForQualifyingRate: ").Append(MortgageAmountUsedForQualifyingRate).Append("\n");
            sb.Append("  MortgageAmountUsedForQualifyingRateD1: ").Append(MortgageAmountUsedForQualifyingRateD1).Append("\n");
            sb.Append("  NewOrExisting: ").Append(NewOrExisting).Append("\n");
            sb.Append("  OriginalSalesPriceIfLess12Months: ").Append(OriginalSalesPriceIfLess12Months).Append("\n");
            sb.Append("  OtherHousingPayment: ").Append(OtherHousingPayment).Append("\n");
            sb.Append("  SolarNotIncluded: ").Append(SolarNotIncluded).Append("\n");
            sb.Append("  SolarSystemCostAllowance: ").Append(SolarSystemCostAllowance).Append("\n");
            sb.Append("  TotalActualAmount: ").Append(TotalActualAmount).Append("\n");
            sb.Append("  TotalAllowedAmount: ").Append(TotalAllowedAmount).Append("\n");
            sb.Append("  TotalBaseEemLoanAmount: ").Append(TotalBaseEemLoanAmount).Append("\n");
            sb.Append("  TotalCombinedLoanAmount: ").Append(TotalCombinedLoanAmount).Append("\n");
            sb.Append("  TotalMonthlyHousingPayment: ").Append(TotalMonthlyHousingPayment).Append("\n");
            sb.Append("  TotalMonthlyObligations: ").Append(TotalMonthlyObligations).Append("\n");
            sb.Append("  UfmipBasedOn: ").Append(UfmipBasedOn).Append("\n");
            sb.Append("  UfmipFactor: ").Append(UfmipFactor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoanContractFhaVaLoanEem);
        }

        /// <summary>
        /// Returns true if LoanContractFhaVaLoanEem instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractFhaVaLoanEem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractFhaVaLoanEem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AppraisedValue == input.AppraisedValue ||
                    (this.AppraisedValue != null &&
                    this.AppraisedValue.Equals(input.AppraisedValue))
                ) && 
                (
                    this.AuditCost == input.AuditCost ||
                    (this.AuditCost != null &&
                    this.AuditCost.Equals(input.AuditCost))
                ) && 
                (
                    this.BackRatio == input.BackRatio ||
                    (this.BackRatio != null &&
                    this.BackRatio.Equals(input.BackRatio))
                ) && 
                (
                    this.BaseLoanAmtFromTsum == input.BaseLoanAmtFromTsum ||
                    (this.BaseLoanAmtFromTsum != null &&
                    this.BaseLoanAmtFromTsum.Equals(input.BaseLoanAmtFromTsum))
                ) && 
                (
                    this.CostEffectiveEnergyPackage == input.CostEffectiveEnergyPackage ||
                    (this.CostEffectiveEnergyPackage != null &&
                    this.CostEffectiveEnergyPackage.Equals(input.CostEffectiveEnergyPackage))
                ) && 
                (
                    this.EeCostMaximumAmount == input.EeCostMaximumAmount ||
                    (this.EeCostMaximumAmount != null &&
                    this.EeCostMaximumAmount.Equals(input.EeCostMaximumAmount))
                ) && 
                (
                    this.EeImprovementsInstalledCost == input.EeImprovementsInstalledCost ||
                    (this.EeImprovementsInstalledCost != null &&
                    this.EeImprovementsInstalledCost.Equals(input.EeImprovementsInstalledCost))
                ) && 
                (
                    this.EnergyCost == input.EnergyCost ||
                    (this.EnergyCost != null &&
                    this.EnergyCost.Equals(input.EnergyCost))
                ) && 
                (
                    this.EnergySavings == input.EnergySavings ||
                    (this.EnergySavings != null &&
                    this.EnergySavings.Equals(input.EnergySavings))
                ) && 
                (
                    this.Hoa == input.Hoa ||
                    (this.Hoa != null &&
                    this.Hoa.Equals(input.Hoa))
                ) && 
                (
                    this.ImprovementCostExceed2000 == input.ImprovementCostExceed2000 ||
                    (this.ImprovementCostExceed2000 != null &&
                    this.ImprovementCostExceed2000.Equals(input.ImprovementCostExceed2000))
                ) && 
                (
                    this.InspectionCost == input.InspectionCost ||
                    (this.InspectionCost != null &&
                    this.InspectionCost.Equals(input.InspectionCost))
                ) && 
                (
                    this.LesserC1ORC2 == input.LesserC1ORC2 ||
                    (this.LesserC1ORC2 != null &&
                    this.LesserC1ORC2.Equals(input.LesserC1ORC2))
                ) && 
                (
                    this.MonthlyHousingPayment == input.MonthlyHousingPayment ||
                    (this.MonthlyHousingPayment != null &&
                    this.MonthlyHousingPayment.Equals(input.MonthlyHousingPayment))
                ) && 
                (
                    this.MonthlyMI == input.MonthlyMI ||
                    (this.MonthlyMI != null &&
                    this.MonthlyMI.Equals(input.MonthlyMI))
                ) && 
                (
                    this.MortgageAmountUsedForQualifyingRate == input.MortgageAmountUsedForQualifyingRate ||
                    (this.MortgageAmountUsedForQualifyingRate != null &&
                    this.MortgageAmountUsedForQualifyingRate.Equals(input.MortgageAmountUsedForQualifyingRate))
                ) && 
                (
                    this.MortgageAmountUsedForQualifyingRateD1 == input.MortgageAmountUsedForQualifyingRateD1 ||
                    (this.MortgageAmountUsedForQualifyingRateD1 != null &&
                    this.MortgageAmountUsedForQualifyingRateD1.Equals(input.MortgageAmountUsedForQualifyingRateD1))
                ) && 
                (
                    this.NewOrExisting == input.NewOrExisting ||
                    (this.NewOrExisting != null &&
                    this.NewOrExisting.Equals(input.NewOrExisting))
                ) && 
                (
                    this.OriginalSalesPriceIfLess12Months == input.OriginalSalesPriceIfLess12Months ||
                    (this.OriginalSalesPriceIfLess12Months != null &&
                    this.OriginalSalesPriceIfLess12Months.Equals(input.OriginalSalesPriceIfLess12Months))
                ) && 
                (
                    this.OtherHousingPayment == input.OtherHousingPayment ||
                    (this.OtherHousingPayment != null &&
                    this.OtherHousingPayment.Equals(input.OtherHousingPayment))
                ) && 
                (
                    this.SolarNotIncluded == input.SolarNotIncluded ||
                    (this.SolarNotIncluded != null &&
                    this.SolarNotIncluded.Equals(input.SolarNotIncluded))
                ) && 
                (
                    this.SolarSystemCostAllowance == input.SolarSystemCostAllowance ||
                    (this.SolarSystemCostAllowance != null &&
                    this.SolarSystemCostAllowance.Equals(input.SolarSystemCostAllowance))
                ) && 
                (
                    this.TotalActualAmount == input.TotalActualAmount ||
                    (this.TotalActualAmount != null &&
                    this.TotalActualAmount.Equals(input.TotalActualAmount))
                ) && 
                (
                    this.TotalAllowedAmount == input.TotalAllowedAmount ||
                    (this.TotalAllowedAmount != null &&
                    this.TotalAllowedAmount.Equals(input.TotalAllowedAmount))
                ) && 
                (
                    this.TotalBaseEemLoanAmount == input.TotalBaseEemLoanAmount ||
                    (this.TotalBaseEemLoanAmount != null &&
                    this.TotalBaseEemLoanAmount.Equals(input.TotalBaseEemLoanAmount))
                ) && 
                (
                    this.TotalCombinedLoanAmount == input.TotalCombinedLoanAmount ||
                    (this.TotalCombinedLoanAmount != null &&
                    this.TotalCombinedLoanAmount.Equals(input.TotalCombinedLoanAmount))
                ) && 
                (
                    this.TotalMonthlyHousingPayment == input.TotalMonthlyHousingPayment ||
                    (this.TotalMonthlyHousingPayment != null &&
                    this.TotalMonthlyHousingPayment.Equals(input.TotalMonthlyHousingPayment))
                ) && 
                (
                    this.TotalMonthlyObligations == input.TotalMonthlyObligations ||
                    (this.TotalMonthlyObligations != null &&
                    this.TotalMonthlyObligations.Equals(input.TotalMonthlyObligations))
                ) && 
                (
                    this.UfmipBasedOn == input.UfmipBasedOn ||
                    (this.UfmipBasedOn != null &&
                    this.UfmipBasedOn.Equals(input.UfmipBasedOn))
                ) && 
                (
                    this.UfmipFactor == input.UfmipFactor ||
                    (this.UfmipFactor != null &&
                    this.UfmipFactor.Equals(input.UfmipFactor))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AppraisedValue != null)
                    hashCode = hashCode * 59 + this.AppraisedValue.GetHashCode();
                if (this.AuditCost != null)
                    hashCode = hashCode * 59 + this.AuditCost.GetHashCode();
                if (this.BackRatio != null)
                    hashCode = hashCode * 59 + this.BackRatio.GetHashCode();
                if (this.BaseLoanAmtFromTsum != null)
                    hashCode = hashCode * 59 + this.BaseLoanAmtFromTsum.GetHashCode();
                if (this.CostEffectiveEnergyPackage != null)
                    hashCode = hashCode * 59 + this.CostEffectiveEnergyPackage.GetHashCode();
                if (this.EeCostMaximumAmount != null)
                    hashCode = hashCode * 59 + this.EeCostMaximumAmount.GetHashCode();
                if (this.EeImprovementsInstalledCost != null)
                    hashCode = hashCode * 59 + this.EeImprovementsInstalledCost.GetHashCode();
                if (this.EnergyCost != null)
                    hashCode = hashCode * 59 + this.EnergyCost.GetHashCode();
                if (this.EnergySavings != null)
                    hashCode = hashCode * 59 + this.EnergySavings.GetHashCode();
                if (this.Hoa != null)
                    hashCode = hashCode * 59 + this.Hoa.GetHashCode();
                if (this.ImprovementCostExceed2000 != null)
                    hashCode = hashCode * 59 + this.ImprovementCostExceed2000.GetHashCode();
                if (this.InspectionCost != null)
                    hashCode = hashCode * 59 + this.InspectionCost.GetHashCode();
                if (this.LesserC1ORC2 != null)
                    hashCode = hashCode * 59 + this.LesserC1ORC2.GetHashCode();
                if (this.MonthlyHousingPayment != null)
                    hashCode = hashCode * 59 + this.MonthlyHousingPayment.GetHashCode();
                if (this.MonthlyMI != null)
                    hashCode = hashCode * 59 + this.MonthlyMI.GetHashCode();
                if (this.MortgageAmountUsedForQualifyingRate != null)
                    hashCode = hashCode * 59 + this.MortgageAmountUsedForQualifyingRate.GetHashCode();
                if (this.MortgageAmountUsedForQualifyingRateD1 != null)
                    hashCode = hashCode * 59 + this.MortgageAmountUsedForQualifyingRateD1.GetHashCode();
                if (this.NewOrExisting != null)
                    hashCode = hashCode * 59 + this.NewOrExisting.GetHashCode();
                if (this.OriginalSalesPriceIfLess12Months != null)
                    hashCode = hashCode * 59 + this.OriginalSalesPriceIfLess12Months.GetHashCode();
                if (this.OtherHousingPayment != null)
                    hashCode = hashCode * 59 + this.OtherHousingPayment.GetHashCode();
                if (this.SolarNotIncluded != null)
                    hashCode = hashCode * 59 + this.SolarNotIncluded.GetHashCode();
                if (this.SolarSystemCostAllowance != null)
                    hashCode = hashCode * 59 + this.SolarSystemCostAllowance.GetHashCode();
                if (this.TotalActualAmount != null)
                    hashCode = hashCode * 59 + this.TotalActualAmount.GetHashCode();
                if (this.TotalAllowedAmount != null)
                    hashCode = hashCode * 59 + this.TotalAllowedAmount.GetHashCode();
                if (this.TotalBaseEemLoanAmount != null)
                    hashCode = hashCode * 59 + this.TotalBaseEemLoanAmount.GetHashCode();
                if (this.TotalCombinedLoanAmount != null)
                    hashCode = hashCode * 59 + this.TotalCombinedLoanAmount.GetHashCode();
                if (this.TotalMonthlyHousingPayment != null)
                    hashCode = hashCode * 59 + this.TotalMonthlyHousingPayment.GetHashCode();
                if (this.TotalMonthlyObligations != null)
                    hashCode = hashCode * 59 + this.TotalMonthlyObligations.GetHashCode();
                if (this.UfmipBasedOn != null)
                    hashCode = hashCode * 59 + this.UfmipBasedOn.GetHashCode();
                if (this.UfmipFactor != null)
                    hashCode = hashCode * 59 + this.UfmipFactor.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
