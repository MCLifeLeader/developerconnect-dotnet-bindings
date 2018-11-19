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
    /// DisclosureTracking2015ContractLoanEstimate
    /// </summary>
    [DataContract]
    public partial class DisclosureTracking2015ContractLoanEstimate :  IEquatable<DisclosureTracking2015ContractLoanEstimate>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets LoanProduct
        /// </summary>
        [DataMember(Name="loanProduct", EmitDefaultValue=false)]
        public string LoanProduct { get; set; }

        /// <summary>
        /// Gets or Sets TotalLoanCosts2
        /// </summary>
        [DataMember(Name="totalLoanCosts2", EmitDefaultValue=false)]
        public string TotalLoanCosts2 { get; set; }

        /// <summary>
        /// Gets or Sets TotalOtherCosts2
        /// </summary>
        [DataMember(Name="totalOtherCosts2", EmitDefaultValue=false)]
        public string TotalOtherCosts2 { get; set; }

        /// <summary>
        /// Gets or Sets TotalLoanAndOtherCosts2
        /// </summary>
        [DataMember(Name="totalLoanAndOtherCosts2", EmitDefaultValue=false)]
        public string TotalLoanAndOtherCosts2 { get; set; }

        /// <summary>
        /// Gets or Sets UnroundedTotalLoanCosts2
        /// </summary>
        [DataMember(Name="unroundedTotalLoanCosts2", EmitDefaultValue=false)]
        public string UnroundedTotalLoanCosts2 { get; set; }

        /// <summary>
        /// Gets or Sets UnroundedTotalOtherCosts2
        /// </summary>
        [DataMember(Name="unroundedTotalOtherCosts2", EmitDefaultValue=false)]
        public string UnroundedTotalOtherCosts2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisclosureTracking2015ContractLoanEstimate {\n");
            sb.Append("  LoanProduct: ").Append(LoanProduct).Append("\n");
            sb.Append("  TotalLoanCosts2: ").Append(TotalLoanCosts2).Append("\n");
            sb.Append("  TotalOtherCosts2: ").Append(TotalOtherCosts2).Append("\n");
            sb.Append("  TotalLoanAndOtherCosts2: ").Append(TotalLoanAndOtherCosts2).Append("\n");
            sb.Append("  UnroundedTotalLoanCosts2: ").Append(UnroundedTotalLoanCosts2).Append("\n");
            sb.Append("  UnroundedTotalOtherCosts2: ").Append(UnroundedTotalOtherCosts2).Append("\n");
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
            return this.Equals(input as DisclosureTracking2015ContractLoanEstimate);
        }

        /// <summary>
        /// Returns true if DisclosureTracking2015ContractLoanEstimate instances are equal
        /// </summary>
        /// <param name="input">Instance of DisclosureTracking2015ContractLoanEstimate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisclosureTracking2015ContractLoanEstimate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoanProduct == input.LoanProduct ||
                    (this.LoanProduct != null &&
                    this.LoanProduct.Equals(input.LoanProduct))
                ) && 
                (
                    this.TotalLoanCosts2 == input.TotalLoanCosts2 ||
                    (this.TotalLoanCosts2 != null &&
                    this.TotalLoanCosts2.Equals(input.TotalLoanCosts2))
                ) && 
                (
                    this.TotalOtherCosts2 == input.TotalOtherCosts2 ||
                    (this.TotalOtherCosts2 != null &&
                    this.TotalOtherCosts2.Equals(input.TotalOtherCosts2))
                ) && 
                (
                    this.TotalLoanAndOtherCosts2 == input.TotalLoanAndOtherCosts2 ||
                    (this.TotalLoanAndOtherCosts2 != null &&
                    this.TotalLoanAndOtherCosts2.Equals(input.TotalLoanAndOtherCosts2))
                ) && 
                (
                    this.UnroundedTotalLoanCosts2 == input.UnroundedTotalLoanCosts2 ||
                    (this.UnroundedTotalLoanCosts2 != null &&
                    this.UnroundedTotalLoanCosts2.Equals(input.UnroundedTotalLoanCosts2))
                ) && 
                (
                    this.UnroundedTotalOtherCosts2 == input.UnroundedTotalOtherCosts2 ||
                    (this.UnroundedTotalOtherCosts2 != null &&
                    this.UnroundedTotalOtherCosts2.Equals(input.UnroundedTotalOtherCosts2))
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
                if (this.LoanProduct != null)
                    hashCode = hashCode * 59 + this.LoanProduct.GetHashCode();
                if (this.TotalLoanCosts2 != null)
                    hashCode = hashCode * 59 + this.TotalLoanCosts2.GetHashCode();
                if (this.TotalOtherCosts2 != null)
                    hashCode = hashCode * 59 + this.TotalOtherCosts2.GetHashCode();
                if (this.TotalLoanAndOtherCosts2 != null)
                    hashCode = hashCode * 59 + this.TotalLoanAndOtherCosts2.GetHashCode();
                if (this.UnroundedTotalLoanCosts2 != null)
                    hashCode = hashCode * 59 + this.UnroundedTotalLoanCosts2.GetHashCode();
                if (this.UnroundedTotalOtherCosts2 != null)
                    hashCode = hashCode * 59 + this.UnroundedTotalOtherCosts2.GetHashCode();
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
