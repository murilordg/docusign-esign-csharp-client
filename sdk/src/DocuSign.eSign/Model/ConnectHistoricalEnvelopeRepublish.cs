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
    /// ConnectHistoricalEnvelopeRepublish
    /// </summary>
    [DataContract]
    public partial class ConnectHistoricalEnvelopeRepublish :  IEquatable<ConnectHistoricalEnvelopeRepublish>, IValidatableObject
    {
        public ConnectHistoricalEnvelopeRepublish()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectHistoricalEnvelopeRepublish" /> class.
        /// </summary>
        /// <param name="Config">Config.</param>
        /// <param name="Envelopes">Envelopes.</param>
        public ConnectHistoricalEnvelopeRepublish(ConnectCustomConfiguration Config = default(ConnectCustomConfiguration), List<string> Envelopes = default(List<string>))
        {
            this.Config = Config;
            this.Envelopes = Envelopes;
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public ConnectCustomConfiguration Config { get; set; }
        /// <summary>
        /// Gets or Sets Envelopes
        /// </summary>
        [DataMember(Name="envelopes", EmitDefaultValue=false)]
        public List<string> Envelopes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectHistoricalEnvelopeRepublish {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Envelopes: ").Append(Envelopes).Append("\n");
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
            return this.Equals(obj as ConnectHistoricalEnvelopeRepublish);
        }

        /// <summary>
        /// Returns true if ConnectHistoricalEnvelopeRepublish instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectHistoricalEnvelopeRepublish to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectHistoricalEnvelopeRepublish other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Config == other.Config ||
                    this.Config != null &&
                    this.Config.Equals(other.Config)
                ) && 
                (
                    this.Envelopes == other.Envelopes ||
                    this.Envelopes != null &&
                    this.Envelopes.SequenceEqual(other.Envelopes)
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
                if (this.Config != null)
                    hash = hash * 59 + this.Config.GetHashCode();
                if (this.Envelopes != null)
                    hash = hash * 59 + this.Envelopes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
