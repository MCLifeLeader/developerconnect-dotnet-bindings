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
 * Tools
 *
 * Represents calculations applied on a loan
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
using SwaggerDateConverter = Elli.Api.Tools.Client.SwaggerDateConverter;

namespace Elli.Api.Tools.Model
{
    /// <summary>
    /// LoanContractGfeGfeFees
    /// </summary>
    [DataContract]
    public partial class LoanContractGfeGfeFees :  IEquatable<LoanContractGfeGfeFees>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AmountDescription
        /// </summary>
        [DataMember(Name="amountDescription", EmitDefaultValue=false)]
        public string AmountDescription { get; set; }

        /// <summary>
        /// Gets or Sets BrokerAmount
        /// </summary>
        [DataMember(Name="brokerAmount", EmitDefaultValue=false)]
        public double? BrokerAmount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets GfeFeeIndex
        /// </summary>
        [DataMember(Name="gfeFeeIndex", EmitDefaultValue=false)]
        public int? GfeFeeIndex { get; set; }

        /// <summary>
        /// Gets or Sets GfeFeeType
        /// </summary>
        [DataMember(Name="gfeFeeType", EmitDefaultValue=false)]
        public string GfeFeeType { get; set; }

        /// <summary>
        /// Gets or Sets OtherAmount
        /// </summary>
        [DataMember(Name="otherAmount", EmitDefaultValue=false)]
        public double? OtherAmount { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public string Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractGfeGfeFees {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AmountDescription: ").Append(AmountDescription).Append("\n");
            sb.Append("  BrokerAmount: ").Append(BrokerAmount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GfeFeeIndex: ").Append(GfeFeeIndex).Append("\n");
            sb.Append("  GfeFeeType: ").Append(GfeFeeType).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return this.Equals(input as LoanContractGfeGfeFees);
        }

        /// <summary>
        /// Returns true if LoanContractGfeGfeFees instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractGfeGfeFees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractGfeGfeFees input)
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
                    this.AmountDescription == input.AmountDescription ||
                    (this.AmountDescription != null &&
                    this.AmountDescription.Equals(input.AmountDescription))
                ) && 
                (
                    this.BrokerAmount == input.BrokerAmount ||
                    (this.BrokerAmount != null &&
                    this.BrokerAmount.Equals(input.BrokerAmount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.GfeFeeIndex == input.GfeFeeIndex ||
                    (this.GfeFeeIndex != null &&
                    this.GfeFeeIndex.Equals(input.GfeFeeIndex))
                ) && 
                (
                    this.GfeFeeType == input.GfeFeeType ||
                    (this.GfeFeeType != null &&
                    this.GfeFeeType.Equals(input.GfeFeeType))
                ) && 
                (
                    this.OtherAmount == input.OtherAmount ||
                    (this.OtherAmount != null &&
                    this.OtherAmount.Equals(input.OtherAmount))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
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
                if (this.AmountDescription != null)
                    hashCode = hashCode * 59 + this.AmountDescription.GetHashCode();
                if (this.BrokerAmount != null)
                    hashCode = hashCode * 59 + this.BrokerAmount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GfeFeeIndex != null)
                    hashCode = hashCode * 59 + this.GfeFeeIndex.GetHashCode();
                if (this.GfeFeeType != null)
                    hashCode = hashCode * 59 + this.GfeFeeType.GetHashCode();
                if (this.OtherAmount != null)
                    hashCode = hashCode * 59 + this.OtherAmount.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
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
