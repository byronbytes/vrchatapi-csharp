/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.3
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// InfoPushDataClickable
    /// </summary>
    [DataContract(Name = "InfoPushDataClickable")]
    public partial class InfoPushDataClickable : IEquatable<InfoPushDataClickable>, IValidatableObject
    {
        /// <summary>
        /// Defines Command
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommandEnum
        {
            /// <summary>
            /// Enum OpenURL for value: OpenURL
            /// </summary>
            [EnumMember(Value = "OpenURL")]
            OpenURL = 1,

            /// <summary>
            /// Enum OpenVRCPlusMenu for value: OpenVRCPlusMenu
            /// </summary>
            [EnumMember(Value = "OpenVRCPlusMenu")]
            OpenVRCPlusMenu = 2,

            /// <summary>
            /// Enum OpenSafetyMenu for value: OpenSafetyMenu
            /// </summary>
            [EnumMember(Value = "OpenSafetyMenu")]
            OpenSafetyMenu = 3,

            /// <summary>
            /// Enum CannedWorldSearch for value: CannedWorldSearch
            /// </summary>
            [EnumMember(Value = "CannedWorldSearch")]
            CannedWorldSearch = 4

        }


        /// <summary>
        /// Gets or Sets Command
        /// </summary>
        [DataMember(Name = "command", IsRequired = true, EmitDefaultValue = false)]
        public CommandEnum Command { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataClickable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InfoPushDataClickable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushDataClickable" /> class.
        /// </summary>
        /// <param name="command">command (required).</param>
        /// <param name="parameters">In case of OpenURL, this would contain the link..</param>
        public InfoPushDataClickable(CommandEnum command = default(CommandEnum), List<string> parameters = default(List<string>))
        {
            this.Command = command;
            this.Parameters = parameters;
        }

        /// <summary>
        /// In case of OpenURL, this would contain the link.
        /// </summary>
        /// <value>In case of OpenURL, this would contain the link.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InfoPushDataClickable {\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as InfoPushDataClickable);
        }

        /// <summary>
        /// Returns true if InfoPushDataClickable instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushDataClickable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushDataClickable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Command == input.Command ||
                    this.Command.Equals(input.Command)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
