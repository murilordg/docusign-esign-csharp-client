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
    /// The request body for the [EnvelopeViews: createRecipient](/docs/esign-rest-api/reference/envelopes/envelopeviews/createrecipient/) and [EnvelopeViews: createSharedRecipient](/docs/esign-rest-api/reference/envelopes/envelopeviews/createsharedrecipient/) methods.
    /// </summary>
    [DataContract]
    public partial class RecipientViewRequest :  IEquatable<RecipientViewRequest>, IValidatableObject
    {
        public RecipientViewRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientViewRequest" /> class.
        /// </summary>
        /// <param name="AssertionId">A unique identifier of the authentication event executed by the client application..</param>
        /// <param name="AuthenticationInstant">A sender generated value that indicates the date/time that the signer was authenticated..</param>
        /// <param name="AuthenticationMethod">A sender created value that indicates the convention used to authenticate the signer. This information is included in the Certificate of Completion..</param>
        /// <param name="ClientURLs">ClientURLs.</param>
        /// <param name="ClientUserId">A sender created value that shows the recipient is embedded (captive).   Maximum length: 100 characters..</param>
        /// <param name="Email">Specifies the email of the recipient. You can use either email and userName or userId to identify the recipient..</param>
        /// <param name="FrameAncestors">FrameAncestors.</param>
        /// <param name="MessageOrigins">MessageOrigins.</param>
        /// <param name="PingFrequency">Only used if pingUrl is specified. This is the interval, in seconds, between pings on the pingUrl.  The default is 300 seconds. Valid values are 60-1200 seconds..</param>
        /// <param name="PingUrl">A client Url to be pinged by the DocuSign Signing experience to indicate to the client that Signing is active. An HTTP Get is executed against the client. The response from the client is ignored. The intent is for the client to reset it&#39;s session timer when the request is received..</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="ReturnUrl">The url the recipient is redirected to after the signing session has ended. DocuSign redirects to the url and includes an event parameter that can be used by your application. Possible event parameter values:   * cancel (recipient canceled the signing operation) * decline (recipient declined to sign) * exception (an exception occurred) * fax_pending (recipient has a fax pending) * session_timeout (session timed out) * signing_complete (signer completed the signing ceremony) * ttl_expired (the TTL, time to live, timer expired) * viewing_complete (recipient completed viewing the envelope)  ###### Note: Include https:// in the URL or the redirect might not succeed on some browsers. .</param>
        /// <param name="SecurityDomain">The domain in which the user authenticated..</param>
        /// <param name="UserId">Specifies the user ID of the recipient. You can use with user ID or email and user name to identify the recipient. If user ID is used and a client user ID is provided, the value in the &#x60;userId&#x60; property must match a recipient ID (which can be retrieved with a GET recipients call) for the envelope. If a user ID is used and a clientUser ID is not provided, the user ID match the user ID of the authenticating user..</param>
        /// <param name="UserName">Specifies the username of the recipient. You can use either email and userName or userId to identify the recipient..</param>
        /// <param name="XFrameOptions">XFrameOptions.</param>
        /// <param name="XFrameOptionsAllowFromUrl">XFrameOptionsAllowFromUrl.</param>
        public RecipientViewRequest(string AssertionId = default(string), string AuthenticationInstant = default(string), string AuthenticationMethod = default(string), RecipientTokenClientURLs ClientURLs = default(RecipientTokenClientURLs), string ClientUserId = default(string), string Email = default(string), List<string> FrameAncestors = default(List<string>), List<string> MessageOrigins = default(List<string>), string PingFrequency = default(string), string PingUrl = default(string), string RecipientId = default(string), string ReturnUrl = default(string), string SecurityDomain = default(string), string UserId = default(string), string UserName = default(string), string XFrameOptions = default(string), string XFrameOptionsAllowFromUrl = default(string))
        {
            this.AssertionId = AssertionId;
            this.AuthenticationInstant = AuthenticationInstant;
            this.AuthenticationMethod = AuthenticationMethod;
            this.ClientURLs = ClientURLs;
            this.ClientUserId = ClientUserId;
            this.Email = Email;
            this.FrameAncestors = FrameAncestors;
            this.MessageOrigins = MessageOrigins;
            this.PingFrequency = PingFrequency;
            this.PingUrl = PingUrl;
            this.RecipientId = RecipientId;
            this.ReturnUrl = ReturnUrl;
            this.SecurityDomain = SecurityDomain;
            this.UserId = UserId;
            this.UserName = UserName;
            this.XFrameOptions = XFrameOptions;
            this.XFrameOptionsAllowFromUrl = XFrameOptionsAllowFromUrl;
        }
        
        /// <summary>
        /// A unique identifier of the authentication event executed by the client application.
        /// </summary>
        /// <value>A unique identifier of the authentication event executed by the client application.</value>
        [DataMember(Name="assertionId", EmitDefaultValue=false)]
        public string AssertionId { get; set; }
        /// <summary>
        /// A sender generated value that indicates the date/time that the signer was authenticated.
        /// </summary>
        /// <value>A sender generated value that indicates the date/time that the signer was authenticated.</value>
        [DataMember(Name="authenticationInstant", EmitDefaultValue=false)]
        public string AuthenticationInstant { get; set; }
        /// <summary>
        /// A sender created value that indicates the convention used to authenticate the signer. This information is included in the Certificate of Completion.
        /// </summary>
        /// <value>A sender created value that indicates the convention used to authenticate the signer. This information is included in the Certificate of Completion.</value>
        [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
        public string AuthenticationMethod { get; set; }
        /// <summary>
        /// Gets or Sets ClientURLs
        /// </summary>
        [DataMember(Name="clientURLs", EmitDefaultValue=false)]
        public RecipientTokenClientURLs ClientURLs { get; set; }
        /// <summary>
        /// A sender created value that shows the recipient is embedded (captive).   Maximum length: 100 characters.
        /// </summary>
        /// <value>A sender created value that shows the recipient is embedded (captive).   Maximum length: 100 characters.</value>
        [DataMember(Name="clientUserId", EmitDefaultValue=false)]
        public string ClientUserId { get; set; }
        /// <summary>
        /// Specifies the email of the recipient. You can use either email and userName or userId to identify the recipient.
        /// </summary>
        /// <value>Specifies the email of the recipient. You can use either email and userName or userId to identify the recipient.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets FrameAncestors
        /// </summary>
        [DataMember(Name="frameAncestors", EmitDefaultValue=false)]
        public List<string> FrameAncestors { get; set; }
        /// <summary>
        /// Gets or Sets MessageOrigins
        /// </summary>
        [DataMember(Name="messageOrigins", EmitDefaultValue=false)]
        public List<string> MessageOrigins { get; set; }
        /// <summary>
        /// Only used if pingUrl is specified. This is the interval, in seconds, between pings on the pingUrl.  The default is 300 seconds. Valid values are 60-1200 seconds.
        /// </summary>
        /// <value>Only used if pingUrl is specified. This is the interval, in seconds, between pings on the pingUrl.  The default is 300 seconds. Valid values are 60-1200 seconds.</value>
        [DataMember(Name="pingFrequency", EmitDefaultValue=false)]
        public string PingFrequency { get; set; }
        /// <summary>
        /// A client Url to be pinged by the DocuSign Signing experience to indicate to the client that Signing is active. An HTTP Get is executed against the client. The response from the client is ignored. The intent is for the client to reset it&#39;s session timer when the request is received.
        /// </summary>
        /// <value>A client Url to be pinged by the DocuSign Signing experience to indicate to the client that Signing is active. An HTTP Get is executed against the client. The response from the client is ignored. The intent is for the client to reset it&#39;s session timer when the request is received.</value>
        [DataMember(Name="pingUrl", EmitDefaultValue=false)]
        public string PingUrl { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// The url the recipient is redirected to after the signing session has ended. DocuSign redirects to the url and includes an event parameter that can be used by your application. Possible event parameter values:   * cancel (recipient canceled the signing operation) * decline (recipient declined to sign) * exception (an exception occurred) * fax_pending (recipient has a fax pending) * session_timeout (session timed out) * signing_complete (signer completed the signing ceremony) * ttl_expired (the TTL, time to live, timer expired) * viewing_complete (recipient completed viewing the envelope)  ###### Note: Include https:// in the URL or the redirect might not succeed on some browsers. 
        /// </summary>
        /// <value>The url the recipient is redirected to after the signing session has ended. DocuSign redirects to the url and includes an event parameter that can be used by your application. Possible event parameter values:   * cancel (recipient canceled the signing operation) * decline (recipient declined to sign) * exception (an exception occurred) * fax_pending (recipient has a fax pending) * session_timeout (session timed out) * signing_complete (signer completed the signing ceremony) * ttl_expired (the TTL, time to live, timer expired) * viewing_complete (recipient completed viewing the envelope)  ###### Note: Include https:// in the URL or the redirect might not succeed on some browsers. </value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
        /// <summary>
        /// The domain in which the user authenticated.
        /// </summary>
        /// <value>The domain in which the user authenticated.</value>
        [DataMember(Name="securityDomain", EmitDefaultValue=false)]
        public string SecurityDomain { get; set; }
        /// <summary>
        /// Specifies the user ID of the recipient. You can use with user ID or email and user name to identify the recipient. If user ID is used and a client user ID is provided, the value in the &#x60;userId&#x60; property must match a recipient ID (which can be retrieved with a GET recipients call) for the envelope. If a user ID is used and a clientUser ID is not provided, the user ID match the user ID of the authenticating user.
        /// </summary>
        /// <value>Specifies the user ID of the recipient. You can use with user ID or email and user name to identify the recipient. If user ID is used and a client user ID is provided, the value in the &#x60;userId&#x60; property must match a recipient ID (which can be retrieved with a GET recipients call) for the envelope. If a user ID is used and a clientUser ID is not provided, the user ID match the user ID of the authenticating user.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Specifies the username of the recipient. You can use either email and userName or userId to identify the recipient.
        /// </summary>
        /// <value>Specifies the username of the recipient. You can use either email and userName or userId to identify the recipient.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or Sets XFrameOptions
        /// </summary>
        [DataMember(Name="xFrameOptions", EmitDefaultValue=false)]
        public string XFrameOptions { get; set; }
        /// <summary>
        /// Gets or Sets XFrameOptionsAllowFromUrl
        /// </summary>
        [DataMember(Name="xFrameOptionsAllowFromUrl", EmitDefaultValue=false)]
        public string XFrameOptionsAllowFromUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientViewRequest {\n");
            sb.Append("  AssertionId: ").Append(AssertionId).Append("\n");
            sb.Append("  AuthenticationInstant: ").Append(AuthenticationInstant).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  ClientURLs: ").Append(ClientURLs).Append("\n");
            sb.Append("  ClientUserId: ").Append(ClientUserId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FrameAncestors: ").Append(FrameAncestors).Append("\n");
            sb.Append("  MessageOrigins: ").Append(MessageOrigins).Append("\n");
            sb.Append("  PingFrequency: ").Append(PingFrequency).Append("\n");
            sb.Append("  PingUrl: ").Append(PingUrl).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  SecurityDomain: ").Append(SecurityDomain).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  XFrameOptions: ").Append(XFrameOptions).Append("\n");
            sb.Append("  XFrameOptionsAllowFromUrl: ").Append(XFrameOptionsAllowFromUrl).Append("\n");
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
            return this.Equals(obj as RecipientViewRequest);
        }

        /// <summary>
        /// Returns true if RecipientViewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientViewRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssertionId == other.AssertionId ||
                    this.AssertionId != null &&
                    this.AssertionId.Equals(other.AssertionId)
                ) && 
                (
                    this.AuthenticationInstant == other.AuthenticationInstant ||
                    this.AuthenticationInstant != null &&
                    this.AuthenticationInstant.Equals(other.AuthenticationInstant)
                ) && 
                (
                    this.AuthenticationMethod == other.AuthenticationMethod ||
                    this.AuthenticationMethod != null &&
                    this.AuthenticationMethod.Equals(other.AuthenticationMethod)
                ) && 
                (
                    this.ClientURLs == other.ClientURLs ||
                    this.ClientURLs != null &&
                    this.ClientURLs.Equals(other.ClientURLs)
                ) && 
                (
                    this.ClientUserId == other.ClientUserId ||
                    this.ClientUserId != null &&
                    this.ClientUserId.Equals(other.ClientUserId)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FrameAncestors == other.FrameAncestors ||
                    this.FrameAncestors != null &&
                    this.FrameAncestors.SequenceEqual(other.FrameAncestors)
                ) && 
                (
                    this.MessageOrigins == other.MessageOrigins ||
                    this.MessageOrigins != null &&
                    this.MessageOrigins.SequenceEqual(other.MessageOrigins)
                ) && 
                (
                    this.PingFrequency == other.PingFrequency ||
                    this.PingFrequency != null &&
                    this.PingFrequency.Equals(other.PingFrequency)
                ) && 
                (
                    this.PingUrl == other.PingUrl ||
                    this.PingUrl != null &&
                    this.PingUrl.Equals(other.PingUrl)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
                ) && 
                (
                    this.SecurityDomain == other.SecurityDomain ||
                    this.SecurityDomain != null &&
                    this.SecurityDomain.Equals(other.SecurityDomain)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.XFrameOptions == other.XFrameOptions ||
                    this.XFrameOptions != null &&
                    this.XFrameOptions.Equals(other.XFrameOptions)
                ) && 
                (
                    this.XFrameOptionsAllowFromUrl == other.XFrameOptionsAllowFromUrl ||
                    this.XFrameOptionsAllowFromUrl != null &&
                    this.XFrameOptionsAllowFromUrl.Equals(other.XFrameOptionsAllowFromUrl)
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
                if (this.AssertionId != null)
                    hash = hash * 59 + this.AssertionId.GetHashCode();
                if (this.AuthenticationInstant != null)
                    hash = hash * 59 + this.AuthenticationInstant.GetHashCode();
                if (this.AuthenticationMethod != null)
                    hash = hash * 59 + this.AuthenticationMethod.GetHashCode();
                if (this.ClientURLs != null)
                    hash = hash * 59 + this.ClientURLs.GetHashCode();
                if (this.ClientUserId != null)
                    hash = hash * 59 + this.ClientUserId.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.FrameAncestors != null)
                    hash = hash * 59 + this.FrameAncestors.GetHashCode();
                if (this.MessageOrigins != null)
                    hash = hash * 59 + this.MessageOrigins.GetHashCode();
                if (this.PingFrequency != null)
                    hash = hash * 59 + this.PingFrequency.GetHashCode();
                if (this.PingUrl != null)
                    hash = hash * 59 + this.PingUrl.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                if (this.SecurityDomain != null)
                    hash = hash * 59 + this.SecurityDomain.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.XFrameOptions != null)
                    hash = hash * 59 + this.XFrameOptions.GetHashCode();
                if (this.XFrameOptionsAllowFromUrl != null)
                    hash = hash * 59 + this.XFrameOptionsAllowFromUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
