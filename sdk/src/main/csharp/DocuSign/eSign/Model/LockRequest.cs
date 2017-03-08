/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// LockRequest
    /// </summary>
    [DataContract]
    public partial class LockRequest :  IEquatable<LockRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LockRequest" /> class.
        /// </summary>
        /// <param name="LockDurationInSeconds">The number of seconds to lock the envelope for editing.  Must be greater than 0 seconds..</param>
        /// <param name="LockedByApp">A friendly name of the application used to lock the envelope.  Will be used in error messages to the user when lock conflicts occur..</param>
        /// <param name="LockType">The type of envelope lock.  Currently \&quot;edit\&quot; is the only supported type..</param>
        /// <param name="TemplatePassword">.</param>
        /// <param name="UseScratchPad">Reserved for future use.  Indicates whether a scratchpad is used for editing information.  .</param>
        public LockRequest(string LockDurationInSeconds = default(string), string LockedByApp = default(string), string LockType = default(string), string TemplatePassword = default(string), string UseScratchPad = default(string))
        {
            this.LockDurationInSeconds = LockDurationInSeconds;
            this.LockedByApp = LockedByApp;
            this.LockType = LockType;
            this.TemplatePassword = TemplatePassword;
            this.UseScratchPad = UseScratchPad;
        }
        
        /// <summary>
        /// The number of seconds to lock the envelope for editing.  Must be greater than 0 seconds.
        /// </summary>
        /// <value>The number of seconds to lock the envelope for editing.  Must be greater than 0 seconds.</value>
        [DataMember(Name="lockDurationInSeconds", EmitDefaultValue=false)]
        public string LockDurationInSeconds { get; set; }
        /// <summary>
        /// A friendly name of the application used to lock the envelope.  Will be used in error messages to the user when lock conflicts occur.
        /// </summary>
        /// <value>A friendly name of the application used to lock the envelope.  Will be used in error messages to the user when lock conflicts occur.</value>
        [DataMember(Name="lockedByApp", EmitDefaultValue=false)]
        public string LockedByApp { get; set; }
        /// <summary>
        /// The type of envelope lock.  Currently \&quot;edit\&quot; is the only supported type.
        /// </summary>
        /// <value>The type of envelope lock.  Currently \&quot;edit\&quot; is the only supported type.</value>
        [DataMember(Name="lockType", EmitDefaultValue=false)]
        public string LockType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="templatePassword", EmitDefaultValue=false)]
        public string TemplatePassword { get; set; }
        /// <summary>
        /// Reserved for future use.  Indicates whether a scratchpad is used for editing information.  
        /// </summary>
        /// <value>Reserved for future use.  Indicates whether a scratchpad is used for editing information.  </value>
        [DataMember(Name="useScratchPad", EmitDefaultValue=false)]
        public string UseScratchPad { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockRequest {\n");
            sb.Append("  LockDurationInSeconds: ").Append(LockDurationInSeconds).Append("\n");
            sb.Append("  LockedByApp: ").Append(LockedByApp).Append("\n");
            sb.Append("  LockType: ").Append(LockType).Append("\n");
            sb.Append("  TemplatePassword: ").Append(TemplatePassword).Append("\n");
            sb.Append("  UseScratchPad: ").Append(UseScratchPad).Append("\n");
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
            return this.Equals(obj as LockRequest);
        }

        /// <summary>
        /// Returns true if LockRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LockRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LockDurationInSeconds == other.LockDurationInSeconds ||
                    this.LockDurationInSeconds != null &&
                    this.LockDurationInSeconds.Equals(other.LockDurationInSeconds)
                ) && 
                (
                    this.LockedByApp == other.LockedByApp ||
                    this.LockedByApp != null &&
                    this.LockedByApp.Equals(other.LockedByApp)
                ) && 
                (
                    this.LockType == other.LockType ||
                    this.LockType != null &&
                    this.LockType.Equals(other.LockType)
                ) && 
                (
                    this.TemplatePassword == other.TemplatePassword ||
                    this.TemplatePassword != null &&
                    this.TemplatePassword.Equals(other.TemplatePassword)
                ) && 
                (
                    this.UseScratchPad == other.UseScratchPad ||
                    this.UseScratchPad != null &&
                    this.UseScratchPad.Equals(other.UseScratchPad)
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
                if (this.LockDurationInSeconds != null)
                    hash = hash * 59 + this.LockDurationInSeconds.GetHashCode();
                if (this.LockedByApp != null)
                    hash = hash * 59 + this.LockedByApp.GetHashCode();
                if (this.LockType != null)
                    hash = hash * 59 + this.LockType.GetHashCode();
                if (this.TemplatePassword != null)
                    hash = hash * 59 + this.TemplatePassword.GetHashCode();
                if (this.UseScratchPad != null)
                    hash = hash * 59 + this.UseScratchPad.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
