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
    /// FilterField
    /// </summary>
    [DataContract]
    public partial class FilterField :  IEquatable<FilterField>, IValidatableObject
    {
        /// <summary>
        /// Defines Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum IsNull for value: isNull
            /// </summary>
            [EnumMember(Value = "isNull")]
            IsNull = 1,

            /// <summary>
            /// Enum IsNotNull for value: isNotNull
            /// </summary>
            [EnumMember(Value = "isNotNull")]
            IsNotNull = 2,

            /// <summary>
            /// Enum IsEmpty for value: isEmpty
            /// </summary>
            [EnumMember(Value = "isEmpty")]
            IsEmpty = 3,

            /// <summary>
            /// Enum IsNotEmpty for value: isNotEmpty
            /// </summary>
            [EnumMember(Value = "isNotEmpty")]
            IsNotEmpty = 4,

            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 5,

            /// <summary>
            /// Enum NotContains for value: notContains
            /// </summary>
            [EnumMember(Value = "notContains")]
            NotContains = 6,

            /// <summary>
            /// Enum StartsWith for value: startsWith
            /// </summary>
            [EnumMember(Value = "startsWith")]
            StartsWith = 7,

            /// <summary>
            /// Enum NotStartsWith for value: notStartsWith
            /// </summary>
            [EnumMember(Value = "notStartsWith")]
            NotStartsWith = 8,

            /// <summary>
            /// Enum EndsWith for value: endsWith
            /// </summary>
            [EnumMember(Value = "endsWith")]
            EndsWith = 9,

            /// <summary>
            /// Enum NotEndsWith for value: notEndsWith
            /// </summary>
            [EnumMember(Value = "notEndsWith")]
            NotEndsWith = 10,

            /// <summary>
            /// Enum Regexp for value: regexp
            /// </summary>
            [EnumMember(Value = "regexp")]
            Regexp = 11,

            /// <summary>
            /// Enum NotRegexp for value: notRegexp
            /// </summary>
            [EnumMember(Value = "notRegexp")]
            NotRegexp = 12,

            /// <summary>
            /// Enum Equal for value: =
            /// </summary>
            [EnumMember(Value = "=")]
            Equal = 13,

            /// <summary>
            /// Enum NotEqual for value: !=
            /// </summary>
            [EnumMember(Value = "!=")]
            NotEqual = 14,

            /// <summary>
            /// Enum LessThan for value: <
            /// </summary>
            [EnumMember(Value = "<")]
            LessThan = 15,

            /// <summary>
            /// Enum LessThanOrEqualTo for value: <=
            /// </summary>
            [EnumMember(Value = "<=")]
            LessThanOrEqualTo = 16,

            /// <summary>
            /// Enum GreaterThan for value: >
            /// </summary>
            [EnumMember(Value = ">")]
            GreaterThan = 17,

            /// <summary>
            /// Enum GreaterThanOrEqualTo for value: >=
            /// </summary>
            [EnumMember(Value = ">=")]
            GreaterThanOrEqualTo = 18,

            /// <summary>
            /// Enum In for value: in
            /// </summary>
            [EnumMember(Value = "in")]
            In = 19,

            /// <summary>
            /// Enum NotIn for value: notIn
            /// </summary>
            [EnumMember(Value = "notIn")]
            NotIn = 20,

            /// <summary>
            /// Enum ModifiedBy for value: modifiedBy
            /// </summary>
            [EnumMember(Value = "modifiedBy")]
            ModifiedBy = 21,

            /// <summary>
            /// Enum NotModifiedBy for value: notModifiedBy
            /// </summary>
            [EnumMember(Value = "notModifiedBy")]
            NotModifiedBy = 22,

            /// <summary>
            /// Enum Between for value: between
            /// </summary>
            [EnumMember(Value = "between")]
            Between = 23,

            /// <summary>
            /// Enum NotBetween for value: notBetween
            /// </summary>
            [EnumMember(Value = "notBetween")]
            NotBetween = 24,

            /// <summary>
            /// Enum HasQaError for value: hasQaError
            /// </summary>
            [EnumMember(Value = "hasQaError")]
            HasQaError = 25,

            /// <summary>
            /// Enum IsLengthViolated for value: isLengthViolated
            /// </summary>
            [EnumMember(Value = "isLengthViolated")]
            IsLengthViolated = 26,

            /// <summary>
            /// Enum HasTag for value: hasTag
            /// </summary>
            [EnumMember(Value = "hasTag")]
            HasTag = 27,

            /// <summary>
            /// Enum IsMt for value: isMt
            /// </summary>
            [EnumMember(Value = "isMt")]
            IsMt = 28

        }

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=true)]
        public OperatorEnum Operator { get; set; }
        /// <summary>
        /// Defines SubField
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubFieldEnum
        {
            /// <summary>
            /// Enum DEPENDENCYSTATUS for value: DEPENDENCY_STATUS
            /// </summary>
            [EnumMember(Value = "DEPENDENCY_STATUS")]
            DEPENDENCYSTATUS = 1,

            /// <summary>
            /// Enum SOURCESTATUS for value: SOURCE_STATUS
            /// </summary>
            [EnumMember(Value = "SOURCE_STATUS")]
            SOURCESTATUS = 2,

            /// <summary>
            /// Enum TARGETSTATUS for value: TARGET_STATUS
            /// </summary>
            [EnumMember(Value = "TARGET_STATUS")]
            TARGETSTATUS = 3,

            /// <summary>
            /// Enum FLOWSTATUS for value: FLOW_STATUS
            /// </summary>
            [EnumMember(Value = "FLOW_STATUS")]
            FLOWSTATUS = 4,

            /// <summary>
            /// Enum TM for value: TM
            /// </summary>
            [EnumMember(Value = "TM")]
            TM = 5,

            /// <summary>
            /// Enum MT for value: MT
            /// </summary>
            [EnumMember(Value = "MT")]
            MT = 6,

            /// <summary>
            /// Enum TICKET for value: TICKET
            /// </summary>
            [EnumMember(Value = "TICKET")]
            TICKET = 7,

            /// <summary>
            /// Enum COLOR for value: COLOR
            /// </summary>
            [EnumMember(Value = "COLOR")]
            COLOR = 8,

            /// <summary>
            /// Enum METADATA for value: METADATA
            /// </summary>
            [EnumMember(Value = "METADATA")]
            METADATA = 9,

            /// <summary>
            /// Enum CELLMETADATA for value: CELL_METADATA
            /// </summary>
            [EnumMember(Value = "CELL_METADATA")]
            CELLMETADATA = 10,

            /// <summary>
            /// Enum WORDCOUNT for value: WORD_COUNT
            /// </summary>
            [EnumMember(Value = "WORD_COUNT")]
            WORDCOUNT = 11,

            /// <summary>
            /// Enum PREVIEWSOURCEDATA for value: PREVIEW_SOURCE_DATA
            /// </summary>
            [EnumMember(Value = "PREVIEW_SOURCE_DATA")]
            PREVIEWSOURCEDATA = 12,

            /// <summary>
            /// Enum PREVIEWSOURCEDEPENDENCYSTATUS for value: PREVIEW_SOURCE_DEPENDENCY_STATUS
            /// </summary>
            [EnumMember(Value = "PREVIEW_SOURCE_DEPENDENCY_STATUS")]
            PREVIEWSOURCEDEPENDENCYSTATUS = 13,

            /// <summary>
            /// Enum PREVIEWSTATUS for value: PREVIEW_STATUS
            /// </summary>
            [EnumMember(Value = "PREVIEW_STATUS")]
            PREVIEWSTATUS = 14,

            /// <summary>
            /// Enum PREVIEWMERGEOPTION for value: PREVIEW_MERGE_OPTION
            /// </summary>
            [EnumMember(Value = "PREVIEW_MERGE_OPTION")]
            PREVIEWMERGEOPTION = 15,

            /// <summary>
            /// Enum RELATIVETIME for value: RELATIVE_TIME
            /// </summary>
            [EnumMember(Value = "RELATIVE_TIME")]
            RELATIVETIME = 16,

            /// <summary>
            /// Enum LENGTHVIOLATED for value: LENGTH_VIOLATED
            /// </summary>
            [EnumMember(Value = "LENGTH_VIOLATED")]
            LENGTHVIOLATED = 17,

            /// <summary>
            /// Enum LENGTHSETTING for value: LENGTH_SETTING
            /// </summary>
            [EnumMember(Value = "LENGTH_SETTING")]
            LENGTHSETTING = 18,

            /// <summary>
            /// Enum WORKFLOWSTATUS for value: WORKFLOW_STATUS
            /// </summary>
            [EnumMember(Value = "WORKFLOW_STATUS")]
            WORKFLOWSTATUS = 19

        }

        /// <summary>
        /// Gets or Sets SubField
        /// </summary>
        [DataMember(Name="subField", EmitDefaultValue=true)]
        public SubFieldEnum? SubField { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilterField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterField" /> class.
        /// </summary>
        /// <param name="caseSensitive">caseSensitive.</param>
        /// <param name="columnId">columnId.</param>
        /// <param name="_operator">_operator (required).</param>
        /// <param name="queryPathTagViaId">queryPathTagViaId.</param>
        /// <param name="subField">subField.</param>
        /// <param name="values">values.</param>
        public FilterField(bool caseSensitive = default(bool), string columnId = default(string), OperatorEnum _operator = default(OperatorEnum), bool queryPathTagViaId = default(bool), SubFieldEnum? subField = default(SubFieldEnum?), List<Object> values = default(List<Object>))
        {
            // to ensure "_operator" is required (not null)
            if (_operator == null)
            {
                throw new InvalidDataException("_operator is a required property for FilterField and cannot be null");
            }
            else
            {
                this.Operator = _operator;
            }

            this.CaseSensitive = caseSensitive;
            this.ColumnId = columnId;
            this.QueryPathTagViaId = queryPathTagViaId;
            this.SubField = subField;
            this.Values = values;
        }

        /// <summary>
        /// Gets or Sets CaseSensitive
        /// </summary>
        [DataMember(Name="caseSensitive", EmitDefaultValue=true)]
        public bool CaseSensitive { get; set; }

        /// <summary>
        /// Gets or Sets ColumnId
        /// </summary>
        [DataMember(Name="columnId", EmitDefaultValue=true)]
        public string ColumnId { get; set; }

        /// <summary>
        /// Gets or Sets DynamicColumn
        /// </summary>
        [DataMember(Name="dynamicColumn", EmitDefaultValue=true)]
        public string DynamicColumn { get; private set; }


        /// <summary>
        /// Gets or Sets QueryPathTagViaId
        /// </summary>
        [DataMember(Name="queryPathTagViaId", EmitDefaultValue=true)]
        public bool QueryPathTagViaId { get; set; }


        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=true)]
        public List<Object> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterField {\n");
            sb.Append("  CaseSensitive: ").Append(CaseSensitive).Append("\n");
            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  DynamicColumn: ").Append(DynamicColumn).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  QueryPathTagViaId: ").Append(QueryPathTagViaId).Append("\n");
            sb.Append("  SubField: ").Append(SubField).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as FilterField);
        }

        /// <summary>
        /// Returns true if FilterField instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CaseSensitive == input.CaseSensitive ||
                    (this.CaseSensitive != null &&
                    this.CaseSensitive.Equals(input.CaseSensitive))
                ) && 
                (
                    this.ColumnId == input.ColumnId ||
                    (this.ColumnId != null &&
                    this.ColumnId.Equals(input.ColumnId))
                ) && 
                (
                    this.DynamicColumn == input.DynamicColumn ||
                    (this.DynamicColumn != null &&
                    this.DynamicColumn.Equals(input.DynamicColumn))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.QueryPathTagViaId == input.QueryPathTagViaId ||
                    (this.QueryPathTagViaId != null &&
                    this.QueryPathTagViaId.Equals(input.QueryPathTagViaId))
                ) && 
                (
                    this.SubField == input.SubField ||
                    (this.SubField != null &&
                    this.SubField.Equals(input.SubField))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.CaseSensitive != null)
                    hashCode = hashCode * 59 + this.CaseSensitive.GetHashCode();
                if (this.ColumnId != null)
                    hashCode = hashCode * 59 + this.ColumnId.GetHashCode();
                if (this.DynamicColumn != null)
                    hashCode = hashCode * 59 + this.DynamicColumn.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.QueryPathTagViaId != null)
                    hashCode = hashCode * 59 + this.QueryPathTagViaId.GetHashCode();
                if (this.SubField != null)
                    hashCode = hashCode * 59 + this.SubField.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
