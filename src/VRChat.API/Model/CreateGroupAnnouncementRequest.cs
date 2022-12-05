/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.10.0
 * Contact: me@ariesclark.com
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
    /// CreateGroupAnnouncementRequest
    /// </summary>
    [DataContract(Name = "CreateGroupAnnouncementRequest")]
    public partial class CreateGroupAnnouncementRequest : IEquatable<CreateGroupAnnouncementRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupAnnouncementRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateGroupAnnouncementRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupAnnouncementRequest" /> class.
        /// </summary>
        /// <param name="title">Announcement title (required).</param>
        /// <param name="text">Announcement text.</param>
        /// <param name="imageId">imageId.</param>
        /// <param name="sendNotification">Send notification to group members. (default to false).</param>
        public CreateGroupAnnouncementRequest(string title = default(string), string text = default(string), string imageId = default(string), bool sendNotification = false)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateGroupAnnouncementRequest and cannot be null");
            }
            this.Title = title;
            this.Text = text;
            this.ImageId = imageId;
            this.SendNotification = sendNotification;
        }

        /// <summary>
        /// Announcement title
        /// </summary>
        /// <value>Announcement title</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Announcement text
        /// </summary>
        /// <value>Announcement text</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [DataMember(Name = "imageId", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// Send notification to group members.
        /// </summary>
        /// <value>Send notification to group members.</value>
        [DataMember(Name = "sendNotification", EmitDefaultValue = true)]
        public bool SendNotification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateGroupAnnouncementRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  SendNotification: ").Append(SendNotification).Append("\n");
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
            return this.Equals(input as CreateGroupAnnouncementRequest);
        }

        /// <summary>
        /// Returns true if CreateGroupAnnouncementRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateGroupAnnouncementRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateGroupAnnouncementRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.SendNotification == input.SendNotification ||
                    this.SendNotification.Equals(input.SendNotification)
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
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SendNotification.GetHashCode();
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
            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            // Text (string) minLength
            if (this.Text != null && this.Text.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be greater than 1.", new [] { "Text" });
            }

            // ImageId (string) pattern
            Regex regexImageId = new Regex(@"file_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexImageId.Match(this.ImageId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageId, must match a pattern of " + regexImageId, new [] { "ImageId" });
            }

            yield break;
        }
    }

}
