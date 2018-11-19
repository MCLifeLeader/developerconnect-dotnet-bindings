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
    /// DisclosureTracking2015ContractIntentToProceed
    /// </summary>
    [DataContract]
    public partial class DisclosureTracking2015ContractIntentToProceed :  IEquatable<DisclosureTracking2015ContractIntentToProceed>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [DataMember(Name="intent", EmitDefaultValue=false)]
        public bool? Intent { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedBy
        /// </summary>
        [DataMember(Name="receivedBy", EmitDefaultValue=false)]
        public string ReceivedBy { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedMethod
        /// </summary>
        [DataMember(Name="receivedMethod", EmitDefaultValue=false)]
        public string ReceivedMethod { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedMethodOther
        /// </summary>
        [DataMember(Name="receivedMethodOther", EmitDefaultValue=false)]
        public string ReceivedMethodOther { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisclosureTracking2015ContractIntentToProceed {\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  ReceivedBy: ").Append(ReceivedBy).Append("\n");
            sb.Append("  ReceivedMethod: ").Append(ReceivedMethod).Append("\n");
            sb.Append("  ReceivedMethodOther: ").Append(ReceivedMethodOther).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(input as DisclosureTracking2015ContractIntentToProceed);
        }

        /// <summary>
        /// Returns true if DisclosureTracking2015ContractIntentToProceed instances are equal
        /// </summary>
        /// <param name="input">Instance of DisclosureTracking2015ContractIntentToProceed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisclosureTracking2015ContractIntentToProceed input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Intent == input.Intent ||
                    (this.Intent != null &&
                    this.Intent.Equals(input.Intent))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.ReceivedBy == input.ReceivedBy ||
                    (this.ReceivedBy != null &&
                    this.ReceivedBy.Equals(input.ReceivedBy))
                ) && 
                (
                    this.ReceivedMethod == input.ReceivedMethod ||
                    (this.ReceivedMethod != null &&
                    this.ReceivedMethod.Equals(input.ReceivedMethod))
                ) && 
                (
                    this.ReceivedMethodOther == input.ReceivedMethodOther ||
                    (this.ReceivedMethodOther != null &&
                    this.ReceivedMethodOther.Equals(input.ReceivedMethodOther))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                if (this.Intent != null)
                    hashCode = hashCode * 59 + this.Intent.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.ReceivedBy != null)
                    hashCode = hashCode * 59 + this.ReceivedBy.GetHashCode();
                if (this.ReceivedMethod != null)
                    hashCode = hashCode * 59 + this.ReceivedMethod.GetHashCode();
                if (this.ReceivedMethodOther != null)
                    hashCode = hashCode * 59 + this.ReceivedMethodOther.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
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
