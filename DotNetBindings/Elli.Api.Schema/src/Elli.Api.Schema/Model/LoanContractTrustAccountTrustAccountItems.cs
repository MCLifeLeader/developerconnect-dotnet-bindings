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
    /// LoanContractTrustAccountTrustAccountItems
    /// </summary>
    [DataContract]
    public partial class LoanContractTrustAccountTrustAccountItems :  IEquatable<LoanContractTrustAccountTrustAccountItems>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets PaymentAmount
        /// </summary>
        [DataMember(Name="paymentAmount", EmitDefaultValue=false)]
        public double? PaymentAmount { get; set; }

        /// <summary>
        /// Gets or Sets PaymentCheckNo
        /// </summary>
        [DataMember(Name="paymentCheckNo", EmitDefaultValue=false)]
        public string PaymentCheckNo { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptAmount
        /// </summary>
        [DataMember(Name="receiptAmount", EmitDefaultValue=false)]
        public double? ReceiptAmount { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptCheckNo
        /// </summary>
        [DataMember(Name="receiptCheckNo", EmitDefaultValue=false)]
        public string ReceiptCheckNo { get; set; }

        /// <summary>
        /// Gets or Sets TrustAccountItemIndex
        /// </summary>
        [DataMember(Name="trustAccountItemIndex", EmitDefaultValue=false)]
        public int? TrustAccountItemIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractTrustAccountTrustAccountItems {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PaymentAmount: ").Append(PaymentAmount).Append("\n");
            sb.Append("  PaymentCheckNo: ").Append(PaymentCheckNo).Append("\n");
            sb.Append("  ReceiptAmount: ").Append(ReceiptAmount).Append("\n");
            sb.Append("  ReceiptCheckNo: ").Append(ReceiptCheckNo).Append("\n");
            sb.Append("  TrustAccountItemIndex: ").Append(TrustAccountItemIndex).Append("\n");
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
            return this.Equals(input as LoanContractTrustAccountTrustAccountItems);
        }

        /// <summary>
        /// Returns true if LoanContractTrustAccountTrustAccountItems instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractTrustAccountTrustAccountItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractTrustAccountTrustAccountItems input)
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.PaymentAmount == input.PaymentAmount ||
                    (this.PaymentAmount != null &&
                    this.PaymentAmount.Equals(input.PaymentAmount))
                ) && 
                (
                    this.PaymentCheckNo == input.PaymentCheckNo ||
                    (this.PaymentCheckNo != null &&
                    this.PaymentCheckNo.Equals(input.PaymentCheckNo))
                ) && 
                (
                    this.ReceiptAmount == input.ReceiptAmount ||
                    (this.ReceiptAmount != null &&
                    this.ReceiptAmount.Equals(input.ReceiptAmount))
                ) && 
                (
                    this.ReceiptCheckNo == input.ReceiptCheckNo ||
                    (this.ReceiptCheckNo != null &&
                    this.ReceiptCheckNo.Equals(input.ReceiptCheckNo))
                ) && 
                (
                    this.TrustAccountItemIndex == input.TrustAccountItemIndex ||
                    (this.TrustAccountItemIndex != null &&
                    this.TrustAccountItemIndex.Equals(input.TrustAccountItemIndex))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.PaymentAmount != null)
                    hashCode = hashCode * 59 + this.PaymentAmount.GetHashCode();
                if (this.PaymentCheckNo != null)
                    hashCode = hashCode * 59 + this.PaymentCheckNo.GetHashCode();
                if (this.ReceiptAmount != null)
                    hashCode = hashCode * 59 + this.ReceiptAmount.GetHashCode();
                if (this.ReceiptCheckNo != null)
                    hashCode = hashCode * 59 + this.ReceiptCheckNo.GetHashCode();
                if (this.TrustAccountItemIndex != null)
                    hashCode = hashCode * 59 + this.TrustAccountItemIndex.GetHashCode();
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
