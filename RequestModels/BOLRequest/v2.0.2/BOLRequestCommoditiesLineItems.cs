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
    /// BOLRequestCommoditiesLineItems
    /// </summary>
    [DataContract]
        public partial class BOLRequestCommoditiesLineItems :  IEquatable<BOLRequestCommoditiesLineItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BOLRequestCommoditiesLineItems" /> class.
        /// </summary>
        /// <param name="description">Description of the freight being described. (required).</param>
        /// <param name="weight">Total weight for the specified lineItem. (required).</param>
        /// <param name="weightUnit">The unit of measurement for weight.  Defaults to Pounds (Imperial) if not passed.  Valid Values: Pounds or Kilograms .</param>
        /// <param name="pieces">Number of individual pieces for the line item being described. (required).</param>
        /// <param name="packagingType">Packaging type for the individual pieces of the line item being described.  Valid Values: See the Packaging_Types schema at the bottom of this page  (required).</param>
        /// <param name="classification">Classification of the line item beind described.  Valid Values: See the Classification_Codes schema at the bottom of this page.  (required).</param>
        /// <param name="nmfc">NMFC code of the freight being described..</param>
        /// <param name="nmfcSub">The Sub value for the NMFC of the freight being described..</param>
        /// <param name="hazardous">Identifies whether or not the freight being described contains hazardous materials. (required).</param>
        /// <param name="hazardousDescription">Conditionally required when &#x27;hazardous&#x27; is &#x27;true&#x27;. Provides a detailed description of the hazardous item..</param>
        /// <param name="hazardousDetails">hazardousDetails.</param>
        public BOLRequestCommoditiesLineItems(string description = default(string), int? weight = default(int?), string weightUnit = default(string), int? pieces = default(int?), string packagingType = default(string), string classification = default(string), string nmfc = default(string), string nmfcSub = default(string), bool? hazardous = default(bool?), string hazardousDescription = default(string), BOLRequestCommoditiesHazardousDetails hazardousDetails = default(BOLRequestCommoditiesHazardousDetails))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for BOLRequestCommoditiesLineItems and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for BOLRequestCommoditiesLineItems and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            // to ensure "pieces" is required (not null)
            if (pieces == null)
            {
                throw new InvalidDataException("pieces is a required property for BOLRequestCommoditiesLineItems and cannot be null");
            }
            else
            {
                this.Pieces = pieces;
            }
            // to ensure "packagingType" is required (not null)
            if (packagingType == null)
            {
                throw new InvalidDataException("packagingType is a required property for BOLRequestCommoditiesLineItems and cannot be null");
            }
            else
            {
                this.PackagingType = packagingType;
            }
            // to ensure "classification" is required (not null)
            if (classification == null)
            {
                throw new InvalidDataException("classification is a required property for BOLRequestCommoditiesLineItems and cannot be null");
            }
            else
            {
                this.Classification = classification;
            }
            // to ensure "hazardous" is required (not null)
            if (hazardous == null)
            {
                throw new InvalidDataException("hazardous is a required property for BOLRequestCommoditiesLineItems and cannot be null");
            }
            else
            {
                this.Hazardous = hazardous;
            }
            this.WeightUnit = weightUnit;
            this.Nmfc = nmfc;
            this.NmfcSub = nmfcSub;
            this.HazardousDescription = hazardousDescription;
            this.HazardousDetails = hazardousDetails;
        }
        
        /// <summary>
        /// Description of the freight being described.
        /// </summary>
        /// <value>Description of the freight being described.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Total weight for the specified lineItem.
        /// </summary>
        /// <value>Total weight for the specified lineItem.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public int? Weight { get; set; }

        /// <summary>
        /// The unit of measurement for weight.  Defaults to Pounds (Imperial) if not passed.  Valid Values: Pounds or Kilograms 
        /// </summary>
        /// <value>The unit of measurement for weight.  Defaults to Pounds (Imperial) if not passed.  Valid Values: Pounds or Kilograms </value>
        [DataMember(Name="weightUnit", EmitDefaultValue=false)]
        public string WeightUnit { get; set; }

        /// <summary>
        /// Number of individual pieces for the line item being described.
        /// </summary>
        /// <value>Number of individual pieces for the line item being described.</value>
        [DataMember(Name="pieces", EmitDefaultValue=false)]
        public int? Pieces { get; set; }

        /// <summary>
        /// Packaging type for the individual pieces of the line item being described.  Valid Values: See the Packaging_Types schema at the bottom of this page 
        /// </summary>
        /// <value>Packaging type for the individual pieces of the line item being described.  Valid Values: See the Packaging_Types schema at the bottom of this page </value>
        [DataMember(Name="packagingType", EmitDefaultValue=false)]
        public string PackagingType { get; set; }

        /// <summary>
        /// Classification of the line item beind described.  Valid Values: See the Classification_Codes schema at the bottom of this page. 
        /// </summary>
        /// <value>Classification of the line item beind described.  Valid Values: See the Classification_Codes schema at the bottom of this page. </value>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public string Classification { get; set; }

        /// <summary>
        /// NMFC code of the freight being described.
        /// </summary>
        /// <value>NMFC code of the freight being described.</value>
        [DataMember(Name="nmfc", EmitDefaultValue=false)]
        public string Nmfc { get; set; }

        /// <summary>
        /// The Sub value for the NMFC of the freight being described.
        /// </summary>
        /// <value>The Sub value for the NMFC of the freight being described.</value>
        [DataMember(Name="nmfcSub", EmitDefaultValue=false)]
        public string NmfcSub { get; set; }

        /// <summary>
        /// Identifies whether or not the freight being described contains hazardous materials.
        /// </summary>
        /// <value>Identifies whether or not the freight being described contains hazardous materials.</value>
        [DataMember(Name="hazardous", EmitDefaultValue=false)]
        public bool? Hazardous { get; set; }

        /// <summary>
        /// Conditionally required when &#x27;hazardous&#x27; is &#x27;true&#x27;. Provides a detailed description of the hazardous item.
        /// </summary>
        /// <value>Conditionally required when &#x27;hazardous&#x27; is &#x27;true&#x27;. Provides a detailed description of the hazardous item.</value>
        [DataMember(Name="hazardousDescription", EmitDefaultValue=false)]
        public string HazardousDescription { get; set; }

        /// <summary>
        /// Gets or Sets HazardousDetails
        /// </summary>
        [DataMember(Name="hazardousDetails", EmitDefaultValue=false)]
        public BOLRequestCommoditiesHazardousDetails HazardousDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BOLRequestCommoditiesLineItems {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
            sb.Append("  Pieces: ").Append(Pieces).Append("\n");
            sb.Append("  PackagingType: ").Append(PackagingType).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Nmfc: ").Append(Nmfc).Append("\n");
            sb.Append("  NmfcSub: ").Append(NmfcSub).Append("\n");
            sb.Append("  Hazardous: ").Append(Hazardous).Append("\n");
            sb.Append("  HazardousDescription: ").Append(HazardousDescription).Append("\n");
            sb.Append("  HazardousDetails: ").Append(HazardousDetails).Append("\n");
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
            return this.Equals(input as BOLRequestCommoditiesLineItems);
        }

        /// <summary>
        /// Returns true if BOLRequestCommoditiesLineItems instances are equal
        /// </summary>
        /// <param name="input">Instance of BOLRequestCommoditiesLineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BOLRequestCommoditiesLineItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.WeightUnit == input.WeightUnit ||
                    (this.WeightUnit != null &&
                    this.WeightUnit.Equals(input.WeightUnit))
                ) && 
                (
                    this.Pieces == input.Pieces ||
                    (this.Pieces != null &&
                    this.Pieces.Equals(input.Pieces))
                ) && 
                (
                    this.PackagingType == input.PackagingType ||
                    (this.PackagingType != null &&
                    this.PackagingType.Equals(input.PackagingType))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.Nmfc == input.Nmfc ||
                    (this.Nmfc != null &&
                    this.Nmfc.Equals(input.Nmfc))
                ) && 
                (
                    this.NmfcSub == input.NmfcSub ||
                    (this.NmfcSub != null &&
                    this.NmfcSub.Equals(input.NmfcSub))
                ) && 
                (
                    this.Hazardous == input.Hazardous ||
                    (this.Hazardous != null &&
                    this.Hazardous.Equals(input.Hazardous))
                ) && 
                (
                    this.HazardousDescription == input.HazardousDescription ||
                    (this.HazardousDescription != null &&
                    this.HazardousDescription.Equals(input.HazardousDescription))
                ) && 
                (
                    this.HazardousDetails == input.HazardousDetails ||
                    (this.HazardousDetails != null &&
                    this.HazardousDetails.Equals(input.HazardousDetails))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.WeightUnit != null)
                    hashCode = hashCode * 59 + this.WeightUnit.GetHashCode();
                if (this.Pieces != null)
                    hashCode = hashCode * 59 + this.Pieces.GetHashCode();
                if (this.PackagingType != null)
                    hashCode = hashCode * 59 + this.PackagingType.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.Nmfc != null)
                    hashCode = hashCode * 59 + this.Nmfc.GetHashCode();
                if (this.NmfcSub != null)
                    hashCode = hashCode * 59 + this.NmfcSub.GetHashCode();
                if (this.Hazardous != null)
                    hashCode = hashCode * 59 + this.Hazardous.GetHashCode();
                if (this.HazardousDescription != null)
                    hashCode = hashCode * 59 + this.HazardousDescription.GetHashCode();
                if (this.HazardousDetails != null)
                    hashCode = hashCode * 59 + this.HazardousDetails.GetHashCode();
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
