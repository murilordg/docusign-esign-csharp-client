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
    /// Information about a shared item.
    /// </summary>
    [DataContract]
    public partial class UserSharedItem :  IEquatable<UserSharedItem>, IValidatableObject
    {
        public UserSharedItem()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSharedItem" /> class.
        /// </summary>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Shared">When set to **true**, this custom tab is shared..</param>
        /// <param name="User">The user whose sharing information is being requested..</param>
        public UserSharedItem(ErrorDetails ErrorDetails = default(ErrorDetails), string Shared = default(string), UserInfo User = default(UserInfo))
        {
            this.ErrorDetails = ErrorDetails;
            this.Shared = Shared;
            this.User = User;
        }
        
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// When set to **true**, this custom tab is shared.
        /// </summary>
        /// <value>When set to **true**, this custom tab is shared.</value>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public string Shared { get; set; }
        /// <summary>
        /// The user whose sharing information is being requested.
        /// </summary>
        /// <value>The user whose sharing information is being requested.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserInfo User { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSharedItem {\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as UserSharedItem);
        }

        /// <summary>
        /// Returns true if UserSharedItem instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSharedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSharedItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
