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
    /// Contains additional information that a specific signature provider requires.
    /// </summary>
    [DataContract]
    public partial class SignatureProviderRequiredOption :  IEquatable<SignatureProviderRequiredOption>, IValidatableObject
    {
        public SignatureProviderRequiredOption()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureProviderRequiredOption" /> class.
        /// </summary>
        /// <param name="RequiredSignatureProviderOptionIds">RequiredSignatureProviderOptionIds.</param>
        /// <param name="SignerType">SignerType.</param>
        public SignatureProviderRequiredOption(List<string> RequiredSignatureProviderOptionIds = default(List<string>), string SignerType = default(string))
        {
            this.RequiredSignatureProviderOptionIds = RequiredSignatureProviderOptionIds;
            this.SignerType = SignerType;
        }
        
        /// <summary>
        /// Gets or Sets RequiredSignatureProviderOptionIds
        /// </summary>
        [DataMember(Name="requiredSignatureProviderOptionIds", EmitDefaultValue=false)]
        public List<string> RequiredSignatureProviderOptionIds { get; set; }
        /// <summary>
        /// Gets or Sets SignerType
        /// </summary>
        [DataMember(Name="signerType", EmitDefaultValue=false)]
        public string SignerType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureProviderRequiredOption {\n");
            sb.Append("  RequiredSignatureProviderOptionIds: ").Append(RequiredSignatureProviderOptionIds).Append("\n");
            sb.Append("  SignerType: ").Append(SignerType).Append("\n");
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
            return this.Equals(obj as SignatureProviderRequiredOption);
        }

        /// <summary>
        /// Returns true if SignatureProviderRequiredOption instances are equal
        /// </summary>
        /// <param name="other">Instance of SignatureProviderRequiredOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureProviderRequiredOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RequiredSignatureProviderOptionIds == other.RequiredSignatureProviderOptionIds ||
                    this.RequiredSignatureProviderOptionIds != null &&
                    this.RequiredSignatureProviderOptionIds.SequenceEqual(other.RequiredSignatureProviderOptionIds)
                ) && 
                (
                    this.SignerType == other.SignerType ||
                    this.SignerType != null &&
                    this.SignerType.Equals(other.SignerType)
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
                if (this.RequiredSignatureProviderOptionIds != null)
                    hash = hash * 59 + this.RequiredSignatureProviderOptionIds.GetHashCode();
                if (this.SignerType != null)
                    hash = hash * 59 + this.SignerType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
