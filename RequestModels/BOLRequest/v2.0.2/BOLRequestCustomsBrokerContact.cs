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
    /// Object containing contact details for the customsBroker. 
    /// </summary>
    [DataContract]
        public partial class BOLRequestCustomsBrokerContact :  IEquatable<BOLRequestCustomsBrokerContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BOLRequestCustomsBrokerContact" /> class.
        /// </summary>
        /// <param name="phone">Ten digit phone number, without country code and/or dashes, for the customsBroker location&#x27;s contact person.  Valid Formats: * ########## (10 digits - Area code + phone)  (required).</param>
        /// <param name="phoneExt">Phone extensionfor the customsBroker location&#x27;s contact person..</param>
        /// <param name="name">Name of the customsBroker location&#x27;s contact person..</param>
        /// <param name="email">Email address of the customsBroker location&#x27;s contact person..</param>
        public BOLRequestCustomsBrokerContact(string phone = default(string), string phoneExt = default(string), string name = default(string), string email = default(string))
        {
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new InvalidDataException("phone is a required property for BOLRequestCustomsBrokerContact and cannot be null");
            }
            else
            {
                this.Phone = phone;
            }
            this.PhoneExt = phoneExt;
            this.Name = name;
            this.Email = email;
        }
        
        /// <summary>
        /// Ten digit phone number, without country code and/or dashes, for the customsBroker location&#x27;s contact person.  Valid Formats: * ########## (10 digits - Area code + phone) 
        /// </summary>
        /// <value>Ten digit phone number, without country code and/or dashes, for the customsBroker location&#x27;s contact person.  Valid Formats: * ########## (10 digits - Area code + phone) </value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Phone extensionfor the customsBroker location&#x27;s contact person.
        /// </summary>
        /// <value>Phone extensionfor the customsBroker location&#x27;s contact person.</value>
        [DataMember(Name="phoneExt", EmitDefaultValue=false)]
        public string PhoneExt { get; set; }

        /// <summary>
        /// Name of the customsBroker location&#x27;s contact person.
        /// </summary>
        /// <value>Name of the customsBroker location&#x27;s contact person.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Email address of the customsBroker location&#x27;s contact person.
        /// </summary>
        /// <value>Email address of the customsBroker location&#x27;s contact person.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BOLRequestCustomsBrokerContact {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneExt: ").Append(PhoneExt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as BOLRequestCustomsBrokerContact);
        }

        /// <summary>
        /// Returns true if BOLRequestCustomsBrokerContact instances are equal
        /// </summary>
        /// <param name="input">Instance of BOLRequestCustomsBrokerContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BOLRequestCustomsBrokerContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneExt == input.PhoneExt ||
                    (this.PhoneExt != null &&
                    this.PhoneExt.Equals(input.PhoneExt))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneExt != null)
                    hashCode = hashCode * 59 + this.PhoneExt.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
