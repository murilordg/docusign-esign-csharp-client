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
    /// LockInformation
    /// </summary>
    [DataContract]
    public partial class LockInformation :  IEquatable<LockInformation>, IValidatableObject
    {
        public LockInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LockInformation" /> class.
        /// </summary>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="LockDurationInSeconds">Sets the time, in seconds, until the lock expires when there is no activity on the envelope.  If no value is entered, then the default value of 300 seconds is used. The maximum value is 1,800 seconds.  The lock duration can be extended. .</param>
        /// <param name="LockedByApp">Specifies the friendly name of  the application that is locking the envelope..</param>
        /// <param name="LockedByUser">A complex type containing information about the user that has the envelope or template locked..</param>
        /// <param name="LockedUntilDateTime">The datetime until the envelope lock expires..</param>
        /// <param name="LockToken">A unique identifier provided to the owner of the envelope lock.   Used to prove ownership of the lock..</param>
        /// <param name="LockType">The type of envelope lock.  Currently \&quot;edit\&quot; is the only supported type..</param>
        /// <param name="UseScratchPad">Reserved for future use.  Indicates whether a scratchpad is used for editing information.  .</param>
        public LockInformation(ErrorDetails ErrorDetails = default(ErrorDetails), string LockDurationInSeconds = default(string), string LockedByApp = default(string), UserInfo LockedByUser = default(UserInfo), string LockedUntilDateTime = default(string), string LockToken = default(string), string LockType = default(string), string UseScratchPad = default(string))
        {
            this.ErrorDetails = ErrorDetails;
            this.LockDurationInSeconds = LockDurationInSeconds;
            this.LockedByApp = LockedByApp;
            this.LockedByUser = LockedByUser;
            this.LockedUntilDateTime = LockedUntilDateTime;
            this.LockToken = LockToken;
            this.LockType = LockType;
            this.UseScratchPad = UseScratchPad;
        }
        
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Sets the time, in seconds, until the lock expires when there is no activity on the envelope.  If no value is entered, then the default value of 300 seconds is used. The maximum value is 1,800 seconds.  The lock duration can be extended. 
        /// </summary>
        /// <value>Sets the time, in seconds, until the lock expires when there is no activity on the envelope.  If no value is entered, then the default value of 300 seconds is used. The maximum value is 1,800 seconds.  The lock duration can be extended. </value>
        [DataMember(Name="lockDurationInSeconds", EmitDefaultValue=false)]
        public string LockDurationInSeconds { get; set; }
        /// <summary>
        /// Specifies the friendly name of  the application that is locking the envelope.
        /// </summary>
        /// <value>Specifies the friendly name of  the application that is locking the envelope.</value>
        [DataMember(Name="lockedByApp", EmitDefaultValue=false)]
        public string LockedByApp { get; set; }
        /// <summary>
        /// A complex type containing information about the user that has the envelope or template locked.
        /// </summary>
        /// <value>A complex type containing information about the user that has the envelope or template locked.</value>
        [DataMember(Name="lockedByUser", EmitDefaultValue=false)]
        public UserInfo LockedByUser { get; set; }
        /// <summary>
        /// The datetime until the envelope lock expires.
        /// </summary>
        /// <value>The datetime until the envelope lock expires.</value>
        [DataMember(Name="lockedUntilDateTime", EmitDefaultValue=false)]
        public string LockedUntilDateTime { get; set; }
        /// <summary>
        /// A unique identifier provided to the owner of the envelope lock.   Used to prove ownership of the lock.
        /// </summary>
        /// <value>A unique identifier provided to the owner of the envelope lock.   Used to prove ownership of the lock.</value>
        [DataMember(Name="lockToken", EmitDefaultValue=false)]
        public string LockToken { get; set; }
        /// <summary>
        /// The type of envelope lock.  Currently \&quot;edit\&quot; is the only supported type.
        /// </summary>
        /// <value>The type of envelope lock.  Currently \&quot;edit\&quot; is the only supported type.</value>
        [DataMember(Name="lockType", EmitDefaultValue=false)]
        public string LockType { get; set; }
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
            sb.Append("class LockInformation {\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  LockDurationInSeconds: ").Append(LockDurationInSeconds).Append("\n");
            sb.Append("  LockedByApp: ").Append(LockedByApp).Append("\n");
            sb.Append("  LockedByUser: ").Append(LockedByUser).Append("\n");
            sb.Append("  LockedUntilDateTime: ").Append(LockedUntilDateTime).Append("\n");
            sb.Append("  LockToken: ").Append(LockToken).Append("\n");
            sb.Append("  LockType: ").Append(LockType).Append("\n");
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
            return this.Equals(obj as LockInformation);
        }

        /// <summary>
        /// Returns true if LockInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of LockInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockInformation other)
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
                    this.LockedByUser == other.LockedByUser ||
                    this.LockedByUser != null &&
                    this.LockedByUser.Equals(other.LockedByUser)
                ) && 
                (
                    this.LockedUntilDateTime == other.LockedUntilDateTime ||
                    this.LockedUntilDateTime != null &&
                    this.LockedUntilDateTime.Equals(other.LockedUntilDateTime)
                ) && 
                (
                    this.LockToken == other.LockToken ||
                    this.LockToken != null &&
                    this.LockToken.Equals(other.LockToken)
                ) && 
                (
                    this.LockType == other.LockType ||
                    this.LockType != null &&
                    this.LockType.Equals(other.LockType)
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
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.LockDurationInSeconds != null)
                    hash = hash * 59 + this.LockDurationInSeconds.GetHashCode();
                if (this.LockedByApp != null)
                    hash = hash * 59 + this.LockedByApp.GetHashCode();
                if (this.LockedByUser != null)
                    hash = hash * 59 + this.LockedByUser.GetHashCode();
                if (this.LockedUntilDateTime != null)
                    hash = hash * 59 + this.LockedUntilDateTime.GetHashCode();
                if (this.LockToken != null)
                    hash = hash * 59 + this.LockToken.GetHashCode();
                if (this.LockType != null)
                    hash = hash * 59 + this.LockType.GetHashCode();
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
