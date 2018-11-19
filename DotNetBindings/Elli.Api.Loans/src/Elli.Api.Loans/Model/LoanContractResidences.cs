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
    /// LoanContractResidences
    /// </summary>
    [DataContract]
    public partial class LoanContractResidences :  IEquatable<LoanContractResidences>, IValidatableObject
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
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="accountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets AddressCity
        /// </summary>
        [DataMember(Name="addressCity", EmitDefaultValue=false)]
        public string AddressCity { get; set; }

        /// <summary>
        /// Gets or Sets AddressPostalCode
        /// </summary>
        [DataMember(Name="addressPostalCode", EmitDefaultValue=false)]
        public string AddressPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets AddressCounty
        /// </summary>
        [DataMember(Name="addressCounty", EmitDefaultValue=false)]
        public string AddressCounty { get; set; }

        /// <summary>
        /// Gets or Sets AddressState
        /// </summary>
        [DataMember(Name="addressState", EmitDefaultValue=false)]
        public string AddressState { get; set; }

        /// <summary>
        /// Gets or Sets AddressStreetLine1
        /// </summary>
        [DataMember(Name="addressStreetLine1", EmitDefaultValue=false)]
        public string AddressStreetLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AltId
        /// </summary>
        [DataMember(Name="altId", EmitDefaultValue=false)]
        public string AltId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicantType
        /// </summary>
        [DataMember(Name="applicantType", EmitDefaultValue=false)]
        public string ApplicantType { get; set; }

        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Gets or Sets DurationTermMonths
        /// </summary>
        [DataMember(Name="durationTermMonths", EmitDefaultValue=false)]
        public int? DurationTermMonths { get; set; }

        /// <summary>
        /// Gets or Sets DurationTermYears
        /// </summary>
        [DataMember(Name="durationTermYears", EmitDefaultValue=false)]
        public int? DurationTermYears { get; set; }

        /// <summary>
        /// Gets or Sets LandlordAttention
        /// </summary>
        [DataMember(Name="landlordAttention", EmitDefaultValue=false)]
        public string LandlordAttention { get; set; }

        /// <summary>
        /// Gets or Sets LandlordCity
        /// </summary>
        [DataMember(Name="landlordCity", EmitDefaultValue=false)]
        public string LandlordCity { get; set; }

        /// <summary>
        /// Gets or Sets LandlordComments
        /// </summary>
        [DataMember(Name="landlordComments", EmitDefaultValue=false)]
        public string LandlordComments { get; set; }

        /// <summary>
        /// Gets or Sets LandlordEmail
        /// </summary>
        [DataMember(Name="landlordEmail", EmitDefaultValue=false)]
        public string LandlordEmail { get; set; }

        /// <summary>
        /// Gets or Sets LandlordFax
        /// </summary>
        [DataMember(Name="landlordFax", EmitDefaultValue=false)]
        public string LandlordFax { get; set; }

        /// <summary>
        /// Gets or Sets LandlordName
        /// </summary>
        [DataMember(Name="landlordName", EmitDefaultValue=false)]
        public string LandlordName { get; set; }

        /// <summary>
        /// Gets or Sets LandlordPhone
        /// </summary>
        [DataMember(Name="landlordPhone", EmitDefaultValue=false)]
        public string LandlordPhone { get; set; }

        /// <summary>
        /// Gets or Sets LandlordPostalCode
        /// </summary>
        [DataMember(Name="landlordPostalCode", EmitDefaultValue=false)]
        public string LandlordPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets LandlordState
        /// </summary>
        [DataMember(Name="landlordState", EmitDefaultValue=false)]
        public string LandlordState { get; set; }

        /// <summary>
        /// Gets or Sets LandlordStreet
        /// </summary>
        [DataMember(Name="landlordStreet", EmitDefaultValue=false)]
        public string LandlordStreet { get; set; }

        /// <summary>
        /// Gets or Sets MailingAddressIndicator
        /// </summary>
        [DataMember(Name="mailingAddressIndicator", EmitDefaultValue=false)]
        public bool? MailingAddressIndicator { get; set; }

        /// <summary>
        /// Gets or Sets NoLinkToDocTrackIndicator
        /// </summary>
        [DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PrintAttachmentIndicator
        /// </summary>
        [DataMember(Name="printAttachmentIndicator", EmitDefaultValue=false)]
        public bool? PrintAttachmentIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PrintUserNameIndicator
        /// </summary>
        [DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
        public bool? PrintUserNameIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Rent
        /// </summary>
        [DataMember(Name="rent", EmitDefaultValue=false)]
        public int? Rent { get; set; }

        /// <summary>
        /// Gets or Sets RequestDate
        /// </summary>
        [DataMember(Name="requestDate", EmitDefaultValue=false)]
        public DateTime? RequestDate { get; set; }

        /// <summary>
        /// Gets or Sets ResidencyBasisType
        /// </summary>
        [DataMember(Name="residencyBasisType", EmitDefaultValue=false)]
        public string ResidencyBasisType { get; set; }

        /// <summary>
        /// Gets or Sets ResidencyType
        /// </summary>
        [DataMember(Name="residencyType", EmitDefaultValue=false)]
        public string ResidencyType { get; set; }

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
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public EntityRefContract Contact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractResidences {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityDeleted: ").Append(EntityDeleted).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressPostalCode: ").Append(AddressPostalCode).Append("\n");
            sb.Append("  AddressCounty: ").Append(AddressCounty).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressStreetLine1: ").Append(AddressStreetLine1).Append("\n");
            sb.Append("  AltId: ").Append(AltId).Append("\n");
            sb.Append("  ApplicantType: ").Append(ApplicantType).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  DurationTermMonths: ").Append(DurationTermMonths).Append("\n");
            sb.Append("  DurationTermYears: ").Append(DurationTermYears).Append("\n");
            sb.Append("  LandlordAttention: ").Append(LandlordAttention).Append("\n");
            sb.Append("  LandlordCity: ").Append(LandlordCity).Append("\n");
            sb.Append("  LandlordComments: ").Append(LandlordComments).Append("\n");
            sb.Append("  LandlordEmail: ").Append(LandlordEmail).Append("\n");
            sb.Append("  LandlordFax: ").Append(LandlordFax).Append("\n");
            sb.Append("  LandlordName: ").Append(LandlordName).Append("\n");
            sb.Append("  LandlordPhone: ").Append(LandlordPhone).Append("\n");
            sb.Append("  LandlordPostalCode: ").Append(LandlordPostalCode).Append("\n");
            sb.Append("  LandlordState: ").Append(LandlordState).Append("\n");
            sb.Append("  LandlordStreet: ").Append(LandlordStreet).Append("\n");
            sb.Append("  MailingAddressIndicator: ").Append(MailingAddressIndicator).Append("\n");
            sb.Append("  NoLinkToDocTrackIndicator: ").Append(NoLinkToDocTrackIndicator).Append("\n");
            sb.Append("  PrintAttachmentIndicator: ").Append(PrintAttachmentIndicator).Append("\n");
            sb.Append("  PrintUserNameIndicator: ").Append(PrintUserNameIndicator).Append("\n");
            sb.Append("  Rent: ").Append(Rent).Append("\n");
            sb.Append("  RequestDate: ").Append(RequestDate).Append("\n");
            sb.Append("  ResidencyBasisType: ").Append(ResidencyBasisType).Append("\n");
            sb.Append("  ResidencyType: ").Append(ResidencyType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleFax: ").Append(TitleFax).Append("\n");
            sb.Append("  TitlePhone: ").Append(TitlePhone).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
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
            return this.Equals(input as LoanContractResidences);
        }

        /// <summary>
        /// Returns true if LoanContractResidences instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractResidences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractResidences input)
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
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AddressCity == input.AddressCity ||
                    (this.AddressCity != null &&
                    this.AddressCity.Equals(input.AddressCity))
                ) && 
                (
                    this.AddressPostalCode == input.AddressPostalCode ||
                    (this.AddressPostalCode != null &&
                    this.AddressPostalCode.Equals(input.AddressPostalCode))
                ) && 
                (
                    this.AddressCounty == input.AddressCounty ||
                    (this.AddressCounty != null &&
                    this.AddressCounty.Equals(input.AddressCounty))
                ) && 
                (
                    this.AddressState == input.AddressState ||
                    (this.AddressState != null &&
                    this.AddressState.Equals(input.AddressState))
                ) && 
                (
                    this.AddressStreetLine1 == input.AddressStreetLine1 ||
                    (this.AddressStreetLine1 != null &&
                    this.AddressStreetLine1.Equals(input.AddressStreetLine1))
                ) && 
                (
                    this.AltId == input.AltId ||
                    (this.AltId != null &&
                    this.AltId.Equals(input.AltId))
                ) && 
                (
                    this.ApplicantType == input.ApplicantType ||
                    (this.ApplicantType != null &&
                    this.ApplicantType.Equals(input.ApplicantType))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.DurationTermMonths == input.DurationTermMonths ||
                    (this.DurationTermMonths != null &&
                    this.DurationTermMonths.Equals(input.DurationTermMonths))
                ) && 
                (
                    this.DurationTermYears == input.DurationTermYears ||
                    (this.DurationTermYears != null &&
                    this.DurationTermYears.Equals(input.DurationTermYears))
                ) && 
                (
                    this.LandlordAttention == input.LandlordAttention ||
                    (this.LandlordAttention != null &&
                    this.LandlordAttention.Equals(input.LandlordAttention))
                ) && 
                (
                    this.LandlordCity == input.LandlordCity ||
                    (this.LandlordCity != null &&
                    this.LandlordCity.Equals(input.LandlordCity))
                ) && 
                (
                    this.LandlordComments == input.LandlordComments ||
                    (this.LandlordComments != null &&
                    this.LandlordComments.Equals(input.LandlordComments))
                ) && 
                (
                    this.LandlordEmail == input.LandlordEmail ||
                    (this.LandlordEmail != null &&
                    this.LandlordEmail.Equals(input.LandlordEmail))
                ) && 
                (
                    this.LandlordFax == input.LandlordFax ||
                    (this.LandlordFax != null &&
                    this.LandlordFax.Equals(input.LandlordFax))
                ) && 
                (
                    this.LandlordName == input.LandlordName ||
                    (this.LandlordName != null &&
                    this.LandlordName.Equals(input.LandlordName))
                ) && 
                (
                    this.LandlordPhone == input.LandlordPhone ||
                    (this.LandlordPhone != null &&
                    this.LandlordPhone.Equals(input.LandlordPhone))
                ) && 
                (
                    this.LandlordPostalCode == input.LandlordPostalCode ||
                    (this.LandlordPostalCode != null &&
                    this.LandlordPostalCode.Equals(input.LandlordPostalCode))
                ) && 
                (
                    this.LandlordState == input.LandlordState ||
                    (this.LandlordState != null &&
                    this.LandlordState.Equals(input.LandlordState))
                ) && 
                (
                    this.LandlordStreet == input.LandlordStreet ||
                    (this.LandlordStreet != null &&
                    this.LandlordStreet.Equals(input.LandlordStreet))
                ) && 
                (
                    this.MailingAddressIndicator == input.MailingAddressIndicator ||
                    (this.MailingAddressIndicator != null &&
                    this.MailingAddressIndicator.Equals(input.MailingAddressIndicator))
                ) && 
                (
                    this.NoLinkToDocTrackIndicator == input.NoLinkToDocTrackIndicator ||
                    (this.NoLinkToDocTrackIndicator != null &&
                    this.NoLinkToDocTrackIndicator.Equals(input.NoLinkToDocTrackIndicator))
                ) && 
                (
                    this.PrintAttachmentIndicator == input.PrintAttachmentIndicator ||
                    (this.PrintAttachmentIndicator != null &&
                    this.PrintAttachmentIndicator.Equals(input.PrintAttachmentIndicator))
                ) && 
                (
                    this.PrintUserNameIndicator == input.PrintUserNameIndicator ||
                    (this.PrintUserNameIndicator != null &&
                    this.PrintUserNameIndicator.Equals(input.PrintUserNameIndicator))
                ) && 
                (
                    this.Rent == input.Rent ||
                    (this.Rent != null &&
                    this.Rent.Equals(input.Rent))
                ) && 
                (
                    this.RequestDate == input.RequestDate ||
                    (this.RequestDate != null &&
                    this.RequestDate.Equals(input.RequestDate))
                ) && 
                (
                    this.ResidencyBasisType == input.ResidencyBasisType ||
                    (this.ResidencyBasisType != null &&
                    this.ResidencyBasisType.Equals(input.ResidencyBasisType))
                ) && 
                (
                    this.ResidencyType == input.ResidencyType ||
                    (this.ResidencyType != null &&
                    this.ResidencyType.Equals(input.ResidencyType))
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
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
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
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AddressCity != null)
                    hashCode = hashCode * 59 + this.AddressCity.GetHashCode();
                if (this.AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.AddressPostalCode.GetHashCode();
                if (this.AddressCounty != null)
                    hashCode = hashCode * 59 + this.AddressCounty.GetHashCode();
                if (this.AddressState != null)
                    hashCode = hashCode * 59 + this.AddressState.GetHashCode();
                if (this.AddressStreetLine1 != null)
                    hashCode = hashCode * 59 + this.AddressStreetLine1.GetHashCode();
                if (this.AltId != null)
                    hashCode = hashCode * 59 + this.AltId.GetHashCode();
                if (this.ApplicantType != null)
                    hashCode = hashCode * 59 + this.ApplicantType.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.DurationTermMonths != null)
                    hashCode = hashCode * 59 + this.DurationTermMonths.GetHashCode();
                if (this.DurationTermYears != null)
                    hashCode = hashCode * 59 + this.DurationTermYears.GetHashCode();
                if (this.LandlordAttention != null)
                    hashCode = hashCode * 59 + this.LandlordAttention.GetHashCode();
                if (this.LandlordCity != null)
                    hashCode = hashCode * 59 + this.LandlordCity.GetHashCode();
                if (this.LandlordComments != null)
                    hashCode = hashCode * 59 + this.LandlordComments.GetHashCode();
                if (this.LandlordEmail != null)
                    hashCode = hashCode * 59 + this.LandlordEmail.GetHashCode();
                if (this.LandlordFax != null)
                    hashCode = hashCode * 59 + this.LandlordFax.GetHashCode();
                if (this.LandlordName != null)
                    hashCode = hashCode * 59 + this.LandlordName.GetHashCode();
                if (this.LandlordPhone != null)
                    hashCode = hashCode * 59 + this.LandlordPhone.GetHashCode();
                if (this.LandlordPostalCode != null)
                    hashCode = hashCode * 59 + this.LandlordPostalCode.GetHashCode();
                if (this.LandlordState != null)
                    hashCode = hashCode * 59 + this.LandlordState.GetHashCode();
                if (this.LandlordStreet != null)
                    hashCode = hashCode * 59 + this.LandlordStreet.GetHashCode();
                if (this.MailingAddressIndicator != null)
                    hashCode = hashCode * 59 + this.MailingAddressIndicator.GetHashCode();
                if (this.NoLinkToDocTrackIndicator != null)
                    hashCode = hashCode * 59 + this.NoLinkToDocTrackIndicator.GetHashCode();
                if (this.PrintAttachmentIndicator != null)
                    hashCode = hashCode * 59 + this.PrintAttachmentIndicator.GetHashCode();
                if (this.PrintUserNameIndicator != null)
                    hashCode = hashCode * 59 + this.PrintUserNameIndicator.GetHashCode();
                if (this.Rent != null)
                    hashCode = hashCode * 59 + this.Rent.GetHashCode();
                if (this.RequestDate != null)
                    hashCode = hashCode * 59 + this.RequestDate.GetHashCode();
                if (this.ResidencyBasisType != null)
                    hashCode = hashCode * 59 + this.ResidencyBasisType.GetHashCode();
                if (this.ResidencyType != null)
                    hashCode = hashCode * 59 + this.ResidencyType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleFax != null)
                    hashCode = hashCode * 59 + this.TitleFax.GetHashCode();
                if (this.TitlePhone != null)
                    hashCode = hashCode * 59 + this.TitlePhone.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
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
