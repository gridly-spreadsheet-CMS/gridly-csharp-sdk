/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.21.5
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
    /// GridSetting
    /// </summary>
    [DataContract]
    public partial class GridSetting :  IEquatable<GridSetting>, IValidatableObject
    {
        /// <summary>
        /// Defines DefaultSourceLanguageStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultSourceLanguageStatusEnum
        {
            /// <summary>
            /// Enum Unset for value: unset
            /// </summary>
            [EnumMember(Value = "unset")]
            Unset = 1,

            /// <summary>
            /// Enum DoNotTranslate for value: doNotTranslate
            /// </summary>
            [EnumMember(Value = "doNotTranslate")]
            DoNotTranslate = 2,

            /// <summary>
            /// Enum NotReadyForTranslation for value: notReadyForTranslation
            /// </summary>
            [EnumMember(Value = "notReadyForTranslation")]
            NotReadyForTranslation = 3,

            /// <summary>
            /// Enum ReadyForTranslation for value: readyForTranslation
            /// </summary>
            [EnumMember(Value = "readyForTranslation")]
            ReadyForTranslation = 4,

            /// <summary>
            /// Enum Locked for value: locked
            /// </summary>
            [EnumMember(Value = "locked")]
            Locked = 5

        }

        /// <summary>
        /// Gets or Sets DefaultSourceLanguageStatus
        /// </summary>
        [DataMember(Name="defaultSourceLanguageStatus", EmitDefaultValue=true)]
        public DefaultSourceLanguageStatusEnum? DefaultSourceLanguageStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GridSetting" /> class.
        /// </summary>
        /// <param name="defaultSourceLanguageStatus">defaultSourceLanguageStatus.</param>
        /// <param name="translatorCanViewAutomations">translatorCanViewAutomations.</param>
        /// <param name="categories">categories.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="lastModifiedTime">lastModifiedTime.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        public GridSetting(DefaultSourceLanguageStatusEnum? defaultSourceLanguageStatus = default(DefaultSourceLanguageStatusEnum?), bool translatorCanViewAutomations = default(bool), List<FileCategory> categories = default(List<FileCategory>), Dictionary<string, string> metadata = default(Dictionary<string, string>), DateTime createdTime = default(DateTime), DateTime lastModifiedTime = default(DateTime), string createdBy = default(string), string lastModifiedBy = default(string))
        {
            this.DefaultSourceLanguageStatus = defaultSourceLanguageStatus;
            this.TranslatorCanViewAutomations = translatorCanViewAutomations;
            this.Categories = categories;
            this.Metadata = metadata;
            this.CreatedTime = createdTime;
            this.LastModifiedTime = lastModifiedTime;
            this.CreatedBy = createdBy;
            this.LastModifiedBy = lastModifiedBy;
        }


        /// <summary>
        /// Gets or Sets TranslatorCanViewAutomations
        /// </summary>
        [DataMember(Name="translatorCanViewAutomations", EmitDefaultValue=true)]
        public bool TranslatorCanViewAutomations { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=true)]
        public List<FileCategory> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=true)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name="createdTime", EmitDefaultValue=true)]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedTime
        /// </summary>
        [DataMember(Name="lastModifiedTime", EmitDefaultValue=true)]
        public DateTime LastModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name="lastModifiedBy", EmitDefaultValue=true)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GridSetting {\n");
            sb.Append("  DefaultSourceLanguageStatus: ").Append(DefaultSourceLanguageStatus).Append("\n");
            sb.Append("  TranslatorCanViewAutomations: ").Append(TranslatorCanViewAutomations).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  LastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
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
            return this.Equals(input as GridSetting);
        }

        /// <summary>
        /// Returns true if GridSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of GridSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GridSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultSourceLanguageStatus == input.DefaultSourceLanguageStatus ||
                    (this.DefaultSourceLanguageStatus != null &&
                    this.DefaultSourceLanguageStatus.Equals(input.DefaultSourceLanguageStatus))
                ) && 
                (
                    this.TranslatorCanViewAutomations == input.TranslatorCanViewAutomations ||
                    (this.TranslatorCanViewAutomations != null &&
                    this.TranslatorCanViewAutomations.Equals(input.TranslatorCanViewAutomations))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
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
                if (this.DefaultSourceLanguageStatus != null)
                    hashCode = hashCode * 59 + this.DefaultSourceLanguageStatus.GetHashCode();
                if (this.TranslatorCanViewAutomations != null)
                    hashCode = hashCode * 59 + this.TranslatorCanViewAutomations.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
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
