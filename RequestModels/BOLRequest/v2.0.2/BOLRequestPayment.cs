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
    /// BOLRequestPayment
    /// </summary>
    [DataContract]
        public partial class BOLRequestPayment :  IEquatable<BOLRequestPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BOLRequestPayment" /> class.
        /// </summary>
        /// <param name="terms">Freight Billing Terms for the shipment  Valid Values: See the Payment_Terms schema at the bottom of this page.  (required).</param>
        public BOLRequestPayment(string terms = default(string))
        {
            // to ensure "terms" is required (not null)
            if (terms == null)
            {
                throw new InvalidDataException("terms is a required property for BOLRequestPayment and cannot be null");
            }
            else
            {
                this.Terms = terms;
            }
        }
        
        /// <summary>
        /// Freight Billing Terms for the shipment  Valid Values: See the Payment_Terms schema at the bottom of this page. 
        /// </summary>
        /// <value>Freight Billing Terms for the shipment  Valid Values: See the Payment_Terms schema at the bottom of this page. </value>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public string Terms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BOLRequestPayment {\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(input as BOLRequestPayment);
        }

        /// <summary>
        /// Returns true if BOLRequestPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of BOLRequestPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BOLRequestPayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
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
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
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
