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
    /// This object provides details about a custom field.
    /// </summary>
    [DataContract]
    public partial class CustomField :  IEquatable<CustomField>, IValidatableObject
    {
        public CustomField()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField" /> class.
        /// </summary>
        /// <param name="CustomFieldType">CustomFieldType.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="FieldId">FieldId.</param>
        /// <param name="ListItems">ListItems.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Required">When set to **true**, the signer is required to fill out this tab.</param>
        /// <param name="Show">Show.</param>
        /// <param name="Value">Specifies the value of the tab. .</param>
        public CustomField(string CustomFieldType = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string FieldId = default(string), List<string> ListItems = default(List<string>), string Name = default(string), string Required = default(string), string Show = default(string), string Value = default(string))
        {
            this.CustomFieldType = CustomFieldType;
            this.ErrorDetails = ErrorDetails;
            this.FieldId = FieldId;
            this.ListItems = ListItems;
            this.Name = Name;
            this.Required = Required;
            this.Show = Show;
            this.Value = Value;
        }
        
        /// <summary>
        /// Gets or Sets CustomFieldType
        /// </summary>
        [DataMember(Name="customFieldType", EmitDefaultValue=false)]
        public string CustomFieldType { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets FieldId
        /// </summary>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }
        /// <summary>
        /// Gets or Sets ListItems
        /// </summary>
        [DataMember(Name="listItems", EmitDefaultValue=false)]
        public List<string> ListItems { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// When set to **true**, the signer is required to fill out this tab
        /// </summary>
        /// <value>When set to **true**, the signer is required to fill out this tab</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public string Required { get; set; }
        /// <summary>
        /// Gets or Sets Show
        /// </summary>
        [DataMember(Name="show", EmitDefaultValue=false)]
        public string Show { get; set; }
        /// <summary>
        /// Specifies the value of the tab. 
        /// </summary>
        /// <value>Specifies the value of the tab. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomField {\n");
            sb.Append("  CustomFieldType: ").Append(CustomFieldType).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  ListItems: ").Append(ListItems).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Show: ").Append(Show).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as CustomField);
        }

        /// <summary>
        /// Returns true if CustomField instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomFieldType == other.CustomFieldType ||
                    this.CustomFieldType != null &&
                    this.CustomFieldType.Equals(other.CustomFieldType)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) && 
                (
                    this.ListItems == other.ListItems ||
                    this.ListItems != null &&
                    this.ListItems.SequenceEqual(other.ListItems)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Show == other.Show ||
                    this.Show != null &&
                    this.Show.Equals(other.Show)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.CustomFieldType != null)
                    hash = hash * 59 + this.CustomFieldType.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                if (this.ListItems != null)
                    hash = hash * 59 + this.ListItems.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Show != null)
                    hash = hash * 59 + this.Show.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
