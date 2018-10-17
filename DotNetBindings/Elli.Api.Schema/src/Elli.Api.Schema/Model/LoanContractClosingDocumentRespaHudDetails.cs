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
 * OpenAPI spec version: 1.4.0
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
    /// LoanContractClosingDocumentRespaHudDetails
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingDocumentRespaHudDetails :  IEquatable<LoanContractClosingDocumentRespaHudDetails>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreditDebt
        /// </summary>
        [DataMember(Name="creditDebt", EmitDefaultValue=false)]
        public string CreditDebt { get; set; }

        /// <summary>
        /// Gets or Sets FWBC
        /// </summary>
        [DataMember(Name="fWBC", EmitDefaultValue=false)]
        public string FWBC { get; set; }

        /// <summary>
        /// Gets or Sets HUD1LineItemFromDate
        /// </summary>
        [DataMember(Name="hUD1LineItemFromDate", EmitDefaultValue=false)]
        public DateTime? HUD1LineItemFromDate { get; set; }

        /// <summary>
        /// Gets or Sets HUD1LineItemToDate
        /// </summary>
        [DataMember(Name="hUD1LineItemToDate", EmitDefaultValue=false)]
        public DateTime? HUD1LineItemToDate { get; set; }

        /// <summary>
        /// Gets or Sets LineItemAmount
        /// </summary>
        [DataMember(Name="lineItemAmount", EmitDefaultValue=false)]
        public double? LineItemAmount { get; set; }

        /// <summary>
        /// Gets or Sets LineItemDescription
        /// </summary>
        [DataMember(Name="lineItemDescription", EmitDefaultValue=false)]
        public string LineItemDescription { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="lineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Gets or Sets RealValue
        /// </summary>
        [DataMember(Name="realValue", EmitDefaultValue=false)]
        public double? RealValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingDocumentRespaHudDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreditDebt: ").Append(CreditDebt).Append("\n");
            sb.Append("  FWBC: ").Append(FWBC).Append("\n");
            sb.Append("  HUD1LineItemFromDate: ").Append(HUD1LineItemFromDate).Append("\n");
            sb.Append("  HUD1LineItemToDate: ").Append(HUD1LineItemToDate).Append("\n");
            sb.Append("  LineItemAmount: ").Append(LineItemAmount).Append("\n");
            sb.Append("  LineItemDescription: ").Append(LineItemDescription).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  RealValue: ").Append(RealValue).Append("\n");
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
            return this.Equals(input as LoanContractClosingDocumentRespaHudDetails);
        }

        /// <summary>
        /// Returns true if LoanContractClosingDocumentRespaHudDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingDocumentRespaHudDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingDocumentRespaHudDetails input)
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
                    this.CreditDebt == input.CreditDebt ||
                    (this.CreditDebt != null &&
                    this.CreditDebt.Equals(input.CreditDebt))
                ) && 
                (
                    this.FWBC == input.FWBC ||
                    (this.FWBC != null &&
                    this.FWBC.Equals(input.FWBC))
                ) && 
                (
                    this.HUD1LineItemFromDate == input.HUD1LineItemFromDate ||
                    (this.HUD1LineItemFromDate != null &&
                    this.HUD1LineItemFromDate.Equals(input.HUD1LineItemFromDate))
                ) && 
                (
                    this.HUD1LineItemToDate == input.HUD1LineItemToDate ||
                    (this.HUD1LineItemToDate != null &&
                    this.HUD1LineItemToDate.Equals(input.HUD1LineItemToDate))
                ) && 
                (
                    this.LineItemAmount == input.LineItemAmount ||
                    (this.LineItemAmount != null &&
                    this.LineItemAmount.Equals(input.LineItemAmount))
                ) && 
                (
                    this.LineItemDescription == input.LineItemDescription ||
                    (this.LineItemDescription != null &&
                    this.LineItemDescription.Equals(input.LineItemDescription))
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.RealValue == input.RealValue ||
                    (this.RealValue != null &&
                    this.RealValue.Equals(input.RealValue))
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
                if (this.CreditDebt != null)
                    hashCode = hashCode * 59 + this.CreditDebt.GetHashCode();
                if (this.FWBC != null)
                    hashCode = hashCode * 59 + this.FWBC.GetHashCode();
                if (this.HUD1LineItemFromDate != null)
                    hashCode = hashCode * 59 + this.HUD1LineItemFromDate.GetHashCode();
                if (this.HUD1LineItemToDate != null)
                    hashCode = hashCode * 59 + this.HUD1LineItemToDate.GetHashCode();
                if (this.LineItemAmount != null)
                    hashCode = hashCode * 59 + this.LineItemAmount.GetHashCode();
                if (this.LineItemDescription != null)
                    hashCode = hashCode * 59 + this.LineItemDescription.GetHashCode();
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.RealValue != null)
                    hashCode = hashCode * 59 + this.RealValue.GetHashCode();
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