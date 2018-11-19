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
 * Contacts
 *
 * Represents borrower and business contacts
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
using SwaggerDateConverter = Elli.Api.Contacts.Client.SwaggerDateConverter;

namespace Elli.Api.Contacts.Model
{
    /// <summary>
    /// BusinessContactQueryContract
    /// </summary>
    [DataContract]
    public partial class BusinessContactQueryContract :  IEquatable<BusinessContactQueryContract>, IValidatableObject
    {
    
        
        /// <summary>
        /// List of business contact fields to be queried.
        /// </summary>
        /// <value>List of business contact fields to be queried.</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Loan match type. Accepted values - None, AnyClosed, LastClosed, AnyOriginated, LastOriginated
        /// </summary>
        /// <value>Loan match type. Accepted values - None, AnyClosed, LastClosed, AnyOriginated, LastOriginated</value>
        [DataMember(Name="loanMatchType", EmitDefaultValue=false)]
        public string LoanMatchType { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name="filter", EmitDefaultValue=false)]
        public BusinessContactQueryContractFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets SortOrder
        /// </summary>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public List<BusinessContactQueryContractSortOrder> SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessContactQueryContract {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  LoanMatchType: ").Append(LoanMatchType).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as BusinessContactQueryContract);
        }

        /// <summary>
        /// Returns true if BusinessContactQueryContract instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessContactQueryContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessContactQueryContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.LoanMatchType == input.LoanMatchType ||
                    (this.LoanMatchType != null &&
                    this.LoanMatchType.Equals(input.LoanMatchType))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.SequenceEqual(input.SortOrder)
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.LoanMatchType != null)
                    hashCode = hashCode * 59 + this.LoanMatchType.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
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
