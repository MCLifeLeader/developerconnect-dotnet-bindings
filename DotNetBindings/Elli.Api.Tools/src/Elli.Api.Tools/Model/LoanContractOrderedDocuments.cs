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
    /// LoanContractOrderedDocuments
    /// </summary>
    [DataContract]
    public partial class LoanContractOrderedDocuments :  IEquatable<LoanContractOrderedDocuments>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets SignatureType
        /// </summary>
        [DataMember(Name="signatureType", EmitDefaultValue=false)]
        public string SignatureType { get; set; }

        /// <summary>
        /// Gets or Sets PairId
        /// </summary>
        [DataMember(Name="pairId", EmitDefaultValue=false)]
        public string PairId { get; set; }

        /// <summary>
        /// Gets or Sets DataKey
        /// </summary>
        [DataMember(Name="dataKey", EmitDefaultValue=false)]
        public string DataKey { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets DocumentServiceId
        /// </summary>
        [DataMember(Name="documentServiceId", EmitDefaultValue=false)]
        public string DocumentServiceId { get; set; }

        /// <summary>
        /// Gets or Sets OverflowDataKey
        /// </summary>
        [DataMember(Name="overflowDataKey", EmitDefaultValue=false)]
        public string OverflowDataKey { get; set; }

        /// <summary>
        /// Gets or Sets Overflows
        /// </summary>
        [DataMember(Name="overflows", EmitDefaultValue=false)]
        public List<LoanContractOverflows> Overflows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractOrderedDocuments {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  PairId: ").Append(PairId).Append("\n");
            sb.Append("  DataKey: ").Append(DataKey).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  DocumentServiceId: ").Append(DocumentServiceId).Append("\n");
            sb.Append("  OverflowDataKey: ").Append(OverflowDataKey).Append("\n");
            sb.Append("  Overflows: ").Append(Overflows).Append("\n");
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
            return this.Equals(input as LoanContractOrderedDocuments);
        }

        /// <summary>
        /// Returns true if LoanContractOrderedDocuments instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractOrderedDocuments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractOrderedDocuments input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.SignatureType == input.SignatureType ||
                    (this.SignatureType != null &&
                    this.SignatureType.Equals(input.SignatureType))
                ) && 
                (
                    this.PairId == input.PairId ||
                    (this.PairId != null &&
                    this.PairId.Equals(input.PairId))
                ) && 
                (
                    this.DataKey == input.DataKey ||
                    (this.DataKey != null &&
                    this.DataKey.Equals(input.DataKey))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.DocumentServiceId == input.DocumentServiceId ||
                    (this.DocumentServiceId != null &&
                    this.DocumentServiceId.Equals(input.DocumentServiceId))
                ) && 
                (
                    this.OverflowDataKey == input.OverflowDataKey ||
                    (this.OverflowDataKey != null &&
                    this.OverflowDataKey.Equals(input.OverflowDataKey))
                ) && 
                (
                    this.Overflows == input.Overflows ||
                    this.Overflows != null &&
                    this.Overflows.SequenceEqual(input.Overflows)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.SignatureType != null)
                    hashCode = hashCode * 59 + this.SignatureType.GetHashCode();
                if (this.PairId != null)
                    hashCode = hashCode * 59 + this.PairId.GetHashCode();
                if (this.DataKey != null)
                    hashCode = hashCode * 59 + this.DataKey.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.DocumentServiceId != null)
                    hashCode = hashCode * 59 + this.DocumentServiceId.GetHashCode();
                if (this.OverflowDataKey != null)
                    hashCode = hashCode * 59 + this.OverflowDataKey.GetHashCode();
                if (this.Overflows != null)
                    hashCode = hashCode * 59 + this.Overflows.GetHashCode();
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
