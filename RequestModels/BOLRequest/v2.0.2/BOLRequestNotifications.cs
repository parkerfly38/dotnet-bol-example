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
    /// BOLRequestNotifications
    /// </summary>
    [DataContract]
        public partial class BOLRequestNotifications :  IEquatable<BOLRequestNotifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BOLRequestNotifications" /> class.
        /// </summary>
        /// <param name="phoneNumber">Phone number of contact for updates about shipment movements.</param>
        /// <param name="email">Email address of contact for updates about shipment movements.</param>
        public BOLRequestNotifications(string phoneNumber = default(string), string email = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        
        /// <summary>
        /// Phone number of contact for updates about shipment movements
        /// </summary>
        /// <value>Phone number of contact for updates about shipment movements</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Email address of contact for updates about shipment movements
        /// </summary>
        /// <value>Email address of contact for updates about shipment movements</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BOLRequestNotifications {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as BOLRequestNotifications);
        }

        /// <summary>
        /// Returns true if BOLRequestNotifications instances are equal
        /// </summary>
        /// <param name="input">Instance of BOLRequestNotifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BOLRequestNotifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
