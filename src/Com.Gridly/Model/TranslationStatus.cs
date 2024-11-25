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
    /// Defines TranslationStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TranslationStatus
    {
        /// <summary>
        /// Enum UpToDate for value: upToDate
        /// </summary>
        [EnumMember(Value = "upToDate")]
        UpToDate = 1,

        /// <summary>
        /// Enum OutOfDate for value: outOfDate
        /// </summary>
        [EnumMember(Value = "outOfDate")]
        OutOfDate = 2,

        /// <summary>
        /// Enum Unset for value: unset
        /// </summary>
        [EnumMember(Value = "unset")]
        Unset = 3

    }

}
