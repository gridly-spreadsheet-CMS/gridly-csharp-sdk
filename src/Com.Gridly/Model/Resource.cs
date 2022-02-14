/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.21.3
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
    /// Resource
    /// </summary>
    [DataContract]
    public partial class Resource :  IEquatable<Resource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resource" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="file">file.</param>
        /// <param name="filename">filename.</param>
        /// <param name="inputStream">inputStream.</param>
        /// <param name="open">open.</param>
        /// <param name="readable">readable.</param>
        /// <param name="uri">uri.</param>
        /// <param name="url">url.</param>
        public Resource(string description = default(string), File file = default(File), string filename = default(string), Object inputStream = default(Object), bool open = default(bool), bool readable = default(bool), string uri = default(string), URL url = default(URL))
        {
            this.Description = description;
            this.File = file;
            this.Filename = filename;
            this.InputStream = inputStream;
            this.Open = open;
            this.Readable = readable;
            this.Uri = uri;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public File File { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets InputStream
        /// </summary>
        [DataMember(Name="inputStream", EmitDefaultValue=false)]
        public Object InputStream { get; set; }

        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public bool Open { get; set; }

        /// <summary>
        /// Gets or Sets Readable
        /// </summary>
        [DataMember(Name="readable", EmitDefaultValue=false)]
        public bool Readable { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public URL Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  InputStream: ").Append(InputStream).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Readable: ").Append(Readable).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as Resource);
        }

        /// <summary>
        /// Returns true if Resource instances are equal
        /// </summary>
        /// <param name="input">Instance of Resource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Resource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.InputStream == input.InputStream ||
                    (this.InputStream != null &&
                    this.InputStream.Equals(input.InputStream))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.Readable == input.Readable ||
                    (this.Readable != null &&
                    this.Readable.Equals(input.Readable))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.InputStream != null)
                    hashCode = hashCode * 59 + this.InputStream.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.Readable != null)
                    hashCode = hashCode * 59 + this.Readable.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
