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
    /// Required when accessorial code COD is present in the accessorial.codes list.  
    /// </summary>
    [DataContract]
        public partial class BOLRequestAccessorialsCodRemitTo :  IEquatable<BOLRequestAccessorialsCodRemitTo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BOLRequestAccessorialsCodRemitTo" /> class.
        /// </summary>
        /// <param name="name">Name of the remit to company..</param>
        /// <param name="address1">Primary Address line of the remit to company..</param>
        /// <param name="address2">Secondary Address of the remit to company..</param>
        /// <param name="city">City Name of the remit to company..</param>
        /// <param name="stateProvince">Two letter state/province code of the remit to company.  Valid Values: See the State_Province_Codes schema at the bottom of this page. .</param>
        /// <param name="postalCode">The 5-digit (or 6-characters for Canada) zip code of the remit to company.  Valid formats: * 12345 (5 digits - USA/MEX) * A1A1A1 (6 characters - CAN) * A1A1A (5 characters - CAN) .</param>
        /// <param name="country">Three letter country code of the remit to company.  Valid Values: See the Country_Codes schema at the bottom of this page. .</param>
        public BOLRequestAccessorialsCodRemitTo(string name = default(string), string address1 = default(string), string address2 = default(string), string city = default(string), string stateProvince = default(string), string postalCode = default(string), string country = default(string))
        {
            this.Name = name;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.StateProvince = stateProvince;
            this.PostalCode = postalCode;
            this.Country = country;
        }
        
        /// <summary>
        /// Name of the remit to company.
        /// </summary>
        /// <value>Name of the remit to company.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Primary Address line of the remit to company.
        /// </summary>
        /// <value>Primary Address line of the remit to company.</value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Secondary Address of the remit to company.
        /// </summary>
        /// <value>Secondary Address of the remit to company.</value>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// City Name of the remit to company.
        /// </summary>
        /// <value>City Name of the remit to company.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Two letter state/province code of the remit to company.  Valid Values: See the State_Province_Codes schema at the bottom of this page. 
        /// </summary>
        /// <value>Two letter state/province code of the remit to company.  Valid Values: See the State_Province_Codes schema at the bottom of this page. </value>
        [DataMember(Name="stateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// The 5-digit (or 6-characters for Canada) zip code of the remit to company.  Valid formats: * 12345 (5 digits - USA/MEX) * A1A1A1 (6 characters - CAN) * A1A1A (5 characters - CAN) 
        /// </summary>
        /// <value>The 5-digit (or 6-characters for Canada) zip code of the remit to company.  Valid formats: * 12345 (5 digits - USA/MEX) * A1A1A1 (6 characters - CAN) * A1A1A (5 characters - CAN) </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Three letter country code of the remit to company.  Valid Values: See the Country_Codes schema at the bottom of this page. 
        /// </summary>
        /// <value>Three letter country code of the remit to company.  Valid Values: See the Country_Codes schema at the bottom of this page. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BOLRequestAccessorialsCodRemitTo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as BOLRequestAccessorialsCodRemitTo);
        }

        /// <summary>
        /// Returns true if BOLRequestAccessorialsCodRemitTo instances are equal
        /// </summary>
        /// <param name="input">Instance of BOLRequestAccessorialsCodRemitTo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BOLRequestAccessorialsCodRemitTo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
