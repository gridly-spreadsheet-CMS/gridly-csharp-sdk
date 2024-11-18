/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 5.9.0
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
    /// MergeCellConflict
    /// </summary>
    [DataContract]
    public partial class MergeCellConflict :  IEquatable<MergeCellConflict>, IValidatableObject
    {
        /// <summary>
        /// Defines Option
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OptionEnum
        {
            /// <summary>
            /// Enum Child for value: child
            /// </summary>
            [EnumMember(Value = "child")]
            Child = 1,

            /// <summary>
            /// Enum Parent for value: parent
            /// </summary>
            [EnumMember(Value = "parent")]
            Parent = 2,

            /// <summary>
            /// Enum Override for value: override
            /// </summary>
            [EnumMember(Value = "override")]
            Override = 3,

            /// <summary>
            /// Enum OverrideUpToDate for value: overrideUpToDate
            /// </summary>
            [EnumMember(Value = "overrideUpToDate")]
            OverrideUpToDate = 4,

            /// <summary>
            /// Enum OverrideOutOfDate for value: overrideOutOfDate
            /// </summary>
            [EnumMember(Value = "overrideOutOfDate")]
            OverrideOutOfDate = 5,

            /// <summary>
            /// Enum Reserve for value: reserve
            /// </summary>
            [EnumMember(Value = "reserve")]
            Reserve = 6,

            /// <summary>
            /// Enum Ignore for value: ignore
            /// </summary>
            [EnumMember(Value = "ignore")]
            Ignore = 7,

            /// <summary>
            /// Enum Source for value: source
            /// </summary>
            [EnumMember(Value = "source")]
            Source = 8,

            /// <summary>
            /// Enum Destination for value: destination
            /// </summary>
            [EnumMember(Value = "destination")]
            Destination = 9

        }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=true)]
        public OptionEnum Option { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeCellConflict" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MergeCellConflict() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeCellConflict" /> class.
        /// </summary>
        /// <param name="columnId">columnId (required).</param>
        /// <param name="option">option (required).</param>
        public MergeCellConflict(string columnId = default(string), OptionEnum option = default(OptionEnum))
        {
            // to ensure "columnId" is required (not null)
            if (columnId == null)
            {
                throw new InvalidDataException("columnId is a required property for MergeCellConflict and cannot be null");
            }
            else
            {
                this.ColumnId = columnId;
            }

            // to ensure "option" is required (not null)
            if (option == null)
            {
                throw new InvalidDataException("option is a required property for MergeCellConflict and cannot be null");
            }
            else
            {
                this.Option = option;
            }

        }

        /// <summary>
        /// Gets or Sets ColumnId
        /// </summary>
        [DataMember(Name="columnId", EmitDefaultValue=true)]
        public string ColumnId { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeCellConflict {\n");
            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
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
            return this.Equals(input as MergeCellConflict);
        }

        /// <summary>
        /// Returns true if MergeCellConflict instances are equal
        /// </summary>
        /// <param name="input">Instance of MergeCellConflict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeCellConflict input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnId == input.ColumnId ||
                    (this.ColumnId != null &&
                    this.ColumnId.Equals(input.ColumnId))
                ) && 
                (
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.ColumnId != null)
                    hashCode = hashCode * 59 + this.ColumnId.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
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
