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
    /// The recipient details that are returned after you update the recipient.
    /// </summary>
    [DataContract]
    public partial class RecipientUpdateResponse :  IEquatable<RecipientUpdateResponse>, IValidatableObject
    {
        public RecipientUpdateResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientUpdateResponse" /> class.
        /// </summary>
        /// <param name="Combined">Combined.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="RecipientIdGuid">RecipientIdGuid.</param>
        /// <param name="Tabs">All of the tabs associated with the recipient..</param>
        public RecipientUpdateResponse(string Combined = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string RecipientId = default(string), string RecipientIdGuid = default(string), Tabs Tabs = default(Tabs))
        {
            this.Combined = Combined;
            this.ErrorDetails = ErrorDetails;
            this.RecipientId = RecipientId;
            this.RecipientIdGuid = RecipientIdGuid;
            this.Tabs = Tabs;
        }
        
        /// <summary>
        /// Gets or Sets Combined
        /// </summary>
        [DataMember(Name="combined", EmitDefaultValue=false)]
        public string Combined { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// Gets or Sets RecipientIdGuid
        /// </summary>
        [DataMember(Name="recipientIdGuid", EmitDefaultValue=false)]
        public string RecipientIdGuid { get; set; }
        /// <summary>
        /// All of the tabs associated with the recipient.
        /// </summary>
        /// <value>All of the tabs associated with the recipient.</value>
        [DataMember(Name="tabs", EmitDefaultValue=false)]
        public Tabs Tabs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientUpdateResponse {\n");
            sb.Append("  Combined: ").Append(Combined).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  RecipientIdGuid: ").Append(RecipientIdGuid).Append("\n");
            sb.Append("  Tabs: ").Append(Tabs).Append("\n");
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
            return this.Equals(obj as RecipientUpdateResponse);
        }

        /// <summary>
        /// Returns true if RecipientUpdateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientUpdateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Combined == other.Combined ||
                    this.Combined != null &&
                    this.Combined.Equals(other.Combined)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.RecipientIdGuid == other.RecipientIdGuid ||
                    this.RecipientIdGuid != null &&
                    this.RecipientIdGuid.Equals(other.RecipientIdGuid)
                ) && 
                (
                    this.Tabs == other.Tabs ||
                    this.Tabs != null &&
                    this.Tabs.Equals(other.Tabs)
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
                if (this.Combined != null)
                    hash = hash * 59 + this.Combined.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.RecipientIdGuid != null)
                    hash = hash * 59 + this.RecipientIdGuid.GetHashCode();
                if (this.Tabs != null)
                    hash = hash * 59 + this.Tabs.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
