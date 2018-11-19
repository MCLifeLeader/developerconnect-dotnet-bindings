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
 * Settings
 *
 * Represents settings operations on Company, Loan, Contact etc.
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
using SwaggerDateConverter = Elli.Api.Settings.Client.SwaggerDateConverter;

namespace Elli.Api.Settings.Model
{
    /// <summary>
    /// OrganizationInfoContractOnrpSettings
    /// </summary>
    [DataContract]
    public partial class OrganizationInfoContractOnrpSettings :  IEquatable<OrganizationInfoContractOnrpSettings>, IValidatableObject
    {
    
        
        /// <summary>
        /// Indicates if parent organization&#39;s ONRP setting wil be used.
        /// </summary>
        /// <value>Indicates if parent organization&#39;s ONRP setting wil be used.</value>
        [DataMember(Name="useParentInformation", EmitDefaultValue=false)]
        public bool? UseParentInformation { get; set; }

        /// <summary>
        /// Indicates if ONRP is enabled.
        /// </summary>
        /// <value>Indicates if ONRP is enabled.</value>
        [DataMember(Name="enableOnrp", EmitDefaultValue=false)]
        public bool? EnableOnrp { get; set; }

        /// <summary>
        /// Indicates if Channel defaults are set or custom setting is set for this organization.
        /// </summary>
        /// <value>Indicates if Channel defaults are set or custom setting is set for this organization.</value>
        [DataMember(Name="useChannelDefault", EmitDefaultValue=false)]
        public bool? UseChannelDefault { get; set; }

        /// <summary>
        /// Indicates if continuous coverage is available.
        /// </summary>
        /// <value>Indicates if continuous coverage is available.</value>
        [DataMember(Name="continuousCoverage", EmitDefaultValue=false)]
        public bool? ContinuousCoverage { get; set; }

        /// <summary>
        /// Weekdays start time like &#39;05:00&#39;
        /// </summary>
        /// <value>Weekdays start time like &#39;05:00&#39;</value>
        [DataMember(Name="weekdayStartTime", EmitDefaultValue=false)]
        public string WeekdayStartTime { get; set; }

        /// <summary>
        /// Weekdays end time like &#39;17:00&#39;
        /// </summary>
        /// <value>Weekdays end time like &#39;17:00&#39;</value>
        [DataMember(Name="weekdayEndTime", EmitDefaultValue=false)]
        public string WeekdayEndTime { get; set; }

        /// <summary>
        /// Indicates if weekend holiday coverage is available.
        /// </summary>
        /// <value>Indicates if weekend holiday coverage is available.</value>
        [DataMember(Name="weekendHolidayCoverage", EmitDefaultValue=false)]
        public bool? WeekendHolidayCoverage { get; set; }

        /// <summary>
        /// indicates if sundays are covered.
        /// </summary>
        /// <value>indicates if sundays are covered.</value>
        [DataMember(Name="enableSunday", EmitDefaultValue=false)]
        public bool? EnableSunday { get; set; }

        /// <summary>
        /// Sunday start time like &#39;05:00&#39;
        /// </summary>
        /// <value>Sunday start time like &#39;05:00&#39;</value>
        [DataMember(Name="sundayStartTime", EmitDefaultValue=false)]
        public string SundayStartTime { get; set; }

        /// <summary>
        /// Sunday end time like &#39;17:00&#39;
        /// </summary>
        /// <value>Sunday end time like &#39;17:00&#39;</value>
        [DataMember(Name="sundayEndTime", EmitDefaultValue=false)]
        public string SundayEndTime { get; set; }

        /// <summary>
        /// Indicates if Saturdays are covered.
        /// </summary>
        /// <value>Indicates if Saturdays are covered.</value>
        [DataMember(Name="enableSaturday", EmitDefaultValue=false)]
        public bool? EnableSaturday { get; set; }

        /// <summary>
        /// Saturday start time like &#39;05:00&#39;
        /// </summary>
        /// <value>Saturday start time like &#39;05:00&#39;</value>
        [DataMember(Name="saturdayStartTime", EmitDefaultValue=false)]
        public string SaturdayStartTime { get; set; }

        /// <summary>
        /// Saturday end time like &#39;17:00&#39;
        /// </summary>
        /// <value>Saturday end time like &#39;17:00&#39;</value>
        [DataMember(Name="saturdayEndTime", EmitDefaultValue=false)]
        public string SaturdayEndTime { get; set; }

        /// <summary>
        /// Indicates if no limits on doller or tolerance.
        /// </summary>
        /// <value>Indicates if no limits on doller or tolerance.</value>
        [DataMember(Name="noMaximumLimit", EmitDefaultValue=false)]
        public bool? NoMaximumLimit { get; set; }

        /// <summary>
        /// dollar limit
        /// </summary>
        /// <value>dollar limit</value>
        [DataMember(Name="dollarLimit", EmitDefaultValue=false)]
        public double? DollarLimit { get; set; }

        /// <summary>
        /// tolerance percentage
        /// </summary>
        /// <value>tolerance percentage</value>
        [DataMember(Name="tolerance", EmitDefaultValue=false)]
        public int? Tolerance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationInfoContractOnrpSettings {\n");
            sb.Append("  UseParentInformation: ").Append(UseParentInformation).Append("\n");
            sb.Append("  EnableOnrp: ").Append(EnableOnrp).Append("\n");
            sb.Append("  UseChannelDefault: ").Append(UseChannelDefault).Append("\n");
            sb.Append("  ContinuousCoverage: ").Append(ContinuousCoverage).Append("\n");
            sb.Append("  WeekdayStartTime: ").Append(WeekdayStartTime).Append("\n");
            sb.Append("  WeekdayEndTime: ").Append(WeekdayEndTime).Append("\n");
            sb.Append("  WeekendHolidayCoverage: ").Append(WeekendHolidayCoverage).Append("\n");
            sb.Append("  EnableSunday: ").Append(EnableSunday).Append("\n");
            sb.Append("  SundayStartTime: ").Append(SundayStartTime).Append("\n");
            sb.Append("  SundayEndTime: ").Append(SundayEndTime).Append("\n");
            sb.Append("  EnableSaturday: ").Append(EnableSaturday).Append("\n");
            sb.Append("  SaturdayStartTime: ").Append(SaturdayStartTime).Append("\n");
            sb.Append("  SaturdayEndTime: ").Append(SaturdayEndTime).Append("\n");
            sb.Append("  NoMaximumLimit: ").Append(NoMaximumLimit).Append("\n");
            sb.Append("  DollarLimit: ").Append(DollarLimit).Append("\n");
            sb.Append("  Tolerance: ").Append(Tolerance).Append("\n");
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
            return this.Equals(input as OrganizationInfoContractOnrpSettings);
        }

        /// <summary>
        /// Returns true if OrganizationInfoContractOnrpSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationInfoContractOnrpSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationInfoContractOnrpSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseParentInformation == input.UseParentInformation ||
                    (this.UseParentInformation != null &&
                    this.UseParentInformation.Equals(input.UseParentInformation))
                ) && 
                (
                    this.EnableOnrp == input.EnableOnrp ||
                    (this.EnableOnrp != null &&
                    this.EnableOnrp.Equals(input.EnableOnrp))
                ) && 
                (
                    this.UseChannelDefault == input.UseChannelDefault ||
                    (this.UseChannelDefault != null &&
                    this.UseChannelDefault.Equals(input.UseChannelDefault))
                ) && 
                (
                    this.ContinuousCoverage == input.ContinuousCoverage ||
                    (this.ContinuousCoverage != null &&
                    this.ContinuousCoverage.Equals(input.ContinuousCoverage))
                ) && 
                (
                    this.WeekdayStartTime == input.WeekdayStartTime ||
                    (this.WeekdayStartTime != null &&
                    this.WeekdayStartTime.Equals(input.WeekdayStartTime))
                ) && 
                (
                    this.WeekdayEndTime == input.WeekdayEndTime ||
                    (this.WeekdayEndTime != null &&
                    this.WeekdayEndTime.Equals(input.WeekdayEndTime))
                ) && 
                (
                    this.WeekendHolidayCoverage == input.WeekendHolidayCoverage ||
                    (this.WeekendHolidayCoverage != null &&
                    this.WeekendHolidayCoverage.Equals(input.WeekendHolidayCoverage))
                ) && 
                (
                    this.EnableSunday == input.EnableSunday ||
                    (this.EnableSunday != null &&
                    this.EnableSunday.Equals(input.EnableSunday))
                ) && 
                (
                    this.SundayStartTime == input.SundayStartTime ||
                    (this.SundayStartTime != null &&
                    this.SundayStartTime.Equals(input.SundayStartTime))
                ) && 
                (
                    this.SundayEndTime == input.SundayEndTime ||
                    (this.SundayEndTime != null &&
                    this.SundayEndTime.Equals(input.SundayEndTime))
                ) && 
                (
                    this.EnableSaturday == input.EnableSaturday ||
                    (this.EnableSaturday != null &&
                    this.EnableSaturday.Equals(input.EnableSaturday))
                ) && 
                (
                    this.SaturdayStartTime == input.SaturdayStartTime ||
                    (this.SaturdayStartTime != null &&
                    this.SaturdayStartTime.Equals(input.SaturdayStartTime))
                ) && 
                (
                    this.SaturdayEndTime == input.SaturdayEndTime ||
                    (this.SaturdayEndTime != null &&
                    this.SaturdayEndTime.Equals(input.SaturdayEndTime))
                ) && 
                (
                    this.NoMaximumLimit == input.NoMaximumLimit ||
                    (this.NoMaximumLimit != null &&
                    this.NoMaximumLimit.Equals(input.NoMaximumLimit))
                ) && 
                (
                    this.DollarLimit == input.DollarLimit ||
                    (this.DollarLimit != null &&
                    this.DollarLimit.Equals(input.DollarLimit))
                ) && 
                (
                    this.Tolerance == input.Tolerance ||
                    (this.Tolerance != null &&
                    this.Tolerance.Equals(input.Tolerance))
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
                if (this.UseParentInformation != null)
                    hashCode = hashCode * 59 + this.UseParentInformation.GetHashCode();
                if (this.EnableOnrp != null)
                    hashCode = hashCode * 59 + this.EnableOnrp.GetHashCode();
                if (this.UseChannelDefault != null)
                    hashCode = hashCode * 59 + this.UseChannelDefault.GetHashCode();
                if (this.ContinuousCoverage != null)
                    hashCode = hashCode * 59 + this.ContinuousCoverage.GetHashCode();
                if (this.WeekdayStartTime != null)
                    hashCode = hashCode * 59 + this.WeekdayStartTime.GetHashCode();
                if (this.WeekdayEndTime != null)
                    hashCode = hashCode * 59 + this.WeekdayEndTime.GetHashCode();
                if (this.WeekendHolidayCoverage != null)
                    hashCode = hashCode * 59 + this.WeekendHolidayCoverage.GetHashCode();
                if (this.EnableSunday != null)
                    hashCode = hashCode * 59 + this.EnableSunday.GetHashCode();
                if (this.SundayStartTime != null)
                    hashCode = hashCode * 59 + this.SundayStartTime.GetHashCode();
                if (this.SundayEndTime != null)
                    hashCode = hashCode * 59 + this.SundayEndTime.GetHashCode();
                if (this.EnableSaturday != null)
                    hashCode = hashCode * 59 + this.EnableSaturday.GetHashCode();
                if (this.SaturdayStartTime != null)
                    hashCode = hashCode * 59 + this.SaturdayStartTime.GetHashCode();
                if (this.SaturdayEndTime != null)
                    hashCode = hashCode * 59 + this.SaturdayEndTime.GetHashCode();
                if (this.NoMaximumLimit != null)
                    hashCode = hashCode * 59 + this.NoMaximumLimit.GetHashCode();
                if (this.DollarLimit != null)
                    hashCode = hashCode * 59 + this.DollarLimit.GetHashCode();
                if (this.Tolerance != null)
                    hashCode = hashCode * 59 + this.Tolerance.GetHashCode();
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
