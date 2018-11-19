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
    /// LoanContractTQLReports
    /// </summary>
    [DataContract]
    public partial class LoanContractTQLReports :  IEquatable<LoanContractTQLReports>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AltId
        /// </summary>
        [DataMember(Name="altId", EmitDefaultValue=false)]
        public string AltId { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerID1
        /// </summary>
        [DataMember(Name="borrowerID1", EmitDefaultValue=false)]
        public string BorrowerID1 { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerID2
        /// </summary>
        [DataMember(Name="borrowerID2", EmitDefaultValue=false)]
        public string BorrowerID2 { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerID3
        /// </summary>
        [DataMember(Name="borrowerID3", EmitDefaultValue=false)]
        public string BorrowerID3 { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerID4
        /// </summary>
        [DataMember(Name="borrowerID4", EmitDefaultValue=false)]
        public string BorrowerID4 { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDate
        /// </summary>
        [DataMember(Name="completedDate", EmitDefaultValue=false)]
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Gets or Sets Investor
        /// </summary>
        [DataMember(Name="investor", EmitDefaultValue=false)]
        public string Investor { get; set; }

        /// <summary>
        /// Gets or Sets OrderDate
        /// </summary>
        [DataMember(Name="orderDate", EmitDefaultValue=false)]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Gets or Sets OrderNumber
        /// </summary>
        [DataMember(Name="orderNumber", EmitDefaultValue=false)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or Sets OrderStatus
        /// </summary>
        [DataMember(Name="orderStatus", EmitDefaultValue=false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Gets or Sets PercentVariance1
        /// </summary>
        [DataMember(Name="percentVariance1", EmitDefaultValue=false)]
        public double? PercentVariance1 { get; set; }

        /// <summary>
        /// Gets or Sets PercentVariance2
        /// </summary>
        [DataMember(Name="percentVariance2", EmitDefaultValue=false)]
        public double? PercentVariance2 { get; set; }

        /// <summary>
        /// Gets or Sets PercentVariance3
        /// </summary>
        [DataMember(Name="percentVariance3", EmitDefaultValue=false)]
        public double? PercentVariance3 { get; set; }

        /// <summary>
        /// Gets or Sets PercentVariance4
        /// </summary>
        [DataMember(Name="percentVariance4", EmitDefaultValue=false)]
        public double? PercentVariance4 { get; set; }

        /// <summary>
        /// Gets or Sets ProductsOrdered
        /// </summary>
        [DataMember(Name="productsOrdered", EmitDefaultValue=false)]
        public string ProductsOrdered { get; set; }

        /// <summary>
        /// Gets or Sets ReportYear1
        /// </summary>
        [DataMember(Name="reportYear1", EmitDefaultValue=false)]
        public string ReportYear1 { get; set; }

        /// <summary>
        /// Gets or Sets ReportYear2
        /// </summary>
        [DataMember(Name="reportYear2", EmitDefaultValue=false)]
        public string ReportYear2 { get; set; }

        /// <summary>
        /// Gets or Sets ReportYear3
        /// </summary>
        [DataMember(Name="reportYear3", EmitDefaultValue=false)]
        public string ReportYear3 { get; set; }

        /// <summary>
        /// Gets or Sets ReportYear4
        /// </summary>
        [DataMember(Name="reportYear4", EmitDefaultValue=false)]
        public string ReportYear4 { get; set; }

        /// <summary>
        /// Gets or Sets TotalIncome1
        /// </summary>
        [DataMember(Name="totalIncome1", EmitDefaultValue=false)]
        public double? TotalIncome1 { get; set; }

        /// <summary>
        /// Gets or Sets TotalIncome2
        /// </summary>
        [DataMember(Name="totalIncome2", EmitDefaultValue=false)]
        public double? TotalIncome2 { get; set; }

        /// <summary>
        /// Gets or Sets TotalIncome3
        /// </summary>
        [DataMember(Name="totalIncome3", EmitDefaultValue=false)]
        public double? TotalIncome3 { get; set; }

        /// <summary>
        /// Gets or Sets TotalIncome4
        /// </summary>
        [DataMember(Name="totalIncome4", EmitDefaultValue=false)]
        public double? TotalIncome4 { get; set; }

        /// <summary>
        /// Gets or Sets TranscriptType
        /// </summary>
        [DataMember(Name="transcriptType", EmitDefaultValue=false)]
        public string TranscriptType { get; set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [DataMember(Name="userID", EmitDefaultValue=false)]
        public string UserID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractTQLReports {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AltId: ").Append(AltId).Append("\n");
            sb.Append("  BorrowerID1: ").Append(BorrowerID1).Append("\n");
            sb.Append("  BorrowerID2: ").Append(BorrowerID2).Append("\n");
            sb.Append("  BorrowerID3: ").Append(BorrowerID3).Append("\n");
            sb.Append("  BorrowerID4: ").Append(BorrowerID4).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  Investor: ").Append(Investor).Append("\n");
            sb.Append("  OrderDate: ").Append(OrderDate).Append("\n");
            sb.Append("  OrderNumber: ").Append(OrderNumber).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  PercentVariance1: ").Append(PercentVariance1).Append("\n");
            sb.Append("  PercentVariance2: ").Append(PercentVariance2).Append("\n");
            sb.Append("  PercentVariance3: ").Append(PercentVariance3).Append("\n");
            sb.Append("  PercentVariance4: ").Append(PercentVariance4).Append("\n");
            sb.Append("  ProductsOrdered: ").Append(ProductsOrdered).Append("\n");
            sb.Append("  ReportYear1: ").Append(ReportYear1).Append("\n");
            sb.Append("  ReportYear2: ").Append(ReportYear2).Append("\n");
            sb.Append("  ReportYear3: ").Append(ReportYear3).Append("\n");
            sb.Append("  ReportYear4: ").Append(ReportYear4).Append("\n");
            sb.Append("  TotalIncome1: ").Append(TotalIncome1).Append("\n");
            sb.Append("  TotalIncome2: ").Append(TotalIncome2).Append("\n");
            sb.Append("  TotalIncome3: ").Append(TotalIncome3).Append("\n");
            sb.Append("  TotalIncome4: ").Append(TotalIncome4).Append("\n");
            sb.Append("  TranscriptType: ").Append(TranscriptType).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
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
            return this.Equals(input as LoanContractTQLReports);
        }

        /// <summary>
        /// Returns true if LoanContractTQLReports instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractTQLReports to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractTQLReports input)
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
                    this.AltId == input.AltId ||
                    (this.AltId != null &&
                    this.AltId.Equals(input.AltId))
                ) && 
                (
                    this.BorrowerID1 == input.BorrowerID1 ||
                    (this.BorrowerID1 != null &&
                    this.BorrowerID1.Equals(input.BorrowerID1))
                ) && 
                (
                    this.BorrowerID2 == input.BorrowerID2 ||
                    (this.BorrowerID2 != null &&
                    this.BorrowerID2.Equals(input.BorrowerID2))
                ) && 
                (
                    this.BorrowerID3 == input.BorrowerID3 ||
                    (this.BorrowerID3 != null &&
                    this.BorrowerID3.Equals(input.BorrowerID3))
                ) && 
                (
                    this.BorrowerID4 == input.BorrowerID4 ||
                    (this.BorrowerID4 != null &&
                    this.BorrowerID4.Equals(input.BorrowerID4))
                ) && 
                (
                    this.CompletedDate == input.CompletedDate ||
                    (this.CompletedDate != null &&
                    this.CompletedDate.Equals(input.CompletedDate))
                ) && 
                (
                    this.Investor == input.Investor ||
                    (this.Investor != null &&
                    this.Investor.Equals(input.Investor))
                ) && 
                (
                    this.OrderDate == input.OrderDate ||
                    (this.OrderDate != null &&
                    this.OrderDate.Equals(input.OrderDate))
                ) && 
                (
                    this.OrderNumber == input.OrderNumber ||
                    (this.OrderNumber != null &&
                    this.OrderNumber.Equals(input.OrderNumber))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.PercentVariance1 == input.PercentVariance1 ||
                    (this.PercentVariance1 != null &&
                    this.PercentVariance1.Equals(input.PercentVariance1))
                ) && 
                (
                    this.PercentVariance2 == input.PercentVariance2 ||
                    (this.PercentVariance2 != null &&
                    this.PercentVariance2.Equals(input.PercentVariance2))
                ) && 
                (
                    this.PercentVariance3 == input.PercentVariance3 ||
                    (this.PercentVariance3 != null &&
                    this.PercentVariance3.Equals(input.PercentVariance3))
                ) && 
                (
                    this.PercentVariance4 == input.PercentVariance4 ||
                    (this.PercentVariance4 != null &&
                    this.PercentVariance4.Equals(input.PercentVariance4))
                ) && 
                (
                    this.ProductsOrdered == input.ProductsOrdered ||
                    (this.ProductsOrdered != null &&
                    this.ProductsOrdered.Equals(input.ProductsOrdered))
                ) && 
                (
                    this.ReportYear1 == input.ReportYear1 ||
                    (this.ReportYear1 != null &&
                    this.ReportYear1.Equals(input.ReportYear1))
                ) && 
                (
                    this.ReportYear2 == input.ReportYear2 ||
                    (this.ReportYear2 != null &&
                    this.ReportYear2.Equals(input.ReportYear2))
                ) && 
                (
                    this.ReportYear3 == input.ReportYear3 ||
                    (this.ReportYear3 != null &&
                    this.ReportYear3.Equals(input.ReportYear3))
                ) && 
                (
                    this.ReportYear4 == input.ReportYear4 ||
                    (this.ReportYear4 != null &&
                    this.ReportYear4.Equals(input.ReportYear4))
                ) && 
                (
                    this.TotalIncome1 == input.TotalIncome1 ||
                    (this.TotalIncome1 != null &&
                    this.TotalIncome1.Equals(input.TotalIncome1))
                ) && 
                (
                    this.TotalIncome2 == input.TotalIncome2 ||
                    (this.TotalIncome2 != null &&
                    this.TotalIncome2.Equals(input.TotalIncome2))
                ) && 
                (
                    this.TotalIncome3 == input.TotalIncome3 ||
                    (this.TotalIncome3 != null &&
                    this.TotalIncome3.Equals(input.TotalIncome3))
                ) && 
                (
                    this.TotalIncome4 == input.TotalIncome4 ||
                    (this.TotalIncome4 != null &&
                    this.TotalIncome4.Equals(input.TotalIncome4))
                ) && 
                (
                    this.TranscriptType == input.TranscriptType ||
                    (this.TranscriptType != null &&
                    this.TranscriptType.Equals(input.TranscriptType))
                ) && 
                (
                    this.UserID == input.UserID ||
                    (this.UserID != null &&
                    this.UserID.Equals(input.UserID))
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
                if (this.AltId != null)
                    hashCode = hashCode * 59 + this.AltId.GetHashCode();
                if (this.BorrowerID1 != null)
                    hashCode = hashCode * 59 + this.BorrowerID1.GetHashCode();
                if (this.BorrowerID2 != null)
                    hashCode = hashCode * 59 + this.BorrowerID2.GetHashCode();
                if (this.BorrowerID3 != null)
                    hashCode = hashCode * 59 + this.BorrowerID3.GetHashCode();
                if (this.BorrowerID4 != null)
                    hashCode = hashCode * 59 + this.BorrowerID4.GetHashCode();
                if (this.CompletedDate != null)
                    hashCode = hashCode * 59 + this.CompletedDate.GetHashCode();
                if (this.Investor != null)
                    hashCode = hashCode * 59 + this.Investor.GetHashCode();
                if (this.OrderDate != null)
                    hashCode = hashCode * 59 + this.OrderDate.GetHashCode();
                if (this.OrderNumber != null)
                    hashCode = hashCode * 59 + this.OrderNumber.GetHashCode();
                if (this.OrderStatus != null)
                    hashCode = hashCode * 59 + this.OrderStatus.GetHashCode();
                if (this.PercentVariance1 != null)
                    hashCode = hashCode * 59 + this.PercentVariance1.GetHashCode();
                if (this.PercentVariance2 != null)
                    hashCode = hashCode * 59 + this.PercentVariance2.GetHashCode();
                if (this.PercentVariance3 != null)
                    hashCode = hashCode * 59 + this.PercentVariance3.GetHashCode();
                if (this.PercentVariance4 != null)
                    hashCode = hashCode * 59 + this.PercentVariance4.GetHashCode();
                if (this.ProductsOrdered != null)
                    hashCode = hashCode * 59 + this.ProductsOrdered.GetHashCode();
                if (this.ReportYear1 != null)
                    hashCode = hashCode * 59 + this.ReportYear1.GetHashCode();
                if (this.ReportYear2 != null)
                    hashCode = hashCode * 59 + this.ReportYear2.GetHashCode();
                if (this.ReportYear3 != null)
                    hashCode = hashCode * 59 + this.ReportYear3.GetHashCode();
                if (this.ReportYear4 != null)
                    hashCode = hashCode * 59 + this.ReportYear4.GetHashCode();
                if (this.TotalIncome1 != null)
                    hashCode = hashCode * 59 + this.TotalIncome1.GetHashCode();
                if (this.TotalIncome2 != null)
                    hashCode = hashCode * 59 + this.TotalIncome2.GetHashCode();
                if (this.TotalIncome3 != null)
                    hashCode = hashCode * 59 + this.TotalIncome3.GetHashCode();
                if (this.TotalIncome4 != null)
                    hashCode = hashCode * 59 + this.TotalIncome4.GetHashCode();
                if (this.TranscriptType != null)
                    hashCode = hashCode * 59 + this.TranscriptType.GetHashCode();
                if (this.UserID != null)
                    hashCode = hashCode * 59 + this.UserID.GetHashCode();
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
