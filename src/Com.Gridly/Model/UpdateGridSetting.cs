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
    /// UpdateGridSetting
    /// </summary>
    [DataContract]
    public partial class UpdateGridSetting :  IEquatable<UpdateGridSetting>, IValidatableObject
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
            Locked = 5,

            /// <summary>
            /// Enum LockAllLanguages for value: lockAllLanguages
            /// </summary>
            [EnumMember(Value = "lockAllLanguages")]
            LockAllLanguages = 6

        }

        /// <summary>
        /// Gets or Sets DefaultSourceLanguageStatus
        /// </summary>
        [DataMember(Name="defaultSourceLanguageStatus", EmitDefaultValue=true)]
        public DefaultSourceLanguageStatusEnum? DefaultSourceLanguageStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGridSetting" /> class.
        /// </summary>
        /// <param name="defaultDateTimeFormat">defaultDateTimeFormat.</param>
        /// <param name="defaultSourceLanguageStatus">defaultSourceLanguageStatus.</param>
        /// <param name="translatorCanViewAutomations">translatorCanViewAutomations.</param>
        /// <param name="metadata">metadata.</param>
        public UpdateGridSetting(DateTimeFormat defaultDateTimeFormat = default(DateTimeFormat), DefaultSourceLanguageStatusEnum? defaultSourceLanguageStatus = default(DefaultSourceLanguageStatusEnum?), bool translatorCanViewAutomations = default(bool), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            this.DefaultDateTimeFormat = defaultDateTimeFormat;
            this.DefaultSourceLanguageStatus = defaultSourceLanguageStatus;
            this.TranslatorCanViewAutomations = translatorCanViewAutomations;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets DefaultDateTimeFormat
        /// </summary>
        [DataMember(Name="defaultDateTimeFormat", EmitDefaultValue=true)]
        public DateTimeFormat DefaultDateTimeFormat { get; set; }


        /// <summary>
        /// Gets or Sets TranslatorCanViewAutomations
        /// </summary>
        [DataMember(Name="translatorCanViewAutomations", EmitDefaultValue=true)]
        public bool TranslatorCanViewAutomations { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=true)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateGridSetting {\n");
            sb.Append("  DefaultDateTimeFormat: ").Append(DefaultDateTimeFormat).Append("\n");
            sb.Append("  DefaultSourceLanguageStatus: ").Append(DefaultSourceLanguageStatus).Append("\n");
            sb.Append("  TranslatorCanViewAutomations: ").Append(TranslatorCanViewAutomations).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as UpdateGridSetting);
        }

        /// <summary>
        /// Returns true if UpdateGridSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateGridSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateGridSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultDateTimeFormat == input.DefaultDateTimeFormat ||
                    (this.DefaultDateTimeFormat != null &&
                    this.DefaultDateTimeFormat.Equals(input.DefaultDateTimeFormat))
                ) && 
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
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                if (this.DefaultDateTimeFormat != null)
                    hashCode = hashCode * 59 + this.DefaultDateTimeFormat.GetHashCode();
                if (this.DefaultSourceLanguageStatus != null)
                    hashCode = hashCode * 59 + this.DefaultSourceLanguageStatus.GetHashCode();
                if (this.TranslatorCanViewAutomations != null)
                    hashCode = hashCode * 59 + this.TranslatorCanViewAutomations.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
