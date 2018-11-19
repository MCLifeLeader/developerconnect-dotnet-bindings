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
    /// LoanContractLoanProductDataBuydowns
    /// </summary>
    [DataContract]
    public partial class LoanContractLoanProductDataBuydowns :  IEquatable<LoanContractLoanProductDataBuydowns>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets BuydownRatePercent
        /// </summary>
        [DataMember(Name="buydownRatePercent", EmitDefaultValue=false)]
        public double? BuydownRatePercent { get; set; }

        /// <summary>
        /// Gets or Sets ChangeFrequencyMonthsCount
        /// </summary>
        [DataMember(Name="changeFrequencyMonthsCount", EmitDefaultValue=false)]
        public int? ChangeFrequencyMonthsCount { get; set; }

        /// <summary>
        /// Gets or Sets DurationMonthsCount
        /// </summary>
        [DataMember(Name="durationMonthsCount", EmitDefaultValue=false)]
        public int? DurationMonthsCount { get; set; }

        /// <summary>
        /// Gets or Sets FundBalanceAmount
        /// </summary>
        [DataMember(Name="fundBalanceAmount", EmitDefaultValue=false)]
        public double? FundBalanceAmount { get; set; }

        /// <summary>
        /// Gets or Sets FundTotalAmount
        /// </summary>
        [DataMember(Name="fundTotalAmount", EmitDefaultValue=false)]
        public double? FundTotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets IncreaseRatePercent
        /// </summary>
        [DataMember(Name="increaseRatePercent", EmitDefaultValue=false)]
        public double? IncreaseRatePercent { get; set; }

        /// <summary>
        /// Gets or Sets RemainingMonthsCount
        /// </summary>
        [DataMember(Name="remainingMonthsCount", EmitDefaultValue=false)]
        public int? RemainingMonthsCount { get; set; }

        /// <summary>
        /// Gets or Sets SubsidyAmount
        /// </summary>
        [DataMember(Name="subsidyAmount", EmitDefaultValue=false)]
        public double? SubsidyAmount { get; set; }

        /// <summary>
        /// Gets or Sets BuydownIndex
        /// </summary>
        [DataMember(Name="buydownIndex", EmitDefaultValue=false)]
        public int? BuydownIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractLoanProductDataBuydowns {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BuydownRatePercent: ").Append(BuydownRatePercent).Append("\n");
            sb.Append("  ChangeFrequencyMonthsCount: ").Append(ChangeFrequencyMonthsCount).Append("\n");
            sb.Append("  DurationMonthsCount: ").Append(DurationMonthsCount).Append("\n");
            sb.Append("  FundBalanceAmount: ").Append(FundBalanceAmount).Append("\n");
            sb.Append("  FundTotalAmount: ").Append(FundTotalAmount).Append("\n");
            sb.Append("  IncreaseRatePercent: ").Append(IncreaseRatePercent).Append("\n");
            sb.Append("  RemainingMonthsCount: ").Append(RemainingMonthsCount).Append("\n");
            sb.Append("  SubsidyAmount: ").Append(SubsidyAmount).Append("\n");
            sb.Append("  BuydownIndex: ").Append(BuydownIndex).Append("\n");
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
            return this.Equals(input as LoanContractLoanProductDataBuydowns);
        }

        /// <summary>
        /// Returns true if LoanContractLoanProductDataBuydowns instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractLoanProductDataBuydowns to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractLoanProductDataBuydowns input)
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
                    this.BuydownRatePercent == input.BuydownRatePercent ||
                    (this.BuydownRatePercent != null &&
                    this.BuydownRatePercent.Equals(input.BuydownRatePercent))
                ) && 
                (
                    this.ChangeFrequencyMonthsCount == input.ChangeFrequencyMonthsCount ||
                    (this.ChangeFrequencyMonthsCount != null &&
                    this.ChangeFrequencyMonthsCount.Equals(input.ChangeFrequencyMonthsCount))
                ) && 
                (
                    this.DurationMonthsCount == input.DurationMonthsCount ||
                    (this.DurationMonthsCount != null &&
                    this.DurationMonthsCount.Equals(input.DurationMonthsCount))
                ) && 
                (
                    this.FundBalanceAmount == input.FundBalanceAmount ||
                    (this.FundBalanceAmount != null &&
                    this.FundBalanceAmount.Equals(input.FundBalanceAmount))
                ) && 
                (
                    this.FundTotalAmount == input.FundTotalAmount ||
                    (this.FundTotalAmount != null &&
                    this.FundTotalAmount.Equals(input.FundTotalAmount))
                ) && 
                (
                    this.IncreaseRatePercent == input.IncreaseRatePercent ||
                    (this.IncreaseRatePercent != null &&
                    this.IncreaseRatePercent.Equals(input.IncreaseRatePercent))
                ) && 
                (
                    this.RemainingMonthsCount == input.RemainingMonthsCount ||
                    (this.RemainingMonthsCount != null &&
                    this.RemainingMonthsCount.Equals(input.RemainingMonthsCount))
                ) && 
                (
                    this.SubsidyAmount == input.SubsidyAmount ||
                    (this.SubsidyAmount != null &&
                    this.SubsidyAmount.Equals(input.SubsidyAmount))
                ) && 
                (
                    this.BuydownIndex == input.BuydownIndex ||
                    (this.BuydownIndex != null &&
                    this.BuydownIndex.Equals(input.BuydownIndex))
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
                if (this.BuydownRatePercent != null)
                    hashCode = hashCode * 59 + this.BuydownRatePercent.GetHashCode();
                if (this.ChangeFrequencyMonthsCount != null)
                    hashCode = hashCode * 59 + this.ChangeFrequencyMonthsCount.GetHashCode();
                if (this.DurationMonthsCount != null)
                    hashCode = hashCode * 59 + this.DurationMonthsCount.GetHashCode();
                if (this.FundBalanceAmount != null)
                    hashCode = hashCode * 59 + this.FundBalanceAmount.GetHashCode();
                if (this.FundTotalAmount != null)
                    hashCode = hashCode * 59 + this.FundTotalAmount.GetHashCode();
                if (this.IncreaseRatePercent != null)
                    hashCode = hashCode * 59 + this.IncreaseRatePercent.GetHashCode();
                if (this.RemainingMonthsCount != null)
                    hashCode = hashCode * 59 + this.RemainingMonthsCount.GetHashCode();
                if (this.SubsidyAmount != null)
                    hashCode = hashCode * 59 + this.SubsidyAmount.GetHashCode();
                if (this.BuydownIndex != null)
                    hashCode = hashCode * 59 + this.BuydownIndex.GetHashCode();
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
