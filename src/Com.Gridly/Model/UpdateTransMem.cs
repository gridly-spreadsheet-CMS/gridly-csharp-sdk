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
    /// UpdateTransMem
    /// </summary>
    [DataContract]
    public partial class UpdateTransMem :  IEquatable<UpdateTransMem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PopulateTranslationStatus
        /// </summary>
        [DataMember(Name="populateTranslationStatus", EmitDefaultValue=true)]
        public TranslationStatus? PopulateTranslationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTransMem" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="fuzzyMatch">fuzzyMatch.</param>
        /// <param name="isDisabled">isDisabled.</param>
        /// <param name="isPausedConsuming">isPausedConsuming.</param>
        /// <param name="populateTranslationStatus">populateTranslationStatus.</param>
        /// <param name="contextLookup">contextLookup.</param>
        /// <param name="allowAlternative">allowAlternative.</param>
        /// <param name="allowAlternativeHasSameRecordId">allowAlternativeHasSameRecordId.</param>
        public UpdateTransMem(string name = default(string), string description = default(string), List<long> projectIds = default(List<long>), bool fuzzyMatch = default(bool), bool isDisabled = default(bool), bool isPausedConsuming = default(bool), TranslationStatus? populateTranslationStatus = default(TranslationStatus?), bool contextLookup = default(bool), bool allowAlternative = default(bool), bool allowAlternativeHasSameRecordId = default(bool))
        {
            this.Name = name;
            this.Description = description;
            this.ProjectIds = projectIds;
            this.FuzzyMatch = fuzzyMatch;
            this.IsDisabled = isDisabled;
            this.IsPausedConsuming = isPausedConsuming;
            this.PopulateTranslationStatus = populateTranslationStatus;
            this.ContextLookup = contextLookup;
            this.AllowAlternative = allowAlternative;
            this.AllowAlternativeHasSameRecordId = allowAlternativeHasSameRecordId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name="projectIds", EmitDefaultValue=true)]
        public List<long> ProjectIds { get; set; }

        /// <summary>
        /// Gets or Sets FuzzyMatch
        /// </summary>
        [DataMember(Name="fuzzyMatch", EmitDefaultValue=true)]
        public bool FuzzyMatch { get; set; }

        /// <summary>
        /// Gets or Sets IsDisabled
        /// </summary>
        [DataMember(Name="isDisabled", EmitDefaultValue=true)]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets IsPausedConsuming
        /// </summary>
        [DataMember(Name="isPausedConsuming", EmitDefaultValue=true)]
        public bool IsPausedConsuming { get; set; }


        /// <summary>
        /// Gets or Sets ContextLookup
        /// </summary>
        [DataMember(Name="contextLookup", EmitDefaultValue=true)]
        public bool ContextLookup { get; set; }

        /// <summary>
        /// Gets or Sets AllowAlternative
        /// </summary>
        [DataMember(Name="allowAlternative", EmitDefaultValue=true)]
        public bool AllowAlternative { get; set; }

        /// <summary>
        /// Gets or Sets AllowAlternativeHasSameRecordId
        /// </summary>
        [DataMember(Name="allowAlternativeHasSameRecordId", EmitDefaultValue=true)]
        public bool AllowAlternativeHasSameRecordId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTransMem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  FuzzyMatch: ").Append(FuzzyMatch).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  IsPausedConsuming: ").Append(IsPausedConsuming).Append("\n");
            sb.Append("  PopulateTranslationStatus: ").Append(PopulateTranslationStatus).Append("\n");
            sb.Append("  ContextLookup: ").Append(ContextLookup).Append("\n");
            sb.Append("  AllowAlternative: ").Append(AllowAlternative).Append("\n");
            sb.Append("  AllowAlternativeHasSameRecordId: ").Append(AllowAlternativeHasSameRecordId).Append("\n");
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
            return this.Equals(input as UpdateTransMem);
        }

        /// <summary>
        /// Returns true if UpdateTransMem instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTransMem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTransMem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.FuzzyMatch == input.FuzzyMatch ||
                    (this.FuzzyMatch != null &&
                    this.FuzzyMatch.Equals(input.FuzzyMatch))
                ) && 
                (
                    this.IsDisabled == input.IsDisabled ||
                    (this.IsDisabled != null &&
                    this.IsDisabled.Equals(input.IsDisabled))
                ) && 
                (
                    this.IsPausedConsuming == input.IsPausedConsuming ||
                    (this.IsPausedConsuming != null &&
                    this.IsPausedConsuming.Equals(input.IsPausedConsuming))
                ) && 
                (
                    this.PopulateTranslationStatus == input.PopulateTranslationStatus ||
                    (this.PopulateTranslationStatus != null &&
                    this.PopulateTranslationStatus.Equals(input.PopulateTranslationStatus))
                ) && 
                (
                    this.ContextLookup == input.ContextLookup ||
                    (this.ContextLookup != null &&
                    this.ContextLookup.Equals(input.ContextLookup))
                ) && 
                (
                    this.AllowAlternative == input.AllowAlternative ||
                    (this.AllowAlternative != null &&
                    this.AllowAlternative.Equals(input.AllowAlternative))
                ) && 
                (
                    this.AllowAlternativeHasSameRecordId == input.AllowAlternativeHasSameRecordId ||
                    (this.AllowAlternativeHasSameRecordId != null &&
                    this.AllowAlternativeHasSameRecordId.Equals(input.AllowAlternativeHasSameRecordId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProjectIds != null)
                    hashCode = hashCode * 59 + this.ProjectIds.GetHashCode();
                if (this.FuzzyMatch != null)
                    hashCode = hashCode * 59 + this.FuzzyMatch.GetHashCode();
                if (this.IsDisabled != null)
                    hashCode = hashCode * 59 + this.IsDisabled.GetHashCode();
                if (this.IsPausedConsuming != null)
                    hashCode = hashCode * 59 + this.IsPausedConsuming.GetHashCode();
                if (this.PopulateTranslationStatus != null)
                    hashCode = hashCode * 59 + this.PopulateTranslationStatus.GetHashCode();
                if (this.ContextLookup != null)
                    hashCode = hashCode * 59 + this.ContextLookup.GetHashCode();
                if (this.AllowAlternative != null)
                    hashCode = hashCode * 59 + this.AllowAlternative.GetHashCode();
                if (this.AllowAlternativeHasSameRecordId != null)
                    hashCode = hashCode * 59 + this.AllowAlternativeHasSameRecordId.GetHashCode();
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
