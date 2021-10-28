/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.5.0
 * Contact: me@ruby.js.org
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
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// InviteRequest
    /// </summary>
    [DataContract]
    public partial class InviteRequest :  IEquatable<InviteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        /// <param name="instanceId">instanceId (required).</param>
        public InviteRequest(string instanceId = default(string))
        {
            // to ensure "instanceId" is required (not null)
            if (instanceId == null)
            {
                throw new InvalidDataException("instanceId is a required property for InviteRequest and cannot be null");
            }
            else
            {
                this.InstanceId = instanceId;
            }

        }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteRequest {\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
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
            return this.Equals(input as InviteRequest);
        }

        /// <summary>
        /// Returns true if InviteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
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


            // InstanceId (string) pattern
            Regex regexInstanceId = new Regex(@"(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12}:(\\d+)(~region\\(([\\w]+)\\))?(~([\\w]+)\\(usr_([\\w-]+)\\)((\\~canRequestInvite)?)(~region\\(([\\w].+)\\))?~nonce\\((.+)\\))?", RegexOptions.CultureInvariant);
            if (false == regexInstanceId.Match(this.InstanceId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstanceId, must match a pattern of " + regexInstanceId, new [] { "InstanceId" });
            }

            yield break;
        }
    }

}
