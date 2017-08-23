// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Devices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Devices;
    using Microsoft.Azure.Management.Devices.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Error details.
    /// </summary>
    public partial class ErrorDetailsInner
    {
        /// <summary>
        /// Initializes a new instance of the ErrorDetailsInner class.
        /// </summary>
        public ErrorDetailsInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorDetailsInner class.
        /// </summary>
        /// <param name="code">The error code.</param>
        /// <param name="httpStatusCode">The HTTP status code.</param>
        /// <param name="message">The error message.</param>
        /// <param name="details">The error details.</param>
        public ErrorDetailsInner(string code = default(string), string httpStatusCode = default(string), string message = default(string), string details = default(string))
        {
            Code = code;
            HttpStatusCode = httpStatusCode;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the error code.
        /// </summary>
        [JsonProperty(PropertyName = "Code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "HttpStatusCode")]
        public string HttpStatusCode { get; private set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the error details.
        /// </summary>
        [JsonProperty(PropertyName = "Details")]
        public string Details { get; private set; }

    }
}