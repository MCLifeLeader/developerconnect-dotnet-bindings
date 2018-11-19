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
    /// LoanContractEmployment
    /// </summary>
    [DataContract]
    public partial class LoanContractEmployment :  IEquatable<LoanContractEmployment>, IValidatableObject
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
        /// Gets or Sets Attention
        /// </summary>
        [DataMember(Name="attention", EmitDefaultValue=false)]
        public string Attention { get; set; }

        /// <summary>
        /// Gets or Sets BasePayAmount
        /// </summary>
        [DataMember(Name="basePayAmount", EmitDefaultValue=false)]
        public double? BasePayAmount { get; set; }

        /// <summary>
        /// Gets or Sets BonusAmount
        /// </summary>
        [DataMember(Name="bonusAmount", EmitDefaultValue=false)]
        public double? BonusAmount { get; set; }

        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets BusinessOwnedPercent
        /// </summary>
        [DataMember(Name="businessOwnedPercent", EmitDefaultValue=false)]
        public double? BusinessOwnedPercent { get; set; }

        /// <summary>
        /// Gets or Sets BusinessPhone
        /// </summary>
        [DataMember(Name="businessPhone", EmitDefaultValue=false)]
        public string BusinessPhone { get; set; }

        /// <summary>
        /// Gets or Sets CommissionsAmount
        /// </summary>
        [DataMember(Name="commissionsAmount", EmitDefaultValue=false)]
        public double? CommissionsAmount { get; set; }

        /// <summary>
        /// Gets or Sets CurrentEmploymentIndicator
        /// </summary>
        [DataMember(Name="currentEmploymentIndicator", EmitDefaultValue=false)]
        public bool? CurrentEmploymentIndicator { get; set; }

        /// <summary>
        /// Gets or Sets BadgeOrEmployeeID
        /// </summary>
        [DataMember(Name="badgeOrEmployeeID", EmitDefaultValue=false)]
        public string BadgeOrEmployeeID { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets EmployerComments
        /// </summary>
        [DataMember(Name="employerComments", EmitDefaultValue=false)]
        public string EmployerComments { get; set; }

        /// <summary>
        /// Gets or Sets EmployerName
        /// </summary>
        [DataMember(Name="employerName", EmitDefaultValue=false)]
        public string EmployerName { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyIncomeAmount
        /// </summary>
        [DataMember(Name="monthlyIncomeAmount", EmitDefaultValue=false)]
        public int? MonthlyIncomeAmount { get; set; }

        /// <summary>
        /// Gets or Sets NoLinkToDocTrackIndicator
        /// </summary>
        [DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        /// <summary>
        /// Gets or Sets OtherAmount
        /// </summary>
        [DataMember(Name="otherAmount", EmitDefaultValue=false)]
        public double? OtherAmount { get; set; }

        /// <summary>
        /// Gets or Sets OvertimeAmount
        /// </summary>
        [DataMember(Name="overtimeAmount", EmitDefaultValue=false)]
        public double? OvertimeAmount { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PositionDescription
        /// </summary>
        [DataMember(Name="positionDescription", EmitDefaultValue=false)]
        public string PositionDescription { get; set; }

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
        /// Gets or Sets SelfEmployedIndicator
        /// </summary>
        [DataMember(Name="selfEmployedIndicator", EmitDefaultValue=false)]
        public bool? SelfEmployedIndicator { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets TimeInLineOfWorkMonths
        /// </summary>
        [DataMember(Name="timeInLineOfWorkMonths", EmitDefaultValue=false)]
        public int? TimeInLineOfWorkMonths { get; set; }

        /// <summary>
        /// Gets or Sets TimeInLineOfWorkYears
        /// </summary>
        [DataMember(Name="timeInLineOfWorkYears", EmitDefaultValue=false)]
        public int? TimeInLineOfWorkYears { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnJobTermMonths
        /// </summary>
        [DataMember(Name="timeOnJobTermMonths", EmitDefaultValue=false)]
        public int? TimeOnJobTermMonths { get; set; }

        /// <summary>
        /// Gets or Sets TimeOnJobTermYears
        /// </summary>
        [DataMember(Name="timeOnJobTermYears", EmitDefaultValue=false)]
        public int? TimeOnJobTermYears { get; set; }

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
        /// Gets or Sets VerificationRequestDate
        /// </summary>
        [DataMember(Name="verificationRequestDate", EmitDefaultValue=false)]
        public DateTime? VerificationRequestDate { get; set; }

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
            sb.Append("class LoanContractEmployment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntityDeleted: ").Append(EntityDeleted).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressPostalCode: ").Append(AddressPostalCode).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressStreetLine1: ").Append(AddressStreetLine1).Append("\n");
            sb.Append("  AltId: ").Append(AltId).Append("\n");
            sb.Append("  Attention: ").Append(Attention).Append("\n");
            sb.Append("  BasePayAmount: ").Append(BasePayAmount).Append("\n");
            sb.Append("  BonusAmount: ").Append(BonusAmount).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessOwnedPercent: ").Append(BusinessOwnedPercent).Append("\n");
            sb.Append("  BusinessPhone: ").Append(BusinessPhone).Append("\n");
            sb.Append("  CommissionsAmount: ").Append(CommissionsAmount).Append("\n");
            sb.Append("  CurrentEmploymentIndicator: ").Append(CurrentEmploymentIndicator).Append("\n");
            sb.Append("  BadgeOrEmployeeID: ").Append(BadgeOrEmployeeID).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmployerComments: ").Append(EmployerComments).Append("\n");
            sb.Append("  EmployerName: ").Append(EmployerName).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  MonthlyIncomeAmount: ").Append(MonthlyIncomeAmount).Append("\n");
            sb.Append("  NoLinkToDocTrackIndicator: ").Append(NoLinkToDocTrackIndicator).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  OvertimeAmount: ").Append(OvertimeAmount).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PositionDescription: ").Append(PositionDescription).Append("\n");
            sb.Append("  PrintAttachmentIndicator: ").Append(PrintAttachmentIndicator).Append("\n");
            sb.Append("  PrintUserNameIndicator: ").Append(PrintUserNameIndicator).Append("\n");
            sb.Append("  SelfEmployedIndicator: ").Append(SelfEmployedIndicator).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  TimeInLineOfWorkMonths: ").Append(TimeInLineOfWorkMonths).Append("\n");
            sb.Append("  TimeInLineOfWorkYears: ").Append(TimeInLineOfWorkYears).Append("\n");
            sb.Append("  TimeOnJobTermMonths: ").Append(TimeOnJobTermMonths).Append("\n");
            sb.Append("  TimeOnJobTermYears: ").Append(TimeOnJobTermYears).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TitleFax: ").Append(TitleFax).Append("\n");
            sb.Append("  TitlePhone: ").Append(TitlePhone).Append("\n");
            sb.Append("  VerificationRequestDate: ").Append(VerificationRequestDate).Append("\n");
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
            return this.Equals(input as LoanContractEmployment);
        }

        /// <summary>
        /// Returns true if LoanContractEmployment instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractEmployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractEmployment input)
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
                    this.Attention == input.Attention ||
                    (this.Attention != null &&
                    this.Attention.Equals(input.Attention))
                ) && 
                (
                    this.BasePayAmount == input.BasePayAmount ||
                    (this.BasePayAmount != null &&
                    this.BasePayAmount.Equals(input.BasePayAmount))
                ) && 
                (
                    this.BonusAmount == input.BonusAmount ||
                    (this.BonusAmount != null &&
                    this.BonusAmount.Equals(input.BonusAmount))
                ) && 
                (
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.BusinessOwnedPercent == input.BusinessOwnedPercent ||
                    (this.BusinessOwnedPercent != null &&
                    this.BusinessOwnedPercent.Equals(input.BusinessOwnedPercent))
                ) && 
                (
                    this.BusinessPhone == input.BusinessPhone ||
                    (this.BusinessPhone != null &&
                    this.BusinessPhone.Equals(input.BusinessPhone))
                ) && 
                (
                    this.CommissionsAmount == input.CommissionsAmount ||
                    (this.CommissionsAmount != null &&
                    this.CommissionsAmount.Equals(input.CommissionsAmount))
                ) && 
                (
                    this.CurrentEmploymentIndicator == input.CurrentEmploymentIndicator ||
                    (this.CurrentEmploymentIndicator != null &&
                    this.CurrentEmploymentIndicator.Equals(input.CurrentEmploymentIndicator))
                ) && 
                (
                    this.BadgeOrEmployeeID == input.BadgeOrEmployeeID ||
                    (this.BadgeOrEmployeeID != null &&
                    this.BadgeOrEmployeeID.Equals(input.BadgeOrEmployeeID))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.EmployerComments == input.EmployerComments ||
                    (this.EmployerComments != null &&
                    this.EmployerComments.Equals(input.EmployerComments))
                ) && 
                (
                    this.EmployerName == input.EmployerName ||
                    (this.EmployerName != null &&
                    this.EmployerName.Equals(input.EmployerName))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.MonthlyIncomeAmount == input.MonthlyIncomeAmount ||
                    (this.MonthlyIncomeAmount != null &&
                    this.MonthlyIncomeAmount.Equals(input.MonthlyIncomeAmount))
                ) && 
                (
                    this.NoLinkToDocTrackIndicator == input.NoLinkToDocTrackIndicator ||
                    (this.NoLinkToDocTrackIndicator != null &&
                    this.NoLinkToDocTrackIndicator.Equals(input.NoLinkToDocTrackIndicator))
                ) && 
                (
                    this.OtherAmount == input.OtherAmount ||
                    (this.OtherAmount != null &&
                    this.OtherAmount.Equals(input.OtherAmount))
                ) && 
                (
                    this.OvertimeAmount == input.OvertimeAmount ||
                    (this.OvertimeAmount != null &&
                    this.OvertimeAmount.Equals(input.OvertimeAmount))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PositionDescription == input.PositionDescription ||
                    (this.PositionDescription != null &&
                    this.PositionDescription.Equals(input.PositionDescription))
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
                    this.SelfEmployedIndicator == input.SelfEmployedIndicator ||
                    (this.SelfEmployedIndicator != null &&
                    this.SelfEmployedIndicator.Equals(input.SelfEmployedIndicator))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.TimeInLineOfWorkMonths == input.TimeInLineOfWorkMonths ||
                    (this.TimeInLineOfWorkMonths != null &&
                    this.TimeInLineOfWorkMonths.Equals(input.TimeInLineOfWorkMonths))
                ) && 
                (
                    this.TimeInLineOfWorkYears == input.TimeInLineOfWorkYears ||
                    (this.TimeInLineOfWorkYears != null &&
                    this.TimeInLineOfWorkYears.Equals(input.TimeInLineOfWorkYears))
                ) && 
                (
                    this.TimeOnJobTermMonths == input.TimeOnJobTermMonths ||
                    (this.TimeOnJobTermMonths != null &&
                    this.TimeOnJobTermMonths.Equals(input.TimeOnJobTermMonths))
                ) && 
                (
                    this.TimeOnJobTermYears == input.TimeOnJobTermYears ||
                    (this.TimeOnJobTermYears != null &&
                    this.TimeOnJobTermYears.Equals(input.TimeOnJobTermYears))
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
                    this.VerificationRequestDate == input.VerificationRequestDate ||
                    (this.VerificationRequestDate != null &&
                    this.VerificationRequestDate.Equals(input.VerificationRequestDate))
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
                if (this.AddressCity != null)
                    hashCode = hashCode * 59 + this.AddressCity.GetHashCode();
                if (this.AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.AddressPostalCode.GetHashCode();
                if (this.AddressState != null)
                    hashCode = hashCode * 59 + this.AddressState.GetHashCode();
                if (this.AddressStreetLine1 != null)
                    hashCode = hashCode * 59 + this.AddressStreetLine1.GetHashCode();
                if (this.AltId != null)
                    hashCode = hashCode * 59 + this.AltId.GetHashCode();
                if (this.Attention != null)
                    hashCode = hashCode * 59 + this.Attention.GetHashCode();
                if (this.BasePayAmount != null)
                    hashCode = hashCode * 59 + this.BasePayAmount.GetHashCode();
                if (this.BonusAmount != null)
                    hashCode = hashCode * 59 + this.BonusAmount.GetHashCode();
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.BusinessOwnedPercent != null)
                    hashCode = hashCode * 59 + this.BusinessOwnedPercent.GetHashCode();
                if (this.BusinessPhone != null)
                    hashCode = hashCode * 59 + this.BusinessPhone.GetHashCode();
                if (this.CommissionsAmount != null)
                    hashCode = hashCode * 59 + this.CommissionsAmount.GetHashCode();
                if (this.CurrentEmploymentIndicator != null)
                    hashCode = hashCode * 59 + this.CurrentEmploymentIndicator.GetHashCode();
                if (this.BadgeOrEmployeeID != null)
                    hashCode = hashCode * 59 + this.BadgeOrEmployeeID.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EmployerComments != null)
                    hashCode = hashCode * 59 + this.EmployerComments.GetHashCode();
                if (this.EmployerName != null)
                    hashCode = hashCode * 59 + this.EmployerName.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.MonthlyIncomeAmount != null)
                    hashCode = hashCode * 59 + this.MonthlyIncomeAmount.GetHashCode();
                if (this.NoLinkToDocTrackIndicator != null)
                    hashCode = hashCode * 59 + this.NoLinkToDocTrackIndicator.GetHashCode();
                if (this.OtherAmount != null)
                    hashCode = hashCode * 59 + this.OtherAmount.GetHashCode();
                if (this.OvertimeAmount != null)
                    hashCode = hashCode * 59 + this.OvertimeAmount.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PositionDescription != null)
                    hashCode = hashCode * 59 + this.PositionDescription.GetHashCode();
                if (this.PrintAttachmentIndicator != null)
                    hashCode = hashCode * 59 + this.PrintAttachmentIndicator.GetHashCode();
                if (this.PrintUserNameIndicator != null)
                    hashCode = hashCode * 59 + this.PrintUserNameIndicator.GetHashCode();
                if (this.SelfEmployedIndicator != null)
                    hashCode = hashCode * 59 + this.SelfEmployedIndicator.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.TimeInLineOfWorkMonths != null)
                    hashCode = hashCode * 59 + this.TimeInLineOfWorkMonths.GetHashCode();
                if (this.TimeInLineOfWorkYears != null)
                    hashCode = hashCode * 59 + this.TimeInLineOfWorkYears.GetHashCode();
                if (this.TimeOnJobTermMonths != null)
                    hashCode = hashCode * 59 + this.TimeOnJobTermMonths.GetHashCode();
                if (this.TimeOnJobTermYears != null)
                    hashCode = hashCode * 59 + this.TimeOnJobTermYears.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TitleFax != null)
                    hashCode = hashCode * 59 + this.TitleFax.GetHashCode();
                if (this.TitlePhone != null)
                    hashCode = hashCode * 59 + this.TitlePhone.GetHashCode();
                if (this.VerificationRequestDate != null)
                    hashCode = hashCode * 59 + this.VerificationRequestDate.GetHashCode();
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
