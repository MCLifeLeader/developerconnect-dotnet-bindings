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
    /// LoanContractClosingDocumentClosingEntities
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingDocumentClosingEntities :  IEquatable<LoanContractClosingDocumentClosingEntities>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public string Assignee { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizedToSignIndicator
        /// </summary>
        [DataMember(Name="authorizedToSignIndicator", EmitDefaultValue=false)]
        public bool? AuthorizedToSignIndicator { get; set; }

        /// <summary>
        /// Gets or Sets BorrowerPair
        /// </summary>
        [DataMember(Name="borrowerPair", EmitDefaultValue=false)]
        public string BorrowerPair { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets ClosingEntityType
        /// </summary>
        [DataMember(Name="closingEntityType", EmitDefaultValue=false)]
        public string ClosingEntityType { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationType
        /// </summary>
        [DataMember(Name="organizationType", EmitDefaultValue=false)]
        public string OrganizationType { get; set; }

        /// <summary>
        /// Gets or Sets OrganizedUnderTheLawsOfJurisdictionName
        /// </summary>
        [DataMember(Name="organizedUnderTheLawsOfJurisdictionName", EmitDefaultValue=false)]
        public string OrganizedUnderTheLawsOfJurisdictionName { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Phone1
        /// </summary>
        [DataMember(Name="phone1", EmitDefaultValue=false)]
        public string Phone1 { get; set; }

        /// <summary>
        /// Gets or Sets Phone2
        /// </summary>
        [DataMember(Name="phone2", EmitDefaultValue=false)]
        public string Phone2 { get; set; }

        /// <summary>
        /// Gets or Sets PoaSignatureText
        /// </summary>
        [DataMember(Name="poaSignatureText", EmitDefaultValue=false)]
        public string PoaSignatureText { get; set; }

        /// <summary>
        /// Gets or Sets OccupancyIntent
        /// </summary>
        [DataMember(Name="occupancyIntent", EmitDefaultValue=false)]
        public string OccupancyIntent { get; set; }

        /// <summary>
        /// Gets or Sets OccupancyStatus
        /// </summary>
        [DataMember(Name="occupancyStatus", EmitDefaultValue=false)]
        public string OccupancyStatus { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets PowerOfAttorney
        /// </summary>
        [DataMember(Name="powerOfAttorney", EmitDefaultValue=false)]
        public string PowerOfAttorney { get; set; }

        /// <summary>
        /// Gets or Sets RecordableDocumentTrustDate
        /// </summary>
        [DataMember(Name="recordableDocumentTrustDate", EmitDefaultValue=false)]
        public DateTime? RecordableDocumentTrustDate { get; set; }

        /// <summary>
        /// Gets or Sets RecordCity
        /// </summary>
        [DataMember(Name="recordCity", EmitDefaultValue=false)]
        public string RecordCity { get; set; }

        /// <summary>
        /// Gets or Sets Ssn
        /// </summary>
        [DataMember(Name="ssn", EmitDefaultValue=false)]
        public string Ssn { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public DateTime? DateOfBirth { get; set; }

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
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Gets or Sets TaxIdentificationNumberIdentifier
        /// </summary>
        [DataMember(Name="taxIdentificationNumberIdentifier", EmitDefaultValue=false)]
        public string TaxIdentificationNumberIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets TrustOfficerName1
        /// </summary>
        [DataMember(Name="trustOfficerName1", EmitDefaultValue=false)]
        public string TrustOfficerName1 { get; set; }

        /// <summary>
        /// Gets or Sets TrustOfficerName2
        /// </summary>
        [DataMember(Name="trustOfficerName2", EmitDefaultValue=false)]
        public string TrustOfficerName2 { get; set; }

        /// <summary>
        /// Gets or Sets TrustOfficerTitle1
        /// </summary>
        [DataMember(Name="trustOfficerTitle1", EmitDefaultValue=false)]
        public string TrustOfficerTitle1 { get; set; }

        /// <summary>
        /// Gets or Sets TrustOfficerTitle2
        /// </summary>
        [DataMember(Name="trustOfficerTitle2", EmitDefaultValue=false)]
        public string TrustOfficerTitle2 { get; set; }

        /// <summary>
        /// Gets or Sets UnparsedName
        /// </summary>
        [DataMember(Name="unparsedName", EmitDefaultValue=false)]
        public string UnparsedName { get; set; }

        /// <summary>
        /// Gets or Sets Vesting
        /// </summary>
        [DataMember(Name="vesting", EmitDefaultValue=false)]
        public string Vesting { get; set; }

        /// <summary>
        /// Gets or Sets VestingGuid
        /// </summary>
        [DataMember(Name="vestingGuid", EmitDefaultValue=false)]
        public string VestingGuid { get; set; }

        /// <summary>
        /// Gets or Sets VestingTrusteeOfType
        /// </summary>
        [DataMember(Name="vestingTrusteeOfType", EmitDefaultValue=false)]
        public string VestingTrusteeOfType { get; set; }

        /// <summary>
        /// Gets or Sets VestingType
        /// </summary>
        [DataMember(Name="vestingType", EmitDefaultValue=false)]
        public string VestingType { get; set; }

        /// <summary>
        /// Gets or Sets NBORecordID
        /// </summary>
        [DataMember(Name="nBORecordID", EmitDefaultValue=false)]
        public string NBORecordID { get; set; }

        /// <summary>
        /// Gets or Sets TrusteeIndex
        /// </summary>
        [DataMember(Name="trusteeIndex", EmitDefaultValue=false)]
        public int? TrusteeIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingDocumentClosingEntities {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  AuthorizedToSignIndicator: ").Append(AuthorizedToSignIndicator).Append("\n");
            sb.Append("  BorrowerPair: ").Append(BorrowerPair).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  ClosingEntityType: ").Append(ClosingEntityType).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  OrganizationType: ").Append(OrganizationType).Append("\n");
            sb.Append("  OrganizedUnderTheLawsOfJurisdictionName: ").Append(OrganizedUnderTheLawsOfJurisdictionName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Phone1: ").Append(Phone1).Append("\n");
            sb.Append("  Phone2: ").Append(Phone2).Append("\n");
            sb.Append("  PoaSignatureText: ").Append(PoaSignatureText).Append("\n");
            sb.Append("  OccupancyIntent: ").Append(OccupancyIntent).Append("\n");
            sb.Append("  OccupancyStatus: ").Append(OccupancyStatus).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PowerOfAttorney: ").Append(PowerOfAttorney).Append("\n");
            sb.Append("  RecordableDocumentTrustDate: ").Append(RecordableDocumentTrustDate).Append("\n");
            sb.Append("  RecordCity: ").Append(RecordCity).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  TaxIdentificationNumberIdentifier: ").Append(TaxIdentificationNumberIdentifier).Append("\n");
            sb.Append("  TrustOfficerName1: ").Append(TrustOfficerName1).Append("\n");
            sb.Append("  TrustOfficerName2: ").Append(TrustOfficerName2).Append("\n");
            sb.Append("  TrustOfficerTitle1: ").Append(TrustOfficerTitle1).Append("\n");
            sb.Append("  TrustOfficerTitle2: ").Append(TrustOfficerTitle2).Append("\n");
            sb.Append("  UnparsedName: ").Append(UnparsedName).Append("\n");
            sb.Append("  Vesting: ").Append(Vesting).Append("\n");
            sb.Append("  VestingGuid: ").Append(VestingGuid).Append("\n");
            sb.Append("  VestingTrusteeOfType: ").Append(VestingTrusteeOfType).Append("\n");
            sb.Append("  VestingType: ").Append(VestingType).Append("\n");
            sb.Append("  NBORecordID: ").Append(NBORecordID).Append("\n");
            sb.Append("  TrusteeIndex: ").Append(TrusteeIndex).Append("\n");
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
            return this.Equals(input as LoanContractClosingDocumentClosingEntities);
        }

        /// <summary>
        /// Returns true if LoanContractClosingDocumentClosingEntities instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingDocumentClosingEntities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingDocumentClosingEntities input)
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
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
                ) && 
                (
                    this.AuthorizedToSignIndicator == input.AuthorizedToSignIndicator ||
                    (this.AuthorizedToSignIndicator != null &&
                    this.AuthorizedToSignIndicator.Equals(input.AuthorizedToSignIndicator))
                ) && 
                (
                    this.BorrowerPair == input.BorrowerPair ||
                    (this.BorrowerPair != null &&
                    this.BorrowerPair.Equals(input.BorrowerPair))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.ClosingEntityType == input.ClosingEntityType ||
                    (this.ClosingEntityType != null &&
                    this.ClosingEntityType.Equals(input.ClosingEntityType))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.OrganizationType == input.OrganizationType ||
                    (this.OrganizationType != null &&
                    this.OrganizationType.Equals(input.OrganizationType))
                ) && 
                (
                    this.OrganizedUnderTheLawsOfJurisdictionName == input.OrganizedUnderTheLawsOfJurisdictionName ||
                    (this.OrganizedUnderTheLawsOfJurisdictionName != null &&
                    this.OrganizedUnderTheLawsOfJurisdictionName.Equals(input.OrganizedUnderTheLawsOfJurisdictionName))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Phone1 == input.Phone1 ||
                    (this.Phone1 != null &&
                    this.Phone1.Equals(input.Phone1))
                ) && 
                (
                    this.Phone2 == input.Phone2 ||
                    (this.Phone2 != null &&
                    this.Phone2.Equals(input.Phone2))
                ) && 
                (
                    this.PoaSignatureText == input.PoaSignatureText ||
                    (this.PoaSignatureText != null &&
                    this.PoaSignatureText.Equals(input.PoaSignatureText))
                ) && 
                (
                    this.OccupancyIntent == input.OccupancyIntent ||
                    (this.OccupancyIntent != null &&
                    this.OccupancyIntent.Equals(input.OccupancyIntent))
                ) && 
                (
                    this.OccupancyStatus == input.OccupancyStatus ||
                    (this.OccupancyStatus != null &&
                    this.OccupancyStatus.Equals(input.OccupancyStatus))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.PowerOfAttorney == input.PowerOfAttorney ||
                    (this.PowerOfAttorney != null &&
                    this.PowerOfAttorney.Equals(input.PowerOfAttorney))
                ) && 
                (
                    this.RecordableDocumentTrustDate == input.RecordableDocumentTrustDate ||
                    (this.RecordableDocumentTrustDate != null &&
                    this.RecordableDocumentTrustDate.Equals(input.RecordableDocumentTrustDate))
                ) && 
                (
                    this.RecordCity == input.RecordCity ||
                    (this.RecordCity != null &&
                    this.RecordCity.Equals(input.RecordCity))
                ) && 
                (
                    this.Ssn == input.Ssn ||
                    (this.Ssn != null &&
                    this.Ssn.Equals(input.Ssn))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
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
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.TaxIdentificationNumberIdentifier == input.TaxIdentificationNumberIdentifier ||
                    (this.TaxIdentificationNumberIdentifier != null &&
                    this.TaxIdentificationNumberIdentifier.Equals(input.TaxIdentificationNumberIdentifier))
                ) && 
                (
                    this.TrustOfficerName1 == input.TrustOfficerName1 ||
                    (this.TrustOfficerName1 != null &&
                    this.TrustOfficerName1.Equals(input.TrustOfficerName1))
                ) && 
                (
                    this.TrustOfficerName2 == input.TrustOfficerName2 ||
                    (this.TrustOfficerName2 != null &&
                    this.TrustOfficerName2.Equals(input.TrustOfficerName2))
                ) && 
                (
                    this.TrustOfficerTitle1 == input.TrustOfficerTitle1 ||
                    (this.TrustOfficerTitle1 != null &&
                    this.TrustOfficerTitle1.Equals(input.TrustOfficerTitle1))
                ) && 
                (
                    this.TrustOfficerTitle2 == input.TrustOfficerTitle2 ||
                    (this.TrustOfficerTitle2 != null &&
                    this.TrustOfficerTitle2.Equals(input.TrustOfficerTitle2))
                ) && 
                (
                    this.UnparsedName == input.UnparsedName ||
                    (this.UnparsedName != null &&
                    this.UnparsedName.Equals(input.UnparsedName))
                ) && 
                (
                    this.Vesting == input.Vesting ||
                    (this.Vesting != null &&
                    this.Vesting.Equals(input.Vesting))
                ) && 
                (
                    this.VestingGuid == input.VestingGuid ||
                    (this.VestingGuid != null &&
                    this.VestingGuid.Equals(input.VestingGuid))
                ) && 
                (
                    this.VestingTrusteeOfType == input.VestingTrusteeOfType ||
                    (this.VestingTrusteeOfType != null &&
                    this.VestingTrusteeOfType.Equals(input.VestingTrusteeOfType))
                ) && 
                (
                    this.VestingType == input.VestingType ||
                    (this.VestingType != null &&
                    this.VestingType.Equals(input.VestingType))
                ) && 
                (
                    this.NBORecordID == input.NBORecordID ||
                    (this.NBORecordID != null &&
                    this.NBORecordID.Equals(input.NBORecordID))
                ) && 
                (
                    this.TrusteeIndex == input.TrusteeIndex ||
                    (this.TrusteeIndex != null &&
                    this.TrusteeIndex.Equals(input.TrusteeIndex))
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
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.AuthorizedToSignIndicator != null)
                    hashCode = hashCode * 59 + this.AuthorizedToSignIndicator.GetHashCode();
                if (this.BorrowerPair != null)
                    hashCode = hashCode * 59 + this.BorrowerPair.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.ClosingEntityType != null)
                    hashCode = hashCode * 59 + this.ClosingEntityType.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.OrganizationType != null)
                    hashCode = hashCode * 59 + this.OrganizationType.GetHashCode();
                if (this.OrganizedUnderTheLawsOfJurisdictionName != null)
                    hashCode = hashCode * 59 + this.OrganizedUnderTheLawsOfJurisdictionName.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Phone1 != null)
                    hashCode = hashCode * 59 + this.Phone1.GetHashCode();
                if (this.Phone2 != null)
                    hashCode = hashCode * 59 + this.Phone2.GetHashCode();
                if (this.PoaSignatureText != null)
                    hashCode = hashCode * 59 + this.PoaSignatureText.GetHashCode();
                if (this.OccupancyIntent != null)
                    hashCode = hashCode * 59 + this.OccupancyIntent.GetHashCode();
                if (this.OccupancyStatus != null)
                    hashCode = hashCode * 59 + this.OccupancyStatus.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PowerOfAttorney != null)
                    hashCode = hashCode * 59 + this.PowerOfAttorney.GetHashCode();
                if (this.RecordableDocumentTrustDate != null)
                    hashCode = hashCode * 59 + this.RecordableDocumentTrustDate.GetHashCode();
                if (this.RecordCity != null)
                    hashCode = hashCode * 59 + this.RecordCity.GetHashCode();
                if (this.Ssn != null)
                    hashCode = hashCode * 59 + this.Ssn.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.TaxIdentificationNumberIdentifier != null)
                    hashCode = hashCode * 59 + this.TaxIdentificationNumberIdentifier.GetHashCode();
                if (this.TrustOfficerName1 != null)
                    hashCode = hashCode * 59 + this.TrustOfficerName1.GetHashCode();
                if (this.TrustOfficerName2 != null)
                    hashCode = hashCode * 59 + this.TrustOfficerName2.GetHashCode();
                if (this.TrustOfficerTitle1 != null)
                    hashCode = hashCode * 59 + this.TrustOfficerTitle1.GetHashCode();
                if (this.TrustOfficerTitle2 != null)
                    hashCode = hashCode * 59 + this.TrustOfficerTitle2.GetHashCode();
                if (this.UnparsedName != null)
                    hashCode = hashCode * 59 + this.UnparsedName.GetHashCode();
                if (this.Vesting != null)
                    hashCode = hashCode * 59 + this.Vesting.GetHashCode();
                if (this.VestingGuid != null)
                    hashCode = hashCode * 59 + this.VestingGuid.GetHashCode();
                if (this.VestingTrusteeOfType != null)
                    hashCode = hashCode * 59 + this.VestingTrusteeOfType.GetHashCode();
                if (this.VestingType != null)
                    hashCode = hashCode * 59 + this.VestingType.GetHashCode();
                if (this.NBORecordID != null)
                    hashCode = hashCode * 59 + this.NBORecordID.GetHashCode();
                if (this.TrusteeIndex != null)
                    hashCode = hashCode * 59 + this.TrusteeIndex.GetHashCode();
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
