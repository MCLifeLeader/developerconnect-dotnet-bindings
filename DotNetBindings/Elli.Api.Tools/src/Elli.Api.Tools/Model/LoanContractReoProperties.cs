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
    /// LoanContractReoProperties
    /// </summary>
    [DataContract]
    public partial class LoanContractReoProperties :  IEquatable<LoanContractReoProperties>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets EntityDeleted
        /// </summary>
        [DataMember(Name="entityDeleted", EmitDefaultValue=false)]
        public bool? EntityDeleted { get; set; }

        /// <summary>
        /// Gets or Sets AcquiredDate
        /// </summary>
        [DataMember(Name="acquiredDate", EmitDefaultValue=false)]
        public DateTime? AcquiredDate { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets DispositionStatusType
        /// </summary>
        [DataMember(Name="dispositionStatusType", EmitDefaultValue=false)]
        public string DispositionStatusType { get; set; }

        /// <summary>
        /// Gets or Sets GsePropertyType
        /// </summary>
        [DataMember(Name="gsePropertyType", EmitDefaultValue=false)]
        public string GsePropertyType { get; set; }

        /// <summary>
        /// Gets or Sets IsEmpty
        /// </summary>
        [DataMember(Name="isEmpty", EmitDefaultValue=false)]
        public bool? IsEmpty { get; set; }

        /// <summary>
        /// Gets or Sets LienInstallmentAmount
        /// </summary>
        [DataMember(Name="lienInstallmentAmount", EmitDefaultValue=false)]
        public double? LienInstallmentAmount { get; set; }

        /// <summary>
        /// Gets or Sets LienUpbAmount
        /// </summary>
        [DataMember(Name="lienUpbAmount", EmitDefaultValue=false)]
        public double? LienUpbAmount { get; set; }

        /// <summary>
        /// Gets or Sets MaintenanceExpenseAmount
        /// </summary>
        [DataMember(Name="maintenanceExpenseAmount", EmitDefaultValue=false)]
        public string MaintenanceExpenseAmount { get; set; }

        /// <summary>
        /// Gets or Sets MarketValueAmount
        /// </summary>
        [DataMember(Name="marketValueAmount", EmitDefaultValue=false)]
        public double? MarketValueAmount { get; set; }

        /// <summary>
        /// Gets or Sets NoLinkToDocTrackIndicator
        /// </summary>
        [DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        /// <summary>
        /// Gets or Sets ParticipationPercentage
        /// </summary>
        [DataMember(Name="participationPercentage", EmitDefaultValue=false)]
        public double? ParticipationPercentage { get; set; }

        /// <summary>
        /// Gets or Sets PercentageofRental
        /// </summary>
        [DataMember(Name="percentageofRental", EmitDefaultValue=false)]
        public double? PercentageofRental { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets PrintAttachIndicator
        /// </summary>
        [DataMember(Name="printAttachIndicator", EmitDefaultValue=false)]
        public bool? PrintAttachIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PrintUserNameIndicator
        /// </summary>
        [DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
        public bool? PrintUserNameIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PropertyUsageType
        /// </summary>
        [DataMember(Name="propertyUsageType", EmitDefaultValue=false)]
        public string PropertyUsageType { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name="purchasePrice", EmitDefaultValue=false)]
        public int? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets RentalIncomeGrossAmount
        /// </summary>
        [DataMember(Name="rentalIncomeGrossAmount", EmitDefaultValue=false)]
        public double? RentalIncomeGrossAmount { get; set; }

        /// <summary>
        /// Gets or Sets RentalIncomeNetAmount
        /// </summary>
        [DataMember(Name="rentalIncomeNetAmount", EmitDefaultValue=false)]
        public double? RentalIncomeNetAmount { get; set; }

        /// <summary>
        /// Gets or Sets ReoComments
        /// </summary>
        [DataMember(Name="reoComments", EmitDefaultValue=false)]
        public string ReoComments { get; set; }

        /// <summary>
        /// Gets or Sets ReoId
        /// </summary>
        [DataMember(Name="reoId", EmitDefaultValue=false)]
        public string ReoId { get; set; }

        /// <summary>
        /// Gets or Sets ReoPropertyIndex
        /// </summary>
        [DataMember(Name="reoPropertyIndex", EmitDefaultValue=false)]
        public int? ReoPropertyIndex { get; set; }

        /// <summary>
        /// Gets or Sets RequestDate
        /// </summary>
        [DataMember(Name="requestDate", EmitDefaultValue=false)]
        public DateTime? RequestDate { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name="streetAddress", EmitDefaultValue=false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets SubjectIndicator
        /// </summary>
        [DataMember(Name="subjectIndicator", EmitDefaultValue=false)]
        public bool? SubjectIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TitleFax
        /// </summary>
        [DataMember(Name="titleFax", EmitDefaultValue=false)]
        public string TitleFax { get; set; }

        /// <summary>
        /// Gets or Sets TitlePhone
        /// </summary>
        [DataMember(Name="titlePhone", EmitDefaultValue=false)]
        public string TitlePhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractReoProperties {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityDeleted: ").Append(EntityDeleted).Append("\n");
            sb.Append("  AcquiredDate: ").Append(AcquiredDate).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  DispositionStatusType: ").Append(DispositionStatusType).Append("\n");
            sb.Append("  GsePropertyType: ").Append(GsePropertyType).Append("\n");
            sb.Append("  IsEmpty: ").Append(IsEmpty).Append("\n");
            sb.Append("  LienInstallmentAmount: ").Append(LienInstallmentAmount).Append("\n");
            sb.Append("  LienUpbAmount: ").Append(LienUpbAmount).Append("\n");
            sb.Append("  MaintenanceExpenseAmount: ").Append(MaintenanceExpenseAmount).Append("\n");
            sb.Append("  MarketValueAmount: ").Append(MarketValueAmount).Append("\n");
            sb.Append("  NoLinkToDocTrackIndicator: ").Append(NoLinkToDocTrackIndicator).Append("\n");
            sb.Append("  ParticipationPercentage: ").Append(ParticipationPercentage).Append("\n");
            sb.Append("  PercentageofRental: ").Append(PercentageofRental).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PrintAttachIndicator: ").Append(PrintAttachIndicator).Append("\n");
            sb.Append("  PrintUserNameIndicator: ").Append(PrintUserNameIndicator).Append("\n");
            sb.Append("  PropertyUsageType: ").Append(PropertyUsageType).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  RentalIncomeGrossAmount: ").Append(RentalIncomeGrossAmount).Append("\n");
            sb.Append("  RentalIncomeNetAmount: ").Append(RentalIncomeNetAmount).Append("\n");
            sb.Append("  ReoComments: ").Append(ReoComments).Append("\n");
            sb.Append("  ReoId: ").Append(ReoId).Append("\n");
            sb.Append("  ReoPropertyIndex: ").Append(ReoPropertyIndex).Append("\n");
            sb.Append("  RequestDate: ").Append(RequestDate).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  SubjectIndicator: ").Append(SubjectIndicator).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleFax: ").Append(TitleFax).Append("\n");
            sb.Append("  TitlePhone: ").Append(TitlePhone).Append("\n");
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
            return this.Equals(input as LoanContractReoProperties);
        }

        /// <summary>
        /// Returns true if LoanContractReoProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractReoProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractReoProperties input)
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
                    this.EntityDeleted == input.EntityDeleted ||
                    (this.EntityDeleted != null &&
                    this.EntityDeleted.Equals(input.EntityDeleted))
                ) && 
                (
                    this.AcquiredDate == input.AcquiredDate ||
                    (this.AcquiredDate != null &&
                    this.AcquiredDate.Equals(input.AcquiredDate))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.DispositionStatusType == input.DispositionStatusType ||
                    (this.DispositionStatusType != null &&
                    this.DispositionStatusType.Equals(input.DispositionStatusType))
                ) && 
                (
                    this.GsePropertyType == input.GsePropertyType ||
                    (this.GsePropertyType != null &&
                    this.GsePropertyType.Equals(input.GsePropertyType))
                ) && 
                (
                    this.IsEmpty == input.IsEmpty ||
                    (this.IsEmpty != null &&
                    this.IsEmpty.Equals(input.IsEmpty))
                ) && 
                (
                    this.LienInstallmentAmount == input.LienInstallmentAmount ||
                    (this.LienInstallmentAmount != null &&
                    this.LienInstallmentAmount.Equals(input.LienInstallmentAmount))
                ) && 
                (
                    this.LienUpbAmount == input.LienUpbAmount ||
                    (this.LienUpbAmount != null &&
                    this.LienUpbAmount.Equals(input.LienUpbAmount))
                ) && 
                (
                    this.MaintenanceExpenseAmount == input.MaintenanceExpenseAmount ||
                    (this.MaintenanceExpenseAmount != null &&
                    this.MaintenanceExpenseAmount.Equals(input.MaintenanceExpenseAmount))
                ) && 
                (
                    this.MarketValueAmount == input.MarketValueAmount ||
                    (this.MarketValueAmount != null &&
                    this.MarketValueAmount.Equals(input.MarketValueAmount))
                ) && 
                (
                    this.NoLinkToDocTrackIndicator == input.NoLinkToDocTrackIndicator ||
                    (this.NoLinkToDocTrackIndicator != null &&
                    this.NoLinkToDocTrackIndicator.Equals(input.NoLinkToDocTrackIndicator))
                ) && 
                (
                    this.ParticipationPercentage == input.ParticipationPercentage ||
                    (this.ParticipationPercentage != null &&
                    this.ParticipationPercentage.Equals(input.ParticipationPercentage))
                ) && 
                (
                    this.PercentageofRental == input.PercentageofRental ||
                    (this.PercentageofRental != null &&
                    this.PercentageofRental.Equals(input.PercentageofRental))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.PrintAttachIndicator == input.PrintAttachIndicator ||
                    (this.PrintAttachIndicator != null &&
                    this.PrintAttachIndicator.Equals(input.PrintAttachIndicator))
                ) && 
                (
                    this.PrintUserNameIndicator == input.PrintUserNameIndicator ||
                    (this.PrintUserNameIndicator != null &&
                    this.PrintUserNameIndicator.Equals(input.PrintUserNameIndicator))
                ) && 
                (
                    this.PropertyUsageType == input.PropertyUsageType ||
                    (this.PropertyUsageType != null &&
                    this.PropertyUsageType.Equals(input.PropertyUsageType))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.RentalIncomeGrossAmount == input.RentalIncomeGrossAmount ||
                    (this.RentalIncomeGrossAmount != null &&
                    this.RentalIncomeGrossAmount.Equals(input.RentalIncomeGrossAmount))
                ) && 
                (
                    this.RentalIncomeNetAmount == input.RentalIncomeNetAmount ||
                    (this.RentalIncomeNetAmount != null &&
                    this.RentalIncomeNetAmount.Equals(input.RentalIncomeNetAmount))
                ) && 
                (
                    this.ReoComments == input.ReoComments ||
                    (this.ReoComments != null &&
                    this.ReoComments.Equals(input.ReoComments))
                ) && 
                (
                    this.ReoId == input.ReoId ||
                    (this.ReoId != null &&
                    this.ReoId.Equals(input.ReoId))
                ) && 
                (
                    this.ReoPropertyIndex == input.ReoPropertyIndex ||
                    (this.ReoPropertyIndex != null &&
                    this.ReoPropertyIndex.Equals(input.ReoPropertyIndex))
                ) && 
                (
                    this.RequestDate == input.RequestDate ||
                    (this.RequestDate != null &&
                    this.RequestDate.Equals(input.RequestDate))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.SubjectIndicator == input.SubjectIndicator ||
                    (this.SubjectIndicator != null &&
                    this.SubjectIndicator.Equals(input.SubjectIndicator))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TitleFax == input.TitleFax ||
                    (this.TitleFax != null &&
                    this.TitleFax.Equals(input.TitleFax))
                ) && 
                (
                    this.TitlePhone == input.TitlePhone ||
                    (this.TitlePhone != null &&
                    this.TitlePhone.Equals(input.TitlePhone))
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
                if (this.EntityDeleted != null)
                    hashCode = hashCode * 59 + this.EntityDeleted.GetHashCode();
                if (this.AcquiredDate != null)
                    hashCode = hashCode * 59 + this.AcquiredDate.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.DispositionStatusType != null)
                    hashCode = hashCode * 59 + this.DispositionStatusType.GetHashCode();
                if (this.GsePropertyType != null)
                    hashCode = hashCode * 59 + this.GsePropertyType.GetHashCode();
                if (this.IsEmpty != null)
                    hashCode = hashCode * 59 + this.IsEmpty.GetHashCode();
                if (this.LienInstallmentAmount != null)
                    hashCode = hashCode * 59 + this.LienInstallmentAmount.GetHashCode();
                if (this.LienUpbAmount != null)
                    hashCode = hashCode * 59 + this.LienUpbAmount.GetHashCode();
                if (this.MaintenanceExpenseAmount != null)
                    hashCode = hashCode * 59 + this.MaintenanceExpenseAmount.GetHashCode();
                if (this.MarketValueAmount != null)
                    hashCode = hashCode * 59 + this.MarketValueAmount.GetHashCode();
                if (this.NoLinkToDocTrackIndicator != null)
                    hashCode = hashCode * 59 + this.NoLinkToDocTrackIndicator.GetHashCode();
                if (this.ParticipationPercentage != null)
                    hashCode = hashCode * 59 + this.ParticipationPercentage.GetHashCode();
                if (this.PercentageofRental != null)
                    hashCode = hashCode * 59 + this.PercentageofRental.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PrintAttachIndicator != null)
                    hashCode = hashCode * 59 + this.PrintAttachIndicator.GetHashCode();
                if (this.PrintUserNameIndicator != null)
                    hashCode = hashCode * 59 + this.PrintUserNameIndicator.GetHashCode();
                if (this.PropertyUsageType != null)
                    hashCode = hashCode * 59 + this.PropertyUsageType.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.RentalIncomeGrossAmount != null)
                    hashCode = hashCode * 59 + this.RentalIncomeGrossAmount.GetHashCode();
                if (this.RentalIncomeNetAmount != null)
                    hashCode = hashCode * 59 + this.RentalIncomeNetAmount.GetHashCode();
                if (this.ReoComments != null)
                    hashCode = hashCode * 59 + this.ReoComments.GetHashCode();
                if (this.ReoId != null)
                    hashCode = hashCode * 59 + this.ReoId.GetHashCode();
                if (this.ReoPropertyIndex != null)
                    hashCode = hashCode * 59 + this.ReoPropertyIndex.GetHashCode();
                if (this.RequestDate != null)
                    hashCode = hashCode * 59 + this.RequestDate.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
                if (this.SubjectIndicator != null)
                    hashCode = hashCode * 59 + this.SubjectIndicator.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleFax != null)
                    hashCode = hashCode * 59 + this.TitleFax.GetHashCode();
                if (this.TitlePhone != null)
                    hashCode = hashCode * 59 + this.TitlePhone.GetHashCode();
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
