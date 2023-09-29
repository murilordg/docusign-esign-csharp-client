/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Reserved for DocuSign.
    /// </summary>
    [DataContract]
    public partial class AccountSignatureProviderOption :  IEquatable<AccountSignatureProviderOption>, IValidatableObject
    {
        public AccountSignatureProviderOption()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSignatureProviderOption" /> class.
        /// </summary>
        /// <param name="SignatureProviderOptionDisplayName">SignatureProviderOptionDisplayName.</param>
        /// <param name="SignatureProviderOptionId">SignatureProviderOptionId.</param>
        /// <param name="SignatureProviderOptionName">SignatureProviderOptionName.</param>
        public AccountSignatureProviderOption(string SignatureProviderOptionDisplayName = default(string), string SignatureProviderOptionId = default(string), string SignatureProviderOptionName = default(string))
        {
            this.SignatureProviderOptionDisplayName = SignatureProviderOptionDisplayName;
            this.SignatureProviderOptionId = SignatureProviderOptionId;
            this.SignatureProviderOptionName = SignatureProviderOptionName;
        }
        
        /// <summary>
        /// Gets or Sets SignatureProviderOptionDisplayName
        /// </summary>
        [DataMember(Name="signatureProviderOptionDisplayName", EmitDefaultValue=false)]
        public string SignatureProviderOptionDisplayName { get; set; }
        /// <summary>
        /// Gets or Sets SignatureProviderOptionId
        /// </summary>
        [DataMember(Name="signatureProviderOptionId", EmitDefaultValue=false)]
        public string SignatureProviderOptionId { get; set; }
        /// <summary>
        /// Gets or Sets SignatureProviderOptionName
        /// </summary>
        [DataMember(Name="signatureProviderOptionName", EmitDefaultValue=false)]
        public string SignatureProviderOptionName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSignatureProviderOption {\n");
            sb.Append("  SignatureProviderOptionDisplayName: ").Append(SignatureProviderOptionDisplayName).Append("\n");
            sb.Append("  SignatureProviderOptionId: ").Append(SignatureProviderOptionId).Append("\n");
            sb.Append("  SignatureProviderOptionName: ").Append(SignatureProviderOptionName).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AccountSignatureProviderOption);
        }

        /// <summary>
        /// Returns true if AccountSignatureProviderOption instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSignatureProviderOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSignatureProviderOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignatureProviderOptionDisplayName == other.SignatureProviderOptionDisplayName ||
                    this.SignatureProviderOptionDisplayName != null &&
                    this.SignatureProviderOptionDisplayName.Equals(other.SignatureProviderOptionDisplayName)
                ) && 
                (
                    this.SignatureProviderOptionId == other.SignatureProviderOptionId ||
                    this.SignatureProviderOptionId != null &&
                    this.SignatureProviderOptionId.Equals(other.SignatureProviderOptionId)
                ) && 
                (
                    this.SignatureProviderOptionName == other.SignatureProviderOptionName ||
                    this.SignatureProviderOptionName != null &&
                    this.SignatureProviderOptionName.Equals(other.SignatureProviderOptionName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.SignatureProviderOptionDisplayName != null)
                    hash = hash * 59 + this.SignatureProviderOptionDisplayName.GetHashCode();
                if (this.SignatureProviderOptionId != null)
                    hash = hash * 59 + this.SignatureProviderOptionId.GetHashCode();
                if (this.SignatureProviderOptionName != null)
                    hash = hash * 59 + this.SignatureProviderOptionName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
