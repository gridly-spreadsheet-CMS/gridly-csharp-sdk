/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.33.0
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
    /// Formula
    /// </summary>
    [DataContract]
    public partial class Formula :  IEquatable<Formula>, IValidatableObject
    {
        /// <summary>
        /// Defines DetectResultValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DetectResultValueTypeEnum
        {
            /// <summary>
            /// Enum List for value: list
            /// </summary>
            [EnumMember(Value = "list")]
            List = 1,

            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 2,

            /// <summary>
            /// Enum Decimal for value: decimal
            /// </summary>
            [EnumMember(Value = "decimal")]
            Decimal = 3,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 4,

            /// <summary>
            /// Enum Datetime for value: datetime
            /// </summary>
            [EnumMember(Value = "datetime")]
            Datetime = 5,

            /// <summary>
            /// Enum Na for value: na
            /// </summary>
            [EnumMember(Value = "na")]
            Na = 6

        }

        /// <summary>
        /// Gets or Sets DetectResultValueType
        /// </summary>
        [DataMember(Name="detectResultValueType", EmitDefaultValue=true)]
        public DetectResultValueTypeEnum? DetectResultValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Formula" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Formula() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Formula" /> class.
        /// </summary>
        /// <param name="formulaText">formulaText (required).</param>
        /// <param name="alwaysFormatResultValueAsList">alwaysFormatResultValueAsList.</param>
        /// <param name="detectResultValueType">detectResultValueType.</param>
        public Formula(string formulaText = default(string), bool alwaysFormatResultValueAsList = default(bool), DetectResultValueTypeEnum? detectResultValueType = default(DetectResultValueTypeEnum?))
        {
            // to ensure "formulaText" is required (not null)
            if (formulaText == null)
            {
                throw new InvalidDataException("formulaText is a required property for Formula and cannot be null");
            }
            else
            {
                this.FormulaText = formulaText;
            }

            this.AlwaysFormatResultValueAsList = alwaysFormatResultValueAsList;
            this.DetectResultValueType = detectResultValueType;
        }

        /// <summary>
        /// Gets or Sets FormulaText
        /// </summary>
        [DataMember(Name="formulaText", EmitDefaultValue=true)]
        public string FormulaText { get; set; }

        /// <summary>
        /// Gets or Sets AlwaysFormatResultValueAsList
        /// </summary>
        [DataMember(Name="alwaysFormatResultValueAsList", EmitDefaultValue=true)]
        public bool AlwaysFormatResultValueAsList { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Formula {\n");
            sb.Append("  FormulaText: ").Append(FormulaText).Append("\n");
            sb.Append("  AlwaysFormatResultValueAsList: ").Append(AlwaysFormatResultValueAsList).Append("\n");
            sb.Append("  DetectResultValueType: ").Append(DetectResultValueType).Append("\n");
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
            return this.Equals(input as Formula);
        }

        /// <summary>
        /// Returns true if Formula instances are equal
        /// </summary>
        /// <param name="input">Instance of Formula to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Formula input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FormulaText == input.FormulaText ||
                    (this.FormulaText != null &&
                    this.FormulaText.Equals(input.FormulaText))
                ) && 
                (
                    this.AlwaysFormatResultValueAsList == input.AlwaysFormatResultValueAsList ||
                    (this.AlwaysFormatResultValueAsList != null &&
                    this.AlwaysFormatResultValueAsList.Equals(input.AlwaysFormatResultValueAsList))
                ) && 
                (
                    this.DetectResultValueType == input.DetectResultValueType ||
                    (this.DetectResultValueType != null &&
                    this.DetectResultValueType.Equals(input.DetectResultValueType))
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
                if (this.FormulaText != null)
                    hashCode = hashCode * 59 + this.FormulaText.GetHashCode();
                if (this.AlwaysFormatResultValueAsList != null)
                    hashCode = hashCode * 59 + this.AlwaysFormatResultValueAsList.GetHashCode();
                if (this.DetectResultValueType != null)
                    hashCode = hashCode * 59 + this.DetectResultValueType.GetHashCode();
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
