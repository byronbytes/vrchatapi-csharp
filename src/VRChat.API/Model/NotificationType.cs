/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.5.3
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
    /// Defines NotificationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationType
    {
        /// <summary>
        /// Enum FriendRequest for value: friendRequest
        /// </summary>
        [EnumMember(Value = "friendRequest")]
        FriendRequest = 1,

        /// <summary>
        /// Enum Invite for value: invite
        /// </summary>
        [EnumMember(Value = "invite")]
        Invite = 2,

        /// <summary>
        /// Enum InviteResponse for value: inviteResponse
        /// </summary>
        [EnumMember(Value = "inviteResponse")]
        InviteResponse = 3,

        /// <summary>
        /// Enum RequestInvite for value: requestInvite
        /// </summary>
        [EnumMember(Value = "requestInvite")]
        RequestInvite = 4,

        /// <summary>
        /// Enum RequestInviteResponse for value: requestInviteResponse
        /// </summary>
        [EnumMember(Value = "requestInviteResponse")]
        RequestInviteResponse = 5,

        /// <summary>
        /// Enum Votetokick for value: votetokick
        /// </summary>
        [EnumMember(Value = "votetokick")]
        Votetokick = 6

    }

}