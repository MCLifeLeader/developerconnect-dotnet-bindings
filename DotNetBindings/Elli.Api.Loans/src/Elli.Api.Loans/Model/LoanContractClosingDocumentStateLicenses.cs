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
    /// LoanContractClosingDocumentStateLicenses
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingDocumentStateLicenses :  IEquatable<LoanContractClosingDocumentStateLicenses>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AK
        /// </summary>
        [DataMember(Name="aK", EmitDefaultValue=false)]
        public string AK { get; set; }

        /// <summary>
        /// Gets or Sets AL
        /// </summary>
        [DataMember(Name="aL", EmitDefaultValue=false)]
        public string AL { get; set; }

        /// <summary>
        /// Gets or Sets AR
        /// </summary>
        [DataMember(Name="aR", EmitDefaultValue=false)]
        public string AR { get; set; }

        /// <summary>
        /// Gets or Sets AZ
        /// </summary>
        [DataMember(Name="aZ", EmitDefaultValue=false)]
        public string AZ { get; set; }

        /// <summary>
        /// Gets or Sets CA
        /// </summary>
        [DataMember(Name="cA", EmitDefaultValue=false)]
        public string CA { get; set; }

        /// <summary>
        /// Gets or Sets CO
        /// </summary>
        [DataMember(Name="cO", EmitDefaultValue=false)]
        public string CO { get; set; }

        /// <summary>
        /// Gets or Sets CT
        /// </summary>
        [DataMember(Name="cT", EmitDefaultValue=false)]
        public string CT { get; set; }

        /// <summary>
        /// Gets or Sets DC
        /// </summary>
        [DataMember(Name="dC", EmitDefaultValue=false)]
        public string DC { get; set; }

        /// <summary>
        /// Gets or Sets DE
        /// </summary>
        [DataMember(Name="dE", EmitDefaultValue=false)]
        public string DE { get; set; }

        /// <summary>
        /// Gets or Sets FL
        /// </summary>
        [DataMember(Name="fL", EmitDefaultValue=false)]
        public string FL { get; set; }

        /// <summary>
        /// Gets or Sets GA
        /// </summary>
        [DataMember(Name="gA", EmitDefaultValue=false)]
        public string GA { get; set; }

        /// <summary>
        /// Gets or Sets GU
        /// </summary>
        [DataMember(Name="gU", EmitDefaultValue=false)]
        public string GU { get; set; }

        /// <summary>
        /// Gets or Sets HI
        /// </summary>
        [DataMember(Name="hI", EmitDefaultValue=false)]
        public string HI { get; set; }

        /// <summary>
        /// Gets or Sets IA
        /// </summary>
        [DataMember(Name="iA", EmitDefaultValue=false)]
        public string IA { get; set; }

        /// <summary>
        /// Gets or Sets Idaho
        /// </summary>
        [DataMember(Name="idaho", EmitDefaultValue=false)]
        public string Idaho { get; set; }

        /// <summary>
        /// Gets or Sets IL
        /// </summary>
        [DataMember(Name="iL", EmitDefaultValue=false)]
        public string IL { get; set; }

        /// <summary>
        /// Gets or Sets _IN
        /// </summary>
        [DataMember(Name="iN", EmitDefaultValue=false)]
        public string _IN { get; set; }

        /// <summary>
        /// Gets or Sets KS
        /// </summary>
        [DataMember(Name="kS", EmitDefaultValue=false)]
        public string KS { get; set; }

        /// <summary>
        /// Gets or Sets KY
        /// </summary>
        [DataMember(Name="kY", EmitDefaultValue=false)]
        public string KY { get; set; }

        /// <summary>
        /// Gets or Sets LA
        /// </summary>
        [DataMember(Name="lA", EmitDefaultValue=false)]
        public string LA { get; set; }

        /// <summary>
        /// Gets or Sets MA
        /// </summary>
        [DataMember(Name="mA", EmitDefaultValue=false)]
        public string MA { get; set; }

        /// <summary>
        /// Gets or Sets MD
        /// </summary>
        [DataMember(Name="mD", EmitDefaultValue=false)]
        public string MD { get; set; }

        /// <summary>
        /// Gets or Sets ME
        /// </summary>
        [DataMember(Name="mE", EmitDefaultValue=false)]
        public string ME { get; set; }

        /// <summary>
        /// Gets or Sets MI
        /// </summary>
        [DataMember(Name="mI", EmitDefaultValue=false)]
        public string MI { get; set; }

        /// <summary>
        /// Gets or Sets MN
        /// </summary>
        [DataMember(Name="mN", EmitDefaultValue=false)]
        public string MN { get; set; }

        /// <summary>
        /// Gets or Sets MO
        /// </summary>
        [DataMember(Name="mO", EmitDefaultValue=false)]
        public string MO { get; set; }

        /// <summary>
        /// Gets or Sets MS
        /// </summary>
        [DataMember(Name="mS", EmitDefaultValue=false)]
        public string MS { get; set; }

        /// <summary>
        /// Gets or Sets MT
        /// </summary>
        [DataMember(Name="mT", EmitDefaultValue=false)]
        public string MT { get; set; }

        /// <summary>
        /// Gets or Sets NC
        /// </summary>
        [DataMember(Name="nC", EmitDefaultValue=false)]
        public string NC { get; set; }

        /// <summary>
        /// Gets or Sets ND
        /// </summary>
        [DataMember(Name="nD", EmitDefaultValue=false)]
        public string ND { get; set; }

        /// <summary>
        /// Gets or Sets NE
        /// </summary>
        [DataMember(Name="nE", EmitDefaultValue=false)]
        public string NE { get; set; }

        /// <summary>
        /// Gets or Sets NH
        /// </summary>
        [DataMember(Name="nH", EmitDefaultValue=false)]
        public string NH { get; set; }

        /// <summary>
        /// Gets or Sets NJ
        /// </summary>
        [DataMember(Name="nJ", EmitDefaultValue=false)]
        public string NJ { get; set; }

        /// <summary>
        /// Gets or Sets NM
        /// </summary>
        [DataMember(Name="nM", EmitDefaultValue=false)]
        public string NM { get; set; }

        /// <summary>
        /// Gets or Sets NV
        /// </summary>
        [DataMember(Name="nV", EmitDefaultValue=false)]
        public string NV { get; set; }

        /// <summary>
        /// Gets or Sets NY
        /// </summary>
        [DataMember(Name="nY", EmitDefaultValue=false)]
        public string NY { get; set; }

        /// <summary>
        /// Gets or Sets OH
        /// </summary>
        [DataMember(Name="oH", EmitDefaultValue=false)]
        public string OH { get; set; }

        /// <summary>
        /// Gets or Sets OK
        /// </summary>
        [DataMember(Name="oK", EmitDefaultValue=false)]
        public string OK { get; set; }

        /// <summary>
        /// Gets or Sets OR
        /// </summary>
        [DataMember(Name="oR", EmitDefaultValue=false)]
        public string OR { get; set; }

        /// <summary>
        /// Gets or Sets PA
        /// </summary>
        [DataMember(Name="pA", EmitDefaultValue=false)]
        public string PA { get; set; }

        /// <summary>
        /// Gets or Sets PR
        /// </summary>
        [DataMember(Name="pR", EmitDefaultValue=false)]
        public string PR { get; set; }

        /// <summary>
        /// Gets or Sets RI
        /// </summary>
        [DataMember(Name="rI", EmitDefaultValue=false)]
        public string RI { get; set; }

        /// <summary>
        /// Gets or Sets SC
        /// </summary>
        [DataMember(Name="sC", EmitDefaultValue=false)]
        public string SC { get; set; }

        /// <summary>
        /// Gets or Sets SD
        /// </summary>
        [DataMember(Name="sD", EmitDefaultValue=false)]
        public string SD { get; set; }

        /// <summary>
        /// Gets or Sets StateLicenseType
        /// </summary>
        [DataMember(Name="stateLicenseType", EmitDefaultValue=false)]
        public string StateLicenseType { get; set; }

        /// <summary>
        /// Gets or Sets TN
        /// </summary>
        [DataMember(Name="tN", EmitDefaultValue=false)]
        public string TN { get; set; }

        /// <summary>
        /// Gets or Sets TX
        /// </summary>
        [DataMember(Name="tX", EmitDefaultValue=false)]
        public string TX { get; set; }

        /// <summary>
        /// Gets or Sets UT
        /// </summary>
        [DataMember(Name="uT", EmitDefaultValue=false)]
        public string UT { get; set; }

        /// <summary>
        /// Gets or Sets VA
        /// </summary>
        [DataMember(Name="vA", EmitDefaultValue=false)]
        public string VA { get; set; }

        /// <summary>
        /// Gets or Sets VI
        /// </summary>
        [DataMember(Name="vI", EmitDefaultValue=false)]
        public string VI { get; set; }

        /// <summary>
        /// Gets or Sets VT
        /// </summary>
        [DataMember(Name="vT", EmitDefaultValue=false)]
        public string VT { get; set; }

        /// <summary>
        /// Gets or Sets WA
        /// </summary>
        [DataMember(Name="wA", EmitDefaultValue=false)]
        public string WA { get; set; }

        /// <summary>
        /// Gets or Sets WI
        /// </summary>
        [DataMember(Name="wI", EmitDefaultValue=false)]
        public string WI { get; set; }

        /// <summary>
        /// Gets or Sets WV
        /// </summary>
        [DataMember(Name="wV", EmitDefaultValue=false)]
        public string WV { get; set; }

        /// <summary>
        /// Gets or Sets WY
        /// </summary>
        [DataMember(Name="wY", EmitDefaultValue=false)]
        public string WY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingDocumentStateLicenses {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AK: ").Append(AK).Append("\n");
            sb.Append("  AL: ").Append(AL).Append("\n");
            sb.Append("  AR: ").Append(AR).Append("\n");
            sb.Append("  AZ: ").Append(AZ).Append("\n");
            sb.Append("  CA: ").Append(CA).Append("\n");
            sb.Append("  CO: ").Append(CO).Append("\n");
            sb.Append("  CT: ").Append(CT).Append("\n");
            sb.Append("  DC: ").Append(DC).Append("\n");
            sb.Append("  DE: ").Append(DE).Append("\n");
            sb.Append("  FL: ").Append(FL).Append("\n");
            sb.Append("  GA: ").Append(GA).Append("\n");
            sb.Append("  GU: ").Append(GU).Append("\n");
            sb.Append("  HI: ").Append(HI).Append("\n");
            sb.Append("  IA: ").Append(IA).Append("\n");
            sb.Append("  Idaho: ").Append(Idaho).Append("\n");
            sb.Append("  IL: ").Append(IL).Append("\n");
            sb.Append("  _IN: ").Append(_IN).Append("\n");
            sb.Append("  KS: ").Append(KS).Append("\n");
            sb.Append("  KY: ").Append(KY).Append("\n");
            sb.Append("  LA: ").Append(LA).Append("\n");
            sb.Append("  MA: ").Append(MA).Append("\n");
            sb.Append("  MD: ").Append(MD).Append("\n");
            sb.Append("  ME: ").Append(ME).Append("\n");
            sb.Append("  MI: ").Append(MI).Append("\n");
            sb.Append("  MN: ").Append(MN).Append("\n");
            sb.Append("  MO: ").Append(MO).Append("\n");
            sb.Append("  MS: ").Append(MS).Append("\n");
            sb.Append("  MT: ").Append(MT).Append("\n");
            sb.Append("  NC: ").Append(NC).Append("\n");
            sb.Append("  ND: ").Append(ND).Append("\n");
            sb.Append("  NE: ").Append(NE).Append("\n");
            sb.Append("  NH: ").Append(NH).Append("\n");
            sb.Append("  NJ: ").Append(NJ).Append("\n");
            sb.Append("  NM: ").Append(NM).Append("\n");
            sb.Append("  NV: ").Append(NV).Append("\n");
            sb.Append("  NY: ").Append(NY).Append("\n");
            sb.Append("  OH: ").Append(OH).Append("\n");
            sb.Append("  OK: ").Append(OK).Append("\n");
            sb.Append("  OR: ").Append(OR).Append("\n");
            sb.Append("  PA: ").Append(PA).Append("\n");
            sb.Append("  PR: ").Append(PR).Append("\n");
            sb.Append("  RI: ").Append(RI).Append("\n");
            sb.Append("  SC: ").Append(SC).Append("\n");
            sb.Append("  SD: ").Append(SD).Append("\n");
            sb.Append("  StateLicenseType: ").Append(StateLicenseType).Append("\n");
            sb.Append("  TN: ").Append(TN).Append("\n");
            sb.Append("  TX: ").Append(TX).Append("\n");
            sb.Append("  UT: ").Append(UT).Append("\n");
            sb.Append("  VA: ").Append(VA).Append("\n");
            sb.Append("  VI: ").Append(VI).Append("\n");
            sb.Append("  VT: ").Append(VT).Append("\n");
            sb.Append("  WA: ").Append(WA).Append("\n");
            sb.Append("  WI: ").Append(WI).Append("\n");
            sb.Append("  WV: ").Append(WV).Append("\n");
            sb.Append("  WY: ").Append(WY).Append("\n");
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
            return this.Equals(input as LoanContractClosingDocumentStateLicenses);
        }

        /// <summary>
        /// Returns true if LoanContractClosingDocumentStateLicenses instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingDocumentStateLicenses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingDocumentStateLicenses input)
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
                    this.AK == input.AK ||
                    (this.AK != null &&
                    this.AK.Equals(input.AK))
                ) && 
                (
                    this.AL == input.AL ||
                    (this.AL != null &&
                    this.AL.Equals(input.AL))
                ) && 
                (
                    this.AR == input.AR ||
                    (this.AR != null &&
                    this.AR.Equals(input.AR))
                ) && 
                (
                    this.AZ == input.AZ ||
                    (this.AZ != null &&
                    this.AZ.Equals(input.AZ))
                ) && 
                (
                    this.CA == input.CA ||
                    (this.CA != null &&
                    this.CA.Equals(input.CA))
                ) && 
                (
                    this.CO == input.CO ||
                    (this.CO != null &&
                    this.CO.Equals(input.CO))
                ) && 
                (
                    this.CT == input.CT ||
                    (this.CT != null &&
                    this.CT.Equals(input.CT))
                ) && 
                (
                    this.DC == input.DC ||
                    (this.DC != null &&
                    this.DC.Equals(input.DC))
                ) && 
                (
                    this.DE == input.DE ||
                    (this.DE != null &&
                    this.DE.Equals(input.DE))
                ) && 
                (
                    this.FL == input.FL ||
                    (this.FL != null &&
                    this.FL.Equals(input.FL))
                ) && 
                (
                    this.GA == input.GA ||
                    (this.GA != null &&
                    this.GA.Equals(input.GA))
                ) && 
                (
                    this.GU == input.GU ||
                    (this.GU != null &&
                    this.GU.Equals(input.GU))
                ) && 
                (
                    this.HI == input.HI ||
                    (this.HI != null &&
                    this.HI.Equals(input.HI))
                ) && 
                (
                    this.IA == input.IA ||
                    (this.IA != null &&
                    this.IA.Equals(input.IA))
                ) && 
                (
                    this.Idaho == input.Idaho ||
                    (this.Idaho != null &&
                    this.Idaho.Equals(input.Idaho))
                ) && 
                (
                    this.IL == input.IL ||
                    (this.IL != null &&
                    this.IL.Equals(input.IL))
                ) && 
                (
                    this._IN == input._IN ||
                    (this._IN != null &&
                    this._IN.Equals(input._IN))
                ) && 
                (
                    this.KS == input.KS ||
                    (this.KS != null &&
                    this.KS.Equals(input.KS))
                ) && 
                (
                    this.KY == input.KY ||
                    (this.KY != null &&
                    this.KY.Equals(input.KY))
                ) && 
                (
                    this.LA == input.LA ||
                    (this.LA != null &&
                    this.LA.Equals(input.LA))
                ) && 
                (
                    this.MA == input.MA ||
                    (this.MA != null &&
                    this.MA.Equals(input.MA))
                ) && 
                (
                    this.MD == input.MD ||
                    (this.MD != null &&
                    this.MD.Equals(input.MD))
                ) && 
                (
                    this.ME == input.ME ||
                    (this.ME != null &&
                    this.ME.Equals(input.ME))
                ) && 
                (
                    this.MI == input.MI ||
                    (this.MI != null &&
                    this.MI.Equals(input.MI))
                ) && 
                (
                    this.MN == input.MN ||
                    (this.MN != null &&
                    this.MN.Equals(input.MN))
                ) && 
                (
                    this.MO == input.MO ||
                    (this.MO != null &&
                    this.MO.Equals(input.MO))
                ) && 
                (
                    this.MS == input.MS ||
                    (this.MS != null &&
                    this.MS.Equals(input.MS))
                ) && 
                (
                    this.MT == input.MT ||
                    (this.MT != null &&
                    this.MT.Equals(input.MT))
                ) && 
                (
                    this.NC == input.NC ||
                    (this.NC != null &&
                    this.NC.Equals(input.NC))
                ) && 
                (
                    this.ND == input.ND ||
                    (this.ND != null &&
                    this.ND.Equals(input.ND))
                ) && 
                (
                    this.NE == input.NE ||
                    (this.NE != null &&
                    this.NE.Equals(input.NE))
                ) && 
                (
                    this.NH == input.NH ||
                    (this.NH != null &&
                    this.NH.Equals(input.NH))
                ) && 
                (
                    this.NJ == input.NJ ||
                    (this.NJ != null &&
                    this.NJ.Equals(input.NJ))
                ) && 
                (
                    this.NM == input.NM ||
                    (this.NM != null &&
                    this.NM.Equals(input.NM))
                ) && 
                (
                    this.NV == input.NV ||
                    (this.NV != null &&
                    this.NV.Equals(input.NV))
                ) && 
                (
                    this.NY == input.NY ||
                    (this.NY != null &&
                    this.NY.Equals(input.NY))
                ) && 
                (
                    this.OH == input.OH ||
                    (this.OH != null &&
                    this.OH.Equals(input.OH))
                ) && 
                (
                    this.OK == input.OK ||
                    (this.OK != null &&
                    this.OK.Equals(input.OK))
                ) && 
                (
                    this.OR == input.OR ||
                    (this.OR != null &&
                    this.OR.Equals(input.OR))
                ) && 
                (
                    this.PA == input.PA ||
                    (this.PA != null &&
                    this.PA.Equals(input.PA))
                ) && 
                (
                    this.PR == input.PR ||
                    (this.PR != null &&
                    this.PR.Equals(input.PR))
                ) && 
                (
                    this.RI == input.RI ||
                    (this.RI != null &&
                    this.RI.Equals(input.RI))
                ) && 
                (
                    this.SC == input.SC ||
                    (this.SC != null &&
                    this.SC.Equals(input.SC))
                ) && 
                (
                    this.SD == input.SD ||
                    (this.SD != null &&
                    this.SD.Equals(input.SD))
                ) && 
                (
                    this.StateLicenseType == input.StateLicenseType ||
                    (this.StateLicenseType != null &&
                    this.StateLicenseType.Equals(input.StateLicenseType))
                ) && 
                (
                    this.TN == input.TN ||
                    (this.TN != null &&
                    this.TN.Equals(input.TN))
                ) && 
                (
                    this.TX == input.TX ||
                    (this.TX != null &&
                    this.TX.Equals(input.TX))
                ) && 
                (
                    this.UT == input.UT ||
                    (this.UT != null &&
                    this.UT.Equals(input.UT))
                ) && 
                (
                    this.VA == input.VA ||
                    (this.VA != null &&
                    this.VA.Equals(input.VA))
                ) && 
                (
                    this.VI == input.VI ||
                    (this.VI != null &&
                    this.VI.Equals(input.VI))
                ) && 
                (
                    this.VT == input.VT ||
                    (this.VT != null &&
                    this.VT.Equals(input.VT))
                ) && 
                (
                    this.WA == input.WA ||
                    (this.WA != null &&
                    this.WA.Equals(input.WA))
                ) && 
                (
                    this.WI == input.WI ||
                    (this.WI != null &&
                    this.WI.Equals(input.WI))
                ) && 
                (
                    this.WV == input.WV ||
                    (this.WV != null &&
                    this.WV.Equals(input.WV))
                ) && 
                (
                    this.WY == input.WY ||
                    (this.WY != null &&
                    this.WY.Equals(input.WY))
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
                if (this.AK != null)
                    hashCode = hashCode * 59 + this.AK.GetHashCode();
                if (this.AL != null)
                    hashCode = hashCode * 59 + this.AL.GetHashCode();
                if (this.AR != null)
                    hashCode = hashCode * 59 + this.AR.GetHashCode();
                if (this.AZ != null)
                    hashCode = hashCode * 59 + this.AZ.GetHashCode();
                if (this.CA != null)
                    hashCode = hashCode * 59 + this.CA.GetHashCode();
                if (this.CO != null)
                    hashCode = hashCode * 59 + this.CO.GetHashCode();
                if (this.CT != null)
                    hashCode = hashCode * 59 + this.CT.GetHashCode();
                if (this.DC != null)
                    hashCode = hashCode * 59 + this.DC.GetHashCode();
                if (this.DE != null)
                    hashCode = hashCode * 59 + this.DE.GetHashCode();
                if (this.FL != null)
                    hashCode = hashCode * 59 + this.FL.GetHashCode();
                if (this.GA != null)
                    hashCode = hashCode * 59 + this.GA.GetHashCode();
                if (this.GU != null)
                    hashCode = hashCode * 59 + this.GU.GetHashCode();
                if (this.HI != null)
                    hashCode = hashCode * 59 + this.HI.GetHashCode();
                if (this.IA != null)
                    hashCode = hashCode * 59 + this.IA.GetHashCode();
                if (this.Idaho != null)
                    hashCode = hashCode * 59 + this.Idaho.GetHashCode();
                if (this.IL != null)
                    hashCode = hashCode * 59 + this.IL.GetHashCode();
                if (this._IN != null)
                    hashCode = hashCode * 59 + this._IN.GetHashCode();
                if (this.KS != null)
                    hashCode = hashCode * 59 + this.KS.GetHashCode();
                if (this.KY != null)
                    hashCode = hashCode * 59 + this.KY.GetHashCode();
                if (this.LA != null)
                    hashCode = hashCode * 59 + this.LA.GetHashCode();
                if (this.MA != null)
                    hashCode = hashCode * 59 + this.MA.GetHashCode();
                if (this.MD != null)
                    hashCode = hashCode * 59 + this.MD.GetHashCode();
                if (this.ME != null)
                    hashCode = hashCode * 59 + this.ME.GetHashCode();
                if (this.MI != null)
                    hashCode = hashCode * 59 + this.MI.GetHashCode();
                if (this.MN != null)
                    hashCode = hashCode * 59 + this.MN.GetHashCode();
                if (this.MO != null)
                    hashCode = hashCode * 59 + this.MO.GetHashCode();
                if (this.MS != null)
                    hashCode = hashCode * 59 + this.MS.GetHashCode();
                if (this.MT != null)
                    hashCode = hashCode * 59 + this.MT.GetHashCode();
                if (this.NC != null)
                    hashCode = hashCode * 59 + this.NC.GetHashCode();
                if (this.ND != null)
                    hashCode = hashCode * 59 + this.ND.GetHashCode();
                if (this.NE != null)
                    hashCode = hashCode * 59 + this.NE.GetHashCode();
                if (this.NH != null)
                    hashCode = hashCode * 59 + this.NH.GetHashCode();
                if (this.NJ != null)
                    hashCode = hashCode * 59 + this.NJ.GetHashCode();
                if (this.NM != null)
                    hashCode = hashCode * 59 + this.NM.GetHashCode();
                if (this.NV != null)
                    hashCode = hashCode * 59 + this.NV.GetHashCode();
                if (this.NY != null)
                    hashCode = hashCode * 59 + this.NY.GetHashCode();
                if (this.OH != null)
                    hashCode = hashCode * 59 + this.OH.GetHashCode();
                if (this.OK != null)
                    hashCode = hashCode * 59 + this.OK.GetHashCode();
                if (this.OR != null)
                    hashCode = hashCode * 59 + this.OR.GetHashCode();
                if (this.PA != null)
                    hashCode = hashCode * 59 + this.PA.GetHashCode();
                if (this.PR != null)
                    hashCode = hashCode * 59 + this.PR.GetHashCode();
                if (this.RI != null)
                    hashCode = hashCode * 59 + this.RI.GetHashCode();
                if (this.SC != null)
                    hashCode = hashCode * 59 + this.SC.GetHashCode();
                if (this.SD != null)
                    hashCode = hashCode * 59 + this.SD.GetHashCode();
                if (this.StateLicenseType != null)
                    hashCode = hashCode * 59 + this.StateLicenseType.GetHashCode();
                if (this.TN != null)
                    hashCode = hashCode * 59 + this.TN.GetHashCode();
                if (this.TX != null)
                    hashCode = hashCode * 59 + this.TX.GetHashCode();
                if (this.UT != null)
                    hashCode = hashCode * 59 + this.UT.GetHashCode();
                if (this.VA != null)
                    hashCode = hashCode * 59 + this.VA.GetHashCode();
                if (this.VI != null)
                    hashCode = hashCode * 59 + this.VI.GetHashCode();
                if (this.VT != null)
                    hashCode = hashCode * 59 + this.VT.GetHashCode();
                if (this.WA != null)
                    hashCode = hashCode * 59 + this.WA.GetHashCode();
                if (this.WI != null)
                    hashCode = hashCode * 59 + this.WI.GetHashCode();
                if (this.WV != null)
                    hashCode = hashCode * 59 + this.WV.GetHashCode();
                if (this.WY != null)
                    hashCode = hashCode * 59 + this.WY.GetHashCode();
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
