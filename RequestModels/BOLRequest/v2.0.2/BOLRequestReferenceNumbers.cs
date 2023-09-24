/* 
 * Electronic Bill Of Lading Service
 *
 * This document provides an electronic Bill of Lading (eBOL). The eBOL is a legal document that provides a contract between the shipper, carrier and consignee stating what goods are being shipped, where the shipment is coming from and where it’s headed to. “Pro” number is the unique identifier for the document for update and delete functions.
 *
 * OpenAPI spec version: 2.0.2
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
namespace dotnet_example.RequestModels.BOL.v202
{
    /// <summary>
    /// BOLRequestReferenceNumbers
    /// </summary>
    [DataContract]
        public partial class BOLRequestReferenceNumbers :  IEquatable<BOLRequestReferenceNumbers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BOLRequestReferenceNumbers" /> class.
        /// </summary>
        /// <param name="pro">Shipper&#x27;s pre-assigned PRO number for the requested carrier. If one was not provided in the request, one will be auto assigned by the carrier.  The PRO number value should include the check digit when applicable..</param>
        /// <param name="quoteId">Quote (estimate) number provided by the carrier after submitting a rate quote request..</param>
        /// <param name="shipmentId">Shipment Id (SID) number for the shipment..</param>
        /// <param name="masterBol">Master Bill of Lading number for the shipment..</param>
        /// <param name="bol">bol.</param>
        /// <param name="po">po.</param>
        /// <param name="additionalReferences">additionalReferences.</param>
        public BOLRequestReferenceNumbers(string pro = default(string), string quoteId = default(string), string shipmentId = default(string), string masterBol = default(string), List<string> bol = default(List<string>), List<BOLRequestReferenceNumbersPo> po = default(List<BOLRequestReferenceNumbersPo>), List<BOLRequestReferenceNumbersAdditionalReferences> additionalReferences = default(List<BOLRequestReferenceNumbersAdditionalReferences>))
        {
            this.Pro = pro;
            this.QuoteId = quoteId;
            this.ShipmentId = shipmentId;
            this.MasterBol = masterBol;
            this.Bol = bol;
            this.Po = po;
            this.AdditionalReferences = additionalReferences;
        }
        
        /// <summary>
        /// Shipper&#x27;s pre-assigned PRO number for the requested carrier. If one was not provided in the request, one will be auto assigned by the carrier.  The PRO number value should include the check digit when applicable.
        /// </summary>
        /// <value>Shipper&#x27;s pre-assigned PRO number for the requested carrier. If one was not provided in the request, one will be auto assigned by the carrier.  The PRO number value should include the check digit when applicable.</value>
        [DataMember(Name="pro", EmitDefaultValue=false)]
        public string Pro { get; set; }

        /// <summary>
        /// Quote (estimate) number provided by the carrier after submitting a rate quote request.
        /// </summary>
        /// <value>Quote (estimate) number provided by the carrier after submitting a rate quote request.</value>
        [DataMember(Name="quoteId", EmitDefaultValue=false)]
        public string QuoteId { get; set; }

        /// <summary>
        /// Shipment Id (SID) number for the shipment.
        /// </summary>
        /// <value>Shipment Id (SID) number for the shipment.</value>
        [DataMember(Name="shipmentId", EmitDefaultValue=false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Master Bill of Lading number for the shipment.
        /// </summary>
        /// <value>Master Bill of Lading number for the shipment.</value>
        [DataMember(Name="masterBol", EmitDefaultValue=false)]
        public string MasterBol { get; set; }

        /// <summary>
        /// Gets or Sets Bol
        /// </summary>
        [DataMember(Name="bol", EmitDefaultValue=false)]
        public List<string> Bol { get; set; }

        /// <summary>
        /// Gets or Sets Po
        /// </summary>
        [DataMember(Name="po", EmitDefaultValue=false)]
        public List<BOLRequestReferenceNumbersPo> Po { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalReferences
        /// </summary>
        [DataMember(Name="additionalReferences", EmitDefaultValue=false)]
        public List<BOLRequestReferenceNumbersAdditionalReferences> AdditionalReferences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BOLRequestReferenceNumbers {\n");
            sb.Append("  Pro: ").Append(Pro).Append("\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  MasterBol: ").Append(MasterBol).Append("\n");
            sb.Append("  Bol: ").Append(Bol).Append("\n");
            sb.Append("  Po: ").Append(Po).Append("\n");
            sb.Append("  AdditionalReferences: ").Append(AdditionalReferences).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as BOLRequestReferenceNumbers);
        }

        /// <summary>
        /// Returns true if BOLRequestReferenceNumbers instances are equal
        /// </summary>
        /// <param name="input">Instance of BOLRequestReferenceNumbers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BOLRequestReferenceNumbers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pro == input.Pro ||
                    (this.Pro != null &&
                    this.Pro.Equals(input.Pro))
                ) && 
                (
                    this.QuoteId == input.QuoteId ||
                    (this.QuoteId != null &&
                    this.QuoteId.Equals(input.QuoteId))
                ) && 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) && 
                (
                    this.MasterBol == input.MasterBol ||
                    (this.MasterBol != null &&
                    this.MasterBol.Equals(input.MasterBol))
                ) && 
                (
                    this.Bol == input.Bol ||
                    this.Bol != null &&
                    input.Bol != null &&
                    this.Bol.SequenceEqual(input.Bol)
                ) && 
                (
                    this.Po == input.Po ||
                    this.Po != null &&
                    input.Po != null &&
                    this.Po.SequenceEqual(input.Po)
                ) && 
                (
                    this.AdditionalReferences == input.AdditionalReferences ||
                    this.AdditionalReferences != null &&
                    input.AdditionalReferences != null &&
                    this.AdditionalReferences.SequenceEqual(input.AdditionalReferences)
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
                if (this.Pro != null)
                    hashCode = hashCode * 59 + this.Pro.GetHashCode();
                if (this.QuoteId != null)
                    hashCode = hashCode * 59 + this.QuoteId.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.MasterBol != null)
                    hashCode = hashCode * 59 + this.MasterBol.GetHashCode();
                if (this.Bol != null)
                    hashCode = hashCode * 59 + this.Bol.GetHashCode();
                if (this.Po != null)
                    hashCode = hashCode * 59 + this.Po.GetHashCode();
                if (this.AdditionalReferences != null)
                    hashCode = hashCode * 59 + this.AdditionalReferences.GetHashCode();
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