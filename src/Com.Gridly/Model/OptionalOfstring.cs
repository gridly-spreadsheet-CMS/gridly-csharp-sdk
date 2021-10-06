/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.13.0-SNAPSHOT
 * 
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
    /// OptionalOfstring
    /// </summary>
    [DataContract]
    public partial class OptionalOfstring :  IEquatable<OptionalOfstring>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionalOfstring" /> class.
        /// </summary>
        /// <param name="empty">empty.</param>
        /// <param name="present">present.</param>
        public OptionalOfstring(bool empty = default(bool), bool present = default(bool))
        {
            this.Empty = empty;
            this.Present = present;
        }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name="empty", EmitDefaultValue=false)]
        public bool Empty { get; set; }

        /// <summary>
        /// Gets or Sets Present
        /// </summary>
        [DataMember(Name="present", EmitDefaultValue=false)]
        public bool Present { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionalOfstring {\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  Present: ").Append(Present).Append("\n");
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
            return this.Equals(input as OptionalOfstring);
        }

        /// <summary>
        /// Returns true if OptionalOfstring instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionalOfstring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionalOfstring input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Empty == input.Empty ||
                    (this.Empty != null &&
                    this.Empty.Equals(input.Empty))
                ) && 
                (
                    this.Present == input.Present ||
                    (this.Present != null &&
                    this.Present.Equals(input.Present))
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
                if (this.Empty != null)
                    hashCode = hashCode * 59 + this.Empty.GetHashCode();
                if (this.Present != null)
                    hashCode = hashCode * 59 + this.Present.GetHashCode();
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
