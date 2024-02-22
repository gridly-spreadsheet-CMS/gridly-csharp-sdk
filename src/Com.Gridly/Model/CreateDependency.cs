/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.27.1
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
    /// CreateDependency
    /// </summary>
    [DataContract]
    public partial class CreateDependency :  IEquatable<CreateDependency>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDependency" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="targetColumnId">targetColumnId (required).</param>
        /// <param name="sourceColumnId">sourceColumnId (required).</param>
        public CreateDependency(string id = default(string), string targetColumnId = default(string), string sourceColumnId = default(string))
        {
            // to ensure "targetColumnId" is required (not null)
            if (targetColumnId == null)
            {
                throw new InvalidDataException("targetColumnId is a required property for CreateDependency and cannot be null");
            }
            else
            {
                this.TargetColumnId = targetColumnId;
            }

            // to ensure "sourceColumnId" is required (not null)
            if (sourceColumnId == null)
            {
                throw new InvalidDataException("sourceColumnId is a required property for CreateDependency and cannot be null");
            }
            else
            {
                this.SourceColumnId = sourceColumnId;
            }

            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TargetColumnId
        /// </summary>
        [DataMember(Name="targetColumnId", EmitDefaultValue=true)]
        public string TargetColumnId { get; set; }

        /// <summary>
        /// Gets or Sets SourceColumnId
        /// </summary>
        [DataMember(Name="sourceColumnId", EmitDefaultValue=true)]
        public string SourceColumnId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDependency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TargetColumnId: ").Append(TargetColumnId).Append("\n");
            sb.Append("  SourceColumnId: ").Append(SourceColumnId).Append("\n");
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
            return this.Equals(input as CreateDependency);
        }

        /// <summary>
        /// Returns true if CreateDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDependency input)
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
                    this.TargetColumnId == input.TargetColumnId ||
                    (this.TargetColumnId != null &&
                    this.TargetColumnId.Equals(input.TargetColumnId))
                ) && 
                (
                    this.SourceColumnId == input.SourceColumnId ||
                    (this.SourceColumnId != null &&
                    this.SourceColumnId.Equals(input.SourceColumnId))
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
                if (this.TargetColumnId != null)
                    hashCode = hashCode * 59 + this.TargetColumnId.GetHashCode();
                if (this.SourceColumnId != null)
                    hashCode = hashCode * 59 + this.SourceColumnId.GetHashCode();
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


            // Id (string) pattern
            Regex regexId = new Regex(@"^(?!_)\\w+$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            yield break;
        }
    }

}
