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
 * Schema
 *
 * Represents schema operations on Loan.
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
using SwaggerDateConverter = Elli.Api.Schema.Client.SwaggerDateConverter;

namespace Elli.Api.Schema.Model
{
    /// <summary>
    /// LoanContractRegulationZRegulationZInterestRatePeriods
    /// </summary>
    [DataContract]
    public partial class LoanContractRegulationZRegulationZInterestRatePeriods :  IEquatable<LoanContractRegulationZRegulationZInterestRatePeriods>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentDate
        /// </summary>
        [DataMember(Name="adjustmentDate", EmitDefaultValue=false)]
        public DateTime? AdjustmentDate { get; set; }

        /// <summary>
        /// Gets or Sets AdjustmentMonths
        /// </summary>
        [DataMember(Name="adjustmentMonths", EmitDefaultValue=false)]
        public int? AdjustmentMonths { get; set; }

        /// <summary>
        /// Gets or Sets InterestPayment
        /// </summary>
        [DataMember(Name="interestPayment", EmitDefaultValue=false)]
        public double? InterestPayment { get; set; }

        /// <summary>
        /// Gets or Sets InterestPrincipalPayment
        /// </summary>
        [DataMember(Name="interestPrincipalPayment", EmitDefaultValue=false)]
        public double? InterestPrincipalPayment { get; set; }

        /// <summary>
        /// Gets or Sets InterestRatePercent
        /// </summary>
        [DataMember(Name="interestRatePercent", EmitDefaultValue=false)]
        public double? InterestRatePercent { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyPayment
        /// </summary>
        [DataMember(Name="monthlyPayment", EmitDefaultValue=false)]
        public double? MonthlyPayment { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalPayment
        /// </summary>
        [DataMember(Name="principalPayment", EmitDefaultValue=false)]
        public double? PrincipalPayment { get; set; }

        /// <summary>
        /// Gets or Sets RegulationZInterestRatePeriodType
        /// </summary>
        [DataMember(Name="regulationZInterestRatePeriodType", EmitDefaultValue=false)]
        public string RegulationZInterestRatePeriodType { get; set; }

        /// <summary>
        /// Gets or Sets TaxInsuranceAmount
        /// </summary>
        [DataMember(Name="taxInsuranceAmount", EmitDefaultValue=false)]
        public double? TaxInsuranceAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalPayment
        /// </summary>
        [DataMember(Name="totalPayment", EmitDefaultValue=false)]
        public double? TotalPayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractRegulationZRegulationZInterestRatePeriods {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AdjustmentDate: ").Append(AdjustmentDate).Append("\n");
            sb.Append("  AdjustmentMonths: ").Append(AdjustmentMonths).Append("\n");
            sb.Append("  InterestPayment: ").Append(InterestPayment).Append("\n");
            sb.Append("  InterestPrincipalPayment: ").Append(InterestPrincipalPayment).Append("\n");
            sb.Append("  InterestRatePercent: ").Append(InterestRatePercent).Append("\n");
            sb.Append("  MonthlyPayment: ").Append(MonthlyPayment).Append("\n");
            sb.Append("  PrincipalPayment: ").Append(PrincipalPayment).Append("\n");
            sb.Append("  RegulationZInterestRatePeriodType: ").Append(RegulationZInterestRatePeriodType).Append("\n");
            sb.Append("  TaxInsuranceAmount: ").Append(TaxInsuranceAmount).Append("\n");
            sb.Append("  TotalPayment: ").Append(TotalPayment).Append("\n");
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
            return this.Equals(input as LoanContractRegulationZRegulationZInterestRatePeriods);
        }

        /// <summary>
        /// Returns true if LoanContractRegulationZRegulationZInterestRatePeriods instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractRegulationZRegulationZInterestRatePeriods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractRegulationZRegulationZInterestRatePeriods input)
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
                    this.AdjustmentDate == input.AdjustmentDate ||
                    (this.AdjustmentDate != null &&
                    this.AdjustmentDate.Equals(input.AdjustmentDate))
                ) && 
                (
                    this.AdjustmentMonths == input.AdjustmentMonths ||
                    (this.AdjustmentMonths != null &&
                    this.AdjustmentMonths.Equals(input.AdjustmentMonths))
                ) && 
                (
                    this.InterestPayment == input.InterestPayment ||
                    (this.InterestPayment != null &&
                    this.InterestPayment.Equals(input.InterestPayment))
                ) && 
                (
                    this.InterestPrincipalPayment == input.InterestPrincipalPayment ||
                    (this.InterestPrincipalPayment != null &&
                    this.InterestPrincipalPayment.Equals(input.InterestPrincipalPayment))
                ) && 
                (
                    this.InterestRatePercent == input.InterestRatePercent ||
                    (this.InterestRatePercent != null &&
                    this.InterestRatePercent.Equals(input.InterestRatePercent))
                ) && 
                (
                    this.MonthlyPayment == input.MonthlyPayment ||
                    (this.MonthlyPayment != null &&
                    this.MonthlyPayment.Equals(input.MonthlyPayment))
                ) && 
                (
                    this.PrincipalPayment == input.PrincipalPayment ||
                    (this.PrincipalPayment != null &&
                    this.PrincipalPayment.Equals(input.PrincipalPayment))
                ) && 
                (
                    this.RegulationZInterestRatePeriodType == input.RegulationZInterestRatePeriodType ||
                    (this.RegulationZInterestRatePeriodType != null &&
                    this.RegulationZInterestRatePeriodType.Equals(input.RegulationZInterestRatePeriodType))
                ) && 
                (
                    this.TaxInsuranceAmount == input.TaxInsuranceAmount ||
                    (this.TaxInsuranceAmount != null &&
                    this.TaxInsuranceAmount.Equals(input.TaxInsuranceAmount))
                ) && 
                (
                    this.TotalPayment == input.TotalPayment ||
                    (this.TotalPayment != null &&
                    this.TotalPayment.Equals(input.TotalPayment))
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
                if (this.AdjustmentDate != null)
                    hashCode = hashCode * 59 + this.AdjustmentDate.GetHashCode();
                if (this.AdjustmentMonths != null)
                    hashCode = hashCode * 59 + this.AdjustmentMonths.GetHashCode();
                if (this.InterestPayment != null)
                    hashCode = hashCode * 59 + this.InterestPayment.GetHashCode();
                if (this.InterestPrincipalPayment != null)
                    hashCode = hashCode * 59 + this.InterestPrincipalPayment.GetHashCode();
                if (this.InterestRatePercent != null)
                    hashCode = hashCode * 59 + this.InterestRatePercent.GetHashCode();
                if (this.MonthlyPayment != null)
                    hashCode = hashCode * 59 + this.MonthlyPayment.GetHashCode();
                if (this.PrincipalPayment != null)
                    hashCode = hashCode * 59 + this.PrincipalPayment.GetHashCode();
                if (this.RegulationZInterestRatePeriodType != null)
                    hashCode = hashCode * 59 + this.RegulationZInterestRatePeriodType.GetHashCode();
                if (this.TaxInsuranceAmount != null)
                    hashCode = hashCode * 59 + this.TaxInsuranceAmount.GetHashCode();
                if (this.TotalPayment != null)
                    hashCode = hashCode * 59 + this.TotalPayment.GetHashCode();
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
