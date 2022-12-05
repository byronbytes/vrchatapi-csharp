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
    /// TransactionSteamInfo
    /// </summary>
    [DataContract(Name = "TransactionSteamInfo")]
    public partial class TransactionSteamInfo : IEquatable<TransactionSteamInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSteamInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionSteamInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionSteamInfo" /> class.
        /// </summary>
        /// <param name="walletInfo">walletInfo (required).</param>
        /// <param name="steamId">Steam User ID (required).</param>
        /// <param name="orderId">Steam Order ID (required).</param>
        /// <param name="steamUrl">Empty (required).</param>
        /// <param name="transId">Steam Transaction ID, NOT the same as VRChat TransactionID (required).</param>
        public TransactionSteamInfo(TransactionSteamWalletInfo walletInfo = default(TransactionSteamWalletInfo), string steamId = default(string), string orderId = default(string), string steamUrl = default(string), string transId = default(string))
        {
            // to ensure "walletInfo" is required (not null)
            if (walletInfo == null)
            {
                throw new ArgumentNullException("walletInfo is a required property for TransactionSteamInfo and cannot be null");
            }
            this.WalletInfo = walletInfo;
            // to ensure "steamId" is required (not null)
            if (steamId == null)
            {
                throw new ArgumentNullException("steamId is a required property for TransactionSteamInfo and cannot be null");
            }
            this.SteamId = steamId;
            // to ensure "orderId" is required (not null)
            if (orderId == null)
            {
                throw new ArgumentNullException("orderId is a required property for TransactionSteamInfo and cannot be null");
            }
            this.OrderId = orderId;
            // to ensure "steamUrl" is required (not null)
            if (steamUrl == null)
            {
                throw new ArgumentNullException("steamUrl is a required property for TransactionSteamInfo and cannot be null");
            }
            this.SteamUrl = steamUrl;
            // to ensure "transId" is required (not null)
            if (transId == null)
            {
                throw new ArgumentNullException("transId is a required property for TransactionSteamInfo and cannot be null");
            }
            this.TransId = transId;
        }

        /// <summary>
        /// Gets or Sets WalletInfo
        /// </summary>
        [DataMember(Name = "walletInfo", IsRequired = true, EmitDefaultValue = true)]
        public TransactionSteamWalletInfo WalletInfo { get; set; }

        /// <summary>
        /// Steam User ID
        /// </summary>
        /// <value>Steam User ID</value>
        [DataMember(Name = "steamId", IsRequired = true, EmitDefaultValue = true)]
        public string SteamId { get; set; }

        /// <summary>
        /// Steam Order ID
        /// </summary>
        /// <value>Steam Order ID</value>
        [DataMember(Name = "orderId", IsRequired = true, EmitDefaultValue = true)]
        public string OrderId { get; set; }

        /// <summary>
        /// Empty
        /// </summary>
        /// <value>Empty</value>
        [DataMember(Name = "steamUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SteamUrl { get; set; }

        /// <summary>
        /// Steam Transaction ID, NOT the same as VRChat TransactionID
        /// </summary>
        /// <value>Steam Transaction ID, NOT the same as VRChat TransactionID</value>
        [DataMember(Name = "transId", IsRequired = true, EmitDefaultValue = true)]
        public string TransId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionSteamInfo {\n");
            sb.Append("  WalletInfo: ").Append(WalletInfo).Append("\n");
            sb.Append("  SteamId: ").Append(SteamId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  SteamUrl: ").Append(SteamUrl).Append("\n");
            sb.Append("  TransId: ").Append(TransId).Append("\n");
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
            return this.Equals(input as TransactionSteamInfo);
        }

        /// <summary>
        /// Returns true if TransactionSteamInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionSteamInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSteamInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WalletInfo == input.WalletInfo ||
                    (this.WalletInfo != null &&
                    this.WalletInfo.Equals(input.WalletInfo))
                ) && 
                (
                    this.SteamId == input.SteamId ||
                    (this.SteamId != null &&
                    this.SteamId.Equals(input.SteamId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.SteamUrl == input.SteamUrl ||
                    (this.SteamUrl != null &&
                    this.SteamUrl.Equals(input.SteamUrl))
                ) && 
                (
                    this.TransId == input.TransId ||
                    (this.TransId != null &&
                    this.TransId.Equals(input.TransId))
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
                if (this.WalletInfo != null)
                {
                    hashCode = (hashCode * 59) + this.WalletInfo.GetHashCode();
                }
                if (this.SteamId != null)
                {
                    hashCode = (hashCode * 59) + this.SteamId.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.SteamUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SteamUrl.GetHashCode();
                }
                if (this.TransId != null)
                {
                    hashCode = (hashCode * 59) + this.TransId.GetHashCode();
                }
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
            // SteamId (string) minLength
            if (this.SteamId != null && this.SteamId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SteamId, length must be greater than 1.", new [] { "SteamId" });
            }

            // OrderId (string) minLength
            if (this.OrderId != null && this.OrderId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderId, length must be greater than 1.", new [] { "OrderId" });
            }

            // TransId (string) minLength
            if (this.TransId != null && this.TransId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransId, length must be greater than 1.", new [] { "TransId" });
            }

            yield break;
        }
    }

}
