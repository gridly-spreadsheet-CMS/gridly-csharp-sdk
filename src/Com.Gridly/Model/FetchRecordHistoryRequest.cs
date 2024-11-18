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
    /// FetchRecordHistoryRequest
    /// </summary>
    [DataContract]
    public partial class FetchRecordHistoryRequest :  IEquatable<FetchRecordHistoryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchRecordHistoryRequest" /> class.
        /// </summary>
        /// <param name="columnIds">columnIds.</param>
        /// <param name="query">query.</param>
        /// <param name="sort">sort.</param>
        /// <param name="groupBy">groupBy.</param>
        /// <param name="page">page.</param>
        /// <param name="fetchOptions">fetchOptions.</param>
        /// <param name="includeSystemUser">includeSystemUser.</param>
        public FetchRecordHistoryRequest(List<string> columnIds = default(List<string>), string query = default(string), string sort = default(string), List<string> groupBy = default(List<string>), string page = default(string), string fetchOptions = default(string), bool includeSystemUser = default(bool))
        {
            this.ColumnIds = columnIds;
            this.Query = query;
            this.Sort = sort;
            this.GroupBy = groupBy;
            this.Page = page;
            this.FetchOptions = fetchOptions;
            this.IncludeSystemUser = includeSystemUser;
        }

        /// <summary>
        /// Gets or Sets ColumnIds
        /// </summary>
        [DataMember(Name="columnIds", EmitDefaultValue=true)]
        public List<string> ColumnIds { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=true)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=true)]
        public string Sort { get; set; }

        /// <summary>
        /// Gets or Sets GroupBy
        /// </summary>
        [DataMember(Name="groupBy", EmitDefaultValue=true)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=true)]
        public string Page { get; set; }

        /// <summary>
        /// Gets or Sets FetchOptions
        /// </summary>
        [DataMember(Name="fetchOptions", EmitDefaultValue=true)]
        public string FetchOptions { get; set; }

        /// <summary>
        /// Gets or Sets IncludeSystemUser
        /// </summary>
        [DataMember(Name="includeSystemUser", EmitDefaultValue=true)]
        public bool IncludeSystemUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FetchRecordHistoryRequest {\n");
            sb.Append("  ColumnIds: ").Append(ColumnIds).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  GroupBy: ").Append(GroupBy).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  FetchOptions: ").Append(FetchOptions).Append("\n");
            sb.Append("  IncludeSystemUser: ").Append(IncludeSystemUser).Append("\n");
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
            return this.Equals(input as FetchRecordHistoryRequest);
        }

        /// <summary>
        /// Returns true if FetchRecordHistoryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FetchRecordHistoryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FetchRecordHistoryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnIds == input.ColumnIds ||
                    this.ColumnIds != null &&
                    input.ColumnIds != null &&
                    this.ColumnIds.SequenceEqual(input.ColumnIds)
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.GroupBy == input.GroupBy ||
                    this.GroupBy != null &&
                    input.GroupBy != null &&
                    this.GroupBy.SequenceEqual(input.GroupBy)
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.FetchOptions == input.FetchOptions ||
                    (this.FetchOptions != null &&
                    this.FetchOptions.Equals(input.FetchOptions))
                ) && 
                (
                    this.IncludeSystemUser == input.IncludeSystemUser ||
                    (this.IncludeSystemUser != null &&
                    this.IncludeSystemUser.Equals(input.IncludeSystemUser))
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
                if (this.ColumnIds != null)
                    hashCode = hashCode * 59 + this.ColumnIds.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.GroupBy != null)
                    hashCode = hashCode * 59 + this.GroupBy.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.FetchOptions != null)
                    hashCode = hashCode * 59 + this.FetchOptions.GetHashCode();
                if (this.IncludeSystemUser != null)
                    hashCode = hashCode * 59 + this.IncludeSystemUser.GetHashCode();
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