/* 
 * Realtime Notification Service
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Realtime Notification Configuration Response
    /// </summary>
    [DataContract]
    public partial class EndpointResponse :  IEquatable<EndpointResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointResponse" /> class.
        /// </summary>
        /// <param name="Headers">Headers.</param>
        /// <param name="BroadcastAddress">BroadcastAddress.</param>
        /// <param name="BroadcastBase">BroadcastBase.</param>
        public EndpointResponse(List<HttpParameter> Headers = default(List<HttpParameter>), string BroadcastAddress = default(string), string BroadcastBase = default(string))
        {
            this.Headers = Headers;
            this.BroadcastAddress = BroadcastAddress;
            this.BroadcastBase = BroadcastBase;
        }
        
        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=false)]
        public List<HttpParameter> Headers { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastAddress
        /// </summary>
        [DataMember(Name="broadcastAddress", EmitDefaultValue=false)]
        public string BroadcastAddress { get; set; }

        /// <summary>
        /// Gets or Sets BroadcastBase
        /// </summary>
        [DataMember(Name="broadcastBase", EmitDefaultValue=false)]
        public string BroadcastBase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointResponse {\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  BroadcastAddress: ").Append(BroadcastAddress).Append("\n");
            sb.Append("  BroadcastBase: ").Append(BroadcastBase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointResponse);
        }

        /// <summary>
        /// Returns true if EndpointResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EndpointResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.BroadcastAddress == input.BroadcastAddress ||
                    (this.BroadcastAddress != null &&
                    this.BroadcastAddress.Equals(input.BroadcastAddress))
                ) && 
                (
                    this.BroadcastBase == input.BroadcastBase ||
                    (this.BroadcastBase != null &&
                    this.BroadcastBase.Equals(input.BroadcastBase))
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
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.BroadcastAddress != null)
                    hashCode = hashCode * 59 + this.BroadcastAddress.GetHashCode();
                if (this.BroadcastBase != null)
                    hashCode = hashCode * 59 + this.BroadcastBase.GetHashCode();
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