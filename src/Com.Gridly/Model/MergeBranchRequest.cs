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
    /// MergeBranchRequest
    /// </summary>
    [DataContract]
    public partial class MergeBranchRequest :  IEquatable<MergeBranchRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines MergeRecordOptions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MergeRecordOptionsEnum
        {
            /// <summary>
            /// Enum Add for value: add
            /// </summary>
            [EnumMember(Value = "add")]
            Add = 1,

            /// <summary>
            /// Enum Update for value: update
            /// </summary>
            [EnumMember(Value = "update")]
            Update = 2,

            /// <summary>
            /// Enum Delete for value: delete
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete = 3,

            /// <summary>
            /// Enum Override for value: override
            /// </summary>
            [EnumMember(Value = "override")]
            Override = 4

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MergeBranchRequest" /> class.
        /// </summary>
        /// <param name="mergeRecordOptions">mergeRecordOptions.</param>
        /// <param name="mergeRecordConflicts">mergeRecordConflicts.</param>
        /// <param name="useLastMergeResolve">useLastMergeResolve.</param>
        /// <param name="query">query.</param>
        public MergeBranchRequest(List<MergeRecordOptionsEnum> mergeRecordOptions = default(List<MergeRecordOptionsEnum>), List<MergeRecordConflict> mergeRecordConflicts = default(List<MergeRecordConflict>), bool useLastMergeResolve = default(bool), List<FilterField> query = default(List<FilterField>))
        {
            this.MergeRecordOptions = mergeRecordOptions;
            this.MergeRecordConflicts = mergeRecordConflicts;
            this.UseLastMergeResolve = useLastMergeResolve;
            this.Query = query;
        }

        /// <summary>
        /// Gets or Sets MergeRecordOptions
        /// </summary>
        [DataMember(Name="mergeRecordOptions", EmitDefaultValue=true)]
        public List<MergeBranchRequest.MergeRecordOptionsEnum> MergeRecordOptions { get; set; }

        /// <summary>
        /// Gets or Sets MergeRecordConflicts
        /// </summary>
        [DataMember(Name="mergeRecordConflicts", EmitDefaultValue=true)]
        public List<MergeRecordConflict> MergeRecordConflicts { get; set; }

        /// <summary>
        /// Gets or Sets UseLastMergeResolve
        /// </summary>
        [DataMember(Name="useLastMergeResolve", EmitDefaultValue=true)]
        public bool UseLastMergeResolve { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=true)]
        public List<FilterField> Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeBranchRequest {\n");
            sb.Append("  MergeRecordOptions: ").Append(MergeRecordOptions).Append("\n");
            sb.Append("  MergeRecordConflicts: ").Append(MergeRecordConflicts).Append("\n");
            sb.Append("  UseLastMergeResolve: ").Append(UseLastMergeResolve).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as MergeBranchRequest);
        }

        /// <summary>
        /// Returns true if MergeBranchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MergeBranchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeBranchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MergeRecordOptions == input.MergeRecordOptions ||
                    this.MergeRecordOptions != null &&
                    input.MergeRecordOptions != null &&
                    this.MergeRecordOptions.SequenceEqual(input.MergeRecordOptions)
                ) && 
                (
                    this.MergeRecordConflicts == input.MergeRecordConflicts ||
                    this.MergeRecordConflicts != null &&
                    input.MergeRecordConflicts != null &&
                    this.MergeRecordConflicts.SequenceEqual(input.MergeRecordConflicts)
                ) && 
                (
                    this.UseLastMergeResolve == input.UseLastMergeResolve ||
                    (this.UseLastMergeResolve != null &&
                    this.UseLastMergeResolve.Equals(input.UseLastMergeResolve))
                ) && 
                (
                    this.Query == input.Query ||
                    this.Query != null &&
                    input.Query != null &&
                    this.Query.SequenceEqual(input.Query)
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
                if (this.MergeRecordOptions != null)
                    hashCode = hashCode * 59 + this.MergeRecordOptions.GetHashCode();
                if (this.MergeRecordConflicts != null)
                    hashCode = hashCode * 59 + this.MergeRecordConflicts.GetHashCode();
                if (this.UseLastMergeResolve != null)
                    hashCode = hashCode * 59 + this.UseLastMergeResolve.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
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
