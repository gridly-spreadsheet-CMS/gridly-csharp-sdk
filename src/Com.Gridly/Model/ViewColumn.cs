/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.29.1
 * Contact: support@gridly.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Com.Gridly.Client.OpenAPIDateConverter;

namespace Com.Gridly.Model
{
    /// <summary>
    /// ViewColumn
    /// </summary>
    [DataContract]
    public partial class ViewColumn :  IEquatable<ViewColumn>, IValidatableObject
    {
        /// <summary>
        /// Defines LocalizationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocalizationTypeEnum
        {
            /// <summary>
            /// Enum SourceLanguage for value: sourceLanguage
            /// </summary>
            [EnumMember(Value = "sourceLanguage")]
            SourceLanguage = 1,

            /// <summary>
            /// Enum TargetLanguage for value: targetLanguage
            /// </summary>
            [EnumMember(Value = "targetLanguage")]
            TargetLanguage = 2

        }

        /// <summary>
        /// Gets or Sets LocalizationType
        /// </summary>
        [DataMember(Name="localizationType", EmitDefaultValue=true)]
        public LocalizationTypeEnum? LocalizationType { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SingleLine for value: singleLine
            /// </summary>
            [EnumMember(Value = "singleLine")]
            SingleLine = 1,

            /// <summary>
            /// Enum MultipleLines for value: multipleLines
            /// </summary>
            [EnumMember(Value = "multipleLines")]
            MultipleLines = 2,

            /// <summary>
            /// Enum RichText for value: richText
            /// </summary>
            [EnumMember(Value = "richText")]
            RichText = 3,

            /// <summary>
            /// Enum Markdown for value: markdown
            /// </summary>
            [EnumMember(Value = "markdown")]
            Markdown = 4,

            /// <summary>
            /// Enum SingleSelection for value: singleSelection
            /// </summary>
            [EnumMember(Value = "singleSelection")]
            SingleSelection = 5,

            /// <summary>
            /// Enum MultipleSelections for value: multipleSelections
            /// </summary>
            [EnumMember(Value = "multipleSelections")]
            MultipleSelections = 6,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 7,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 8,

            /// <summary>
            /// Enum Datetime for value: datetime
            /// </summary>
            [EnumMember(Value = "datetime")]
            Datetime = 9,

            /// <summary>
            /// Enum Files for value: files
            /// </summary>
            [EnumMember(Value = "files")]
            Files = 10,

            /// <summary>
            /// Enum Reference for value: reference
            /// </summary>
            [EnumMember(Value = "reference")]
            Reference = 11,

            /// <summary>
            /// Enum Lookup for value: lookup
            /// </summary>
            [EnumMember(Value = "lookup")]
            Lookup = 12,

            /// <summary>
            /// Enum Language for value: language
            /// </summary>
            [EnumMember(Value = "language")]
            Language = 13,

            /// <summary>
            /// Enum Json for value: json
            /// </summary>
            [EnumMember(Value = "json")]
            Json = 14,

            /// <summary>
            /// Enum Yaml for value: yaml
            /// </summary>
            [EnumMember(Value = "yaml")]
            Yaml = 15,

            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")]
            Html = 16,

            /// <summary>
            /// Enum Formula for value: formula
            /// </summary>
            [EnumMember(Value = "formula")]
            Formula = 17

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewColumn" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="dateTimeFormat">dateTimeFormat.</param>
        /// <param name="dependsOn">dependsOn.</param>
        /// <param name="description">description.</param>
        /// <param name="editable">editable.</param>
        /// <param name="formula">formula.</param>
        /// <param name="isSource">isSource.</param>
        /// <param name="isTarget">isTarget.</param>
        /// <param name="languageCode">languageCode.</param>
        /// <param name="localizationType">localizationType.</param>
        /// <param name="name">name.</param>
        /// <param name="numberFormat">numberFormat.</param>
        /// <param name="reference">reference.</param>
        /// <param name="selectionOptions">selectionOptions.</param>
        /// <param name="type">type.</param>
        public ViewColumn(string id = default(string), DateTimeFormat dateTimeFormat = default(DateTimeFormat), string dependsOn = default(string), string description = default(string), bool editable = default(bool), Formula formula = default(Formula), bool isSource = default(bool), bool isTarget = default(bool), string languageCode = default(string), LocalizationTypeEnum? localizationType = default(LocalizationTypeEnum?), string name = default(string), NumberFormat numberFormat = default(NumberFormat), ColumnReference reference = default(ColumnReference), List<string> selectionOptions = default(List<string>), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.DateTimeFormat = dateTimeFormat;
            this.DependsOn = dependsOn;
            this.Description = description;
            this.Editable = editable;
            this.Formula = formula;
            this.IsSource = isSource;
            this.IsTarget = isTarget;
            this.LanguageCode = languageCode;
            this.LocalizationType = localizationType;
            this.Name = name;
            this.NumberFormat = numberFormat;
            this.Reference = reference;
            this.SelectionOptions = selectionOptions;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeFormat
        /// </summary>
        [DataMember(Name="dateTimeFormat", EmitDefaultValue=true)]
        public DateTimeFormat DateTimeFormat { get; set; }

        /// <summary>
        /// Gets or Sets DependsOn
        /// </summary>
        [DataMember(Name="dependsOn", EmitDefaultValue=true)]
        public string DependsOn { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Editable
        /// </summary>
        [DataMember(Name="editable", EmitDefaultValue=true)]
        public bool Editable { get; set; }

        /// <summary>
        /// Gets or Sets Formula
        /// </summary>
        [DataMember(Name="formula", EmitDefaultValue=true)]
        public Formula Formula { get; set; }

        /// <summary>
        /// Gets or Sets IsSource
        /// </summary>
        [DataMember(Name="isSource", EmitDefaultValue=true)]
        public bool IsSource { get; set; }

        /// <summary>
        /// Gets or Sets IsTarget
        /// </summary>
        [DataMember(Name="isTarget", EmitDefaultValue=true)]
        public bool IsTarget { get; set; }

        /// <summary>
        /// Gets or Sets LanguageCode
        /// </summary>
        [DataMember(Name="languageCode", EmitDefaultValue=true)]
        public string LanguageCode { get; set; }


        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NumberFormat
        /// </summary>
        [DataMember(Name="numberFormat", EmitDefaultValue=true)]
        public NumberFormat NumberFormat { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public ColumnReference Reference { get; set; }

        /// <summary>
        /// Gets or Sets SelectionOptions
        /// </summary>
        [DataMember(Name="selectionOptions", EmitDefaultValue=true)]
        public List<string> SelectionOptions { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewColumn {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateTimeFormat: ").Append(DateTimeFormat).Append("\n");
            sb.Append("  DependsOn: ").Append(DependsOn).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  IsSource: ").Append(IsSource).Append("\n");
            sb.Append("  IsTarget: ").Append(IsTarget).Append("\n");
            sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
            sb.Append("  LocalizationType: ").Append(LocalizationType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberFormat: ").Append(NumberFormat).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SelectionOptions: ").Append(SelectionOptions).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ViewColumn);
        }

        /// <summary>
        /// Returns true if ViewColumn instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewColumn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewColumn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DateTimeFormat == input.DateTimeFormat ||
                    (this.DateTimeFormat != null &&
                    this.DateTimeFormat.Equals(input.DateTimeFormat))
                ) && 
                (
                    this.DependsOn == input.DependsOn ||
                    (this.DependsOn != null &&
                    this.DependsOn.Equals(input.DependsOn))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Editable == input.Editable ||
                    (this.Editable != null &&
                    this.Editable.Equals(input.Editable))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.IsSource == input.IsSource ||
                    (this.IsSource != null &&
                    this.IsSource.Equals(input.IsSource))
                ) && 
                (
                    this.IsTarget == input.IsTarget ||
                    (this.IsTarget != null &&
                    this.IsTarget.Equals(input.IsTarget))
                ) && 
                (
                    this.LanguageCode == input.LanguageCode ||
                    (this.LanguageCode != null &&
                    this.LanguageCode.Equals(input.LanguageCode))
                ) && 
                (
                    this.LocalizationType == input.LocalizationType ||
                    (this.LocalizationType != null &&
                    this.LocalizationType.Equals(input.LocalizationType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumberFormat == input.NumberFormat ||
                    (this.NumberFormat != null &&
                    this.NumberFormat.Equals(input.NumberFormat))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SelectionOptions == input.SelectionOptions ||
                    this.SelectionOptions != null &&
                    input.SelectionOptions != null &&
                    this.SelectionOptions.SequenceEqual(input.SelectionOptions)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DateTimeFormat != null)
                    hashCode = hashCode * 59 + this.DateTimeFormat.GetHashCode();
                if (this.DependsOn != null)
                    hashCode = hashCode * 59 + this.DependsOn.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Editable != null)
                    hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.IsSource != null)
                    hashCode = hashCode * 59 + this.IsSource.GetHashCode();
                if (this.IsTarget != null)
                    hashCode = hashCode * 59 + this.IsTarget.GetHashCode();
                if (this.LanguageCode != null)
                    hashCode = hashCode * 59 + this.LanguageCode.GetHashCode();
                if (this.LocalizationType != null)
                    hashCode = hashCode * 59 + this.LocalizationType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberFormat != null)
                    hashCode = hashCode * 59 + this.NumberFormat.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SelectionOptions != null)
                    hashCode = hashCode * 59 + this.SelectionOptions.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
