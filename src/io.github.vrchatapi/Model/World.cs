/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # Welcome to the VRChat API  Before we begin, we would like to state this is a **COMMUNITY DRIVEN PROJECT**. This means that everything you read on here was written by the community itself and is **not** officially supported by VRChat. The documentation is provided \"AS IS\", and any action you take towards VRChat is completely your own responsibility.  The documentation and additional libraries SHALL ONLY be used for applications interacting with VRChat's API in accordance with their [Terms of Service](https://github.com/VRChatAPI), and MUST NOT be used for modifying the client, \"avatar ripping\", or other illegal activities. Malicious usage or spamming the API may result in account termination. Certain parts of the API are also more sensitive than others, for example moderation, so please read tread extra carefully and read the warnings when present.  ![Tupper Policy on API](https://i.imgur.com/yLlW7Ok.png)  Finally, use of the API using applications other than the approved methods (website, VRChat application, Unity SDK) is not officially supported. VRChat provides no guarantee or support for external applications using the API. Access to API endpoints may break **at any time, without notice**. Therefore, please **do not ping** VRChat Staff in the VRChat Discord if you are having API problems, as they do not provide API support. We will make a best effort in keeping this documentation and associated language libraries up to date, but things might be outdated or missing. If you find that something is no longer valid, please contact us on Discord or [create an issue](https://github.com/vrchatapi/specification/issues) and tell us so we can fix it.  # Getting Started  The VRChat API can be used to programmatically retrieve or update information regarding your profile, friends, avatars, worlds and more. The API consists of two parts, \"Photon\" which is only used in-game, and the \"Web API\" which is used by both the game and the website. This documentation focuses only on the Web API.  The API is designed around the REST ideology, providing semi-simple and usually predictable URIs to access and modify objects. Requests support standard HTTP methods like GET, PUT, POST, and DELETE and standard status codes. Response bodies are always UTF-8 encoded JSON objects, unless explicitly documented otherwise.  <div class=\"callout callout-error\">   <strong>🛑 Warning! Do not touch Photon!</strong><br>   Photon is only used by the in-game client and should <b>not</b> be touched. Doing so may result in permanent account termination. </div>  <div class=\"callout callout-info\">   <strong>ℹ️ API Key and Authentication</strong><br>   The API Key has always been the same and is currently <code>JlE5Jldo5Jibnk5O5hTx6XVqsJu4WJ26</code>.   Read <a href=\"#tag- -authentication\">Authentication</a> for how to log in. </div>  # Using the API  For simply exploring what the API can do it is strongly recommended to download [Insomnia](https://insomnia.rest/download), a free and open-source API client that's great for sending requests to the API in an orderly fashion. Insomnia allows you to send data in the format that's required for VRChat's API. It is also possible to try out the API in your browser, by first logging in at [vrchat.com/home](https://vrchat.com/home/) and then going to [vrchat.com/api/1/auth/user](https://vrchat.com/api/1/auth/user), but the information will be much harder to work with.  For more permanent operation such as software development it is instead recommended to use one of the existing language SDKs. This community project maintains API libraries in several languages, which allows you to interact with the API with simple function calls rather than having to implement the HTTP protocol yourself. Most of these libraries are automatically generated from the API specification, sometimes with additional helpful wrapper code to make usage easier. This allows them to be almost automatically updated and expanded upon as soon as a new feature is introduced in the specification itself. The libraries can be found on [GitHub](https://github.com/vrchatapi) or following:  * [NodeJS (JavaScript)](https://www.npmjs.com/package/vrchat) * [Dart](https://pub.dev/packages/vrchat_dart) * [Rust](https://crates.io/crates/vrchatapi) * [C#](github.com/vrchatapi/vrchatapi-csharp) * [Python](https://github.com/vrchatapi/VRChatPython)  # Pagination  Most endpoints enforce pagination, meaning they will only return 10 entries by default, and never more than 100.<br> Using both the limit and offset parameters allows you to easily paginate through a large number of objects.  | Query Parameter | Type | Description | | - -- -- -- -- -|- -|- -- -- -- | | `limit` | integer  | The number of objects to return. This value often defaults to 10. Highest limit is always 100.| | `offset` | integer  | A zero-based offset from the default object sorting.|  If a request returns fewer objects than the `limit` parameter, there are no more items available to return.  # Contribution  Do you want to get involved in the documentation effort? Do you want to help improve one of the language API libraries? This project is an [OPEN Open Source Project](https://openopensource.org)! This means that individuals making significant and valuable contributions are given commit-access to the project. It also means we are very open and welcoming of new people making contributions, unlike some more guarded open-source projects.  [![Discord](https://img.shields.io/static/v1?label=vrchatapi&message=discord&color=blueviolet&style=for-the-badge)](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.2
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
    /// World
    /// </summary>
    [DataContract]
    public partial class World :  IEquatable<World>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ReleaseStatus
        /// </summary>
        [DataMember(Name="releaseStatus", EmitDefaultValue=true)]
        public ReleaseStatus ReleaseStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="World" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected World() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="World" /> class.
        /// </summary>
        /// <param name="assetUrl">assetUrl (required).</param>
        /// <param name="assetUrlObject">assetUrlObject (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="featured">featured (required) (default to false).</param>
        /// <param name="id">id (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="instances">instances.</param>
        /// <param name="labsPublicationDate">labsPublicationDate (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="_namespace">_namespace (required).</param>
        /// <param name="organization">organization (required) (default to &quot;vrchat&quot;).</param>
        /// <param name="pluginUrlObject">pluginUrlObject (required).</param>
        /// <param name="previewYoutubeId">previewYoutubeId.</param>
        /// <param name="publicationDate">publicationDate (required).</param>
        /// <param name="releaseStatus">releaseStatus (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl (required).</param>
        /// <param name="unityPackageUrlObject">unityPackageUrlObject (required).</param>
        /// <param name="unityPackages">unityPackages (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="version">version (required) (default to 0M).</param>
        public World(string assetUrl = default(string), Object assetUrlObject = default(Object), string description = default(string), bool featured = false, string id = default(string), string imageUrl = default(string), List<List<Object>> instances = default(List<List<Object>>), string labsPublicationDate = default(string), string name = default(string), string _namespace = default(string), string organization = "vrchat", Object pluginUrlObject = default(Object), string previewYoutubeId = default(string), DateTime publicationDate = default(DateTime), ReleaseStatus releaseStatus = default(ReleaseStatus), List<string> tags = default(List<string>), string thumbnailImageUrl = default(string), Object unityPackageUrlObject = default(Object), List<UnityPackage> unityPackages = default(List<UnityPackage>), DateTime updatedAt = default(DateTime), decimal version = 0M)
        {
            // to ensure "assetUrl" is required (not null)
            if (assetUrl == null)
            {
                throw new InvalidDataException("assetUrl is a required property for World and cannot be null");
            }
            else
            {
                this.AssetUrl = assetUrl;
            }

            // to ensure "assetUrlObject" is required (not null)
            if (assetUrlObject == null)
            {
                throw new InvalidDataException("assetUrlObject is a required property for World and cannot be null");
            }
            else
            {
                this.AssetUrlObject = assetUrlObject;
            }

            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for World and cannot be null");
            }
            else
            {
                this.Description = description;
            }

            // to ensure "featured" is required (not null)
            if (featured == null)
            {
                throw new InvalidDataException("featured is a required property for World and cannot be null");
            }
            else
            {
                this.Featured = featured;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for World and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new InvalidDataException("imageUrl is a required property for World and cannot be null");
            }
            else
            {
                this.ImageUrl = imageUrl;
            }

            // to ensure "labsPublicationDate" is required (not null)
            if (labsPublicationDate == null)
            {
                throw new InvalidDataException("labsPublicationDate is a required property for World and cannot be null");
            }
            else
            {
                this.LabsPublicationDate = labsPublicationDate;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for World and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for World and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }

            // to ensure "organization" is required (not null)
            if (organization == null)
            {
                throw new InvalidDataException("organization is a required property for World and cannot be null");
            }
            else
            {
                this.Organization = organization;
            }

            // to ensure "pluginUrlObject" is required (not null)
            if (pluginUrlObject == null)
            {
                throw new InvalidDataException("pluginUrlObject is a required property for World and cannot be null");
            }
            else
            {
                this.PluginUrlObject = pluginUrlObject;
            }

            // to ensure "publicationDate" is required (not null)
            if (publicationDate == null)
            {
                throw new InvalidDataException("publicationDate is a required property for World and cannot be null");
            }
            else
            {
                this.PublicationDate = publicationDate;
            }

            // to ensure "releaseStatus" is required (not null)
            if (releaseStatus == null)
            {
                throw new InvalidDataException("releaseStatus is a required property for World and cannot be null");
            }
            else
            {
                this.ReleaseStatus = releaseStatus;
            }

            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for World and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }

            // to ensure "thumbnailImageUrl" is required (not null)
            if (thumbnailImageUrl == null)
            {
                throw new InvalidDataException("thumbnailImageUrl is a required property for World and cannot be null");
            }
            else
            {
                this.ThumbnailImageUrl = thumbnailImageUrl;
            }

            // to ensure "unityPackageUrlObject" is required (not null)
            if (unityPackageUrlObject == null)
            {
                throw new InvalidDataException("unityPackageUrlObject is a required property for World and cannot be null");
            }
            else
            {
                this.UnityPackageUrlObject = unityPackageUrlObject;
            }

            // to ensure "unityPackages" is required (not null)
            if (unityPackages == null)
            {
                throw new InvalidDataException("unityPackages is a required property for World and cannot be null");
            }
            else
            {
                this.UnityPackages = unityPackages;
            }

            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for World and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }

            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for World and cannot be null");
            }
            else
            {
                this.Version = version;
            }

            this.Instances = instances;
            this.PreviewYoutubeId = previewYoutubeId;
        }

        /// <summary>
        /// Gets or Sets AssetUrl
        /// </summary>
        [DataMember(Name="assetUrl", EmitDefaultValue=true)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Gets or Sets AssetUrlObject
        /// </summary>
        [DataMember(Name="assetUrlObject", EmitDefaultValue=true)]
        public Object AssetUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets AuthorId
        /// </summary>
        [DataMember(Name="authorId", EmitDefaultValue=true)]
        public string AuthorId { get; private set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name="authorName", EmitDefaultValue=true)]
        public string AuthorName { get; private set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="capacity", EmitDefaultValue=true)]
        public decimal Capacity { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=true)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Favorites
        /// </summary>
        [DataMember(Name="favorites", EmitDefaultValue=false)]
        public decimal Favorites { get; private set; }

        /// <summary>
        /// Gets or Sets Featured
        /// </summary>
        [DataMember(Name="featured", EmitDefaultValue=true)]
        public bool Featured { get; set; }

        /// <summary>
        /// Gets or Sets Heat
        /// </summary>
        [DataMember(Name="heat", EmitDefaultValue=true)]
        public decimal Heat { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name="instances", EmitDefaultValue=false)]
        public List<List<Object>> Instances { get; set; }

        /// <summary>
        /// Gets or Sets LabsPublicationDate
        /// </summary>
        [DataMember(Name="labsPublicationDate", EmitDefaultValue=true)]
        public string LabsPublicationDate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name="namespace", EmitDefaultValue=true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Occupants
        /// </summary>
        [DataMember(Name="occupants", EmitDefaultValue=false)]
        public decimal Occupants { get; private set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=true)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets PluginUrlObject
        /// </summary>
        [DataMember(Name="pluginUrlObject", EmitDefaultValue=true)]
        public Object PluginUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets Popularity
        /// </summary>
        [DataMember(Name="popularity", EmitDefaultValue=true)]
        public decimal Popularity { get; private set; }

        /// <summary>
        /// Gets or Sets PreviewYoutubeId
        /// </summary>
        [DataMember(Name="previewYoutubeId", EmitDefaultValue=false)]
        public string PreviewYoutubeId { get; set; }

        /// <summary>
        /// Gets or Sets PrivateOccupants
        /// </summary>
        [DataMember(Name="privateOccupants", EmitDefaultValue=false)]
        public decimal PrivateOccupants { get; private set; }

        /// <summary>
        /// Gets or Sets PublicOccupants
        /// </summary>
        [DataMember(Name="publicOccupants", EmitDefaultValue=false)]
        public decimal PublicOccupants { get; private set; }

        /// <summary>
        /// Gets or Sets PublicationDate
        /// </summary>
        [DataMember(Name="publicationDate", EmitDefaultValue=true)]
        public DateTime PublicationDate { get; set; }


        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        [DataMember(Name="thumbnailImageUrl", EmitDefaultValue=true)]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets UnityPackageUrlObject
        /// </summary>
        [DataMember(Name="unityPackageUrlObject", EmitDefaultValue=true)]
        public Object UnityPackageUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets UnityPackages
        /// </summary>
        [DataMember(Name="unityPackages", EmitDefaultValue=true)]
        public List<UnityPackage> UnityPackages { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public decimal Version { get; set; }

        /// <summary>
        /// Gets or Sets Visits
        /// </summary>
        [DataMember(Name="visits", EmitDefaultValue=true)]
        public decimal Visits { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class World {\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  AssetUrlObject: ").Append(AssetUrlObject).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Favorites: ").Append(Favorites).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  Heat: ").Append(Heat).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  LabsPublicationDate: ").Append(LabsPublicationDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Occupants: ").Append(Occupants).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  PluginUrlObject: ").Append(PluginUrlObject).Append("\n");
            sb.Append("  Popularity: ").Append(Popularity).Append("\n");
            sb.Append("  PreviewYoutubeId: ").Append(PreviewYoutubeId).Append("\n");
            sb.Append("  PrivateOccupants: ").Append(PrivateOccupants).Append("\n");
            sb.Append("  PublicOccupants: ").Append(PublicOccupants).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  ReleaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ThumbnailImageUrl: ").Append(ThumbnailImageUrl).Append("\n");
            sb.Append("  UnityPackageUrlObject: ").Append(UnityPackageUrlObject).Append("\n");
            sb.Append("  UnityPackages: ").Append(UnityPackages).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Visits: ").Append(Visits).Append("\n");
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
            return this.Equals(input as World);
        }

        /// <summary>
        /// Returns true if World instances are equal
        /// </summary>
        /// <param name="input">Instance of World to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(World input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.AssetUrlObject == input.AssetUrlObject ||
                    (this.AssetUrlObject != null &&
                    this.AssetUrlObject.Equals(input.AssetUrlObject))
                ) && 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Favorites == input.Favorites ||
                    (this.Favorites != null &&
                    this.Favorites.Equals(input.Favorites))
                ) && 
                (
                    this.Featured == input.Featured ||
                    (this.Featured != null &&
                    this.Featured.Equals(input.Featured))
                ) && 
                (
                    this.Heat == input.Heat ||
                    (this.Heat != null &&
                    this.Heat.Equals(input.Heat))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Instances == input.Instances ||
                    this.Instances != null &&
                    input.Instances != null &&
                    this.Instances.SequenceEqual(input.Instances)
                ) && 
                (
                    this.LabsPublicationDate == input.LabsPublicationDate ||
                    (this.LabsPublicationDate != null &&
                    this.LabsPublicationDate.Equals(input.LabsPublicationDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Occupants == input.Occupants ||
                    (this.Occupants != null &&
                    this.Occupants.Equals(input.Occupants))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.PluginUrlObject == input.PluginUrlObject ||
                    (this.PluginUrlObject != null &&
                    this.PluginUrlObject.Equals(input.PluginUrlObject))
                ) && 
                (
                    this.Popularity == input.Popularity ||
                    (this.Popularity != null &&
                    this.Popularity.Equals(input.Popularity))
                ) && 
                (
                    this.PreviewYoutubeId == input.PreviewYoutubeId ||
                    (this.PreviewYoutubeId != null &&
                    this.PreviewYoutubeId.Equals(input.PreviewYoutubeId))
                ) && 
                (
                    this.PrivateOccupants == input.PrivateOccupants ||
                    (this.PrivateOccupants != null &&
                    this.PrivateOccupants.Equals(input.PrivateOccupants))
                ) && 
                (
                    this.PublicOccupants == input.PublicOccupants ||
                    (this.PublicOccupants != null &&
                    this.PublicOccupants.Equals(input.PublicOccupants))
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.ReleaseStatus == input.ReleaseStatus ||
                    (this.ReleaseStatus != null &&
                    this.ReleaseStatus.Equals(input.ReleaseStatus))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ThumbnailImageUrl == input.ThumbnailImageUrl ||
                    (this.ThumbnailImageUrl != null &&
                    this.ThumbnailImageUrl.Equals(input.ThumbnailImageUrl))
                ) && 
                (
                    this.UnityPackageUrlObject == input.UnityPackageUrlObject ||
                    (this.UnityPackageUrlObject != null &&
                    this.UnityPackageUrlObject.Equals(input.UnityPackageUrlObject))
                ) && 
                (
                    this.UnityPackages == input.UnityPackages ||
                    this.UnityPackages != null &&
                    input.UnityPackages != null &&
                    this.UnityPackages.SequenceEqual(input.UnityPackages)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Visits == input.Visits ||
                    (this.Visits != null &&
                    this.Visits.Equals(input.Visits))
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
                if (this.AssetUrl != null)
                    hashCode = hashCode * 59 + this.AssetUrl.GetHashCode();
                if (this.AssetUrlObject != null)
                    hashCode = hashCode * 59 + this.AssetUrlObject.GetHashCode();
                if (this.AuthorId != null)
                    hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.AuthorName != null)
                    hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Favorites != null)
                    hashCode = hashCode * 59 + this.Favorites.GetHashCode();
                if (this.Featured != null)
                    hashCode = hashCode * 59 + this.Featured.GetHashCode();
                if (this.Heat != null)
                    hashCode = hashCode * 59 + this.Heat.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.LabsPublicationDate != null)
                    hashCode = hashCode * 59 + this.LabsPublicationDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Occupants != null)
                    hashCode = hashCode * 59 + this.Occupants.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.PluginUrlObject != null)
                    hashCode = hashCode * 59 + this.PluginUrlObject.GetHashCode();
                if (this.Popularity != null)
                    hashCode = hashCode * 59 + this.Popularity.GetHashCode();
                if (this.PreviewYoutubeId != null)
                    hashCode = hashCode * 59 + this.PreviewYoutubeId.GetHashCode();
                if (this.PrivateOccupants != null)
                    hashCode = hashCode * 59 + this.PrivateOccupants.GetHashCode();
                if (this.PublicOccupants != null)
                    hashCode = hashCode * 59 + this.PublicOccupants.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                if (this.ReleaseStatus != null)
                    hashCode = hashCode * 59 + this.ReleaseStatus.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ThumbnailImageUrl != null)
                    hashCode = hashCode * 59 + this.ThumbnailImageUrl.GetHashCode();
                if (this.UnityPackageUrlObject != null)
                    hashCode = hashCode * 59 + this.UnityPackageUrlObject.GetHashCode();
                if (this.UnityPackages != null)
                    hashCode = hashCode * 59 + this.UnityPackages.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Visits != null)
                    hashCode = hashCode * 59 + this.Visits.GetHashCode();
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

            // AssetUrl (string) minLength
            if(this.AssetUrl != null && this.AssetUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetUrl, length must be greater than 1.", new [] { "AssetUrl" });
            }
 

            // AuthorName (string) minLength
            if(this.AuthorName != null && this.AuthorName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorName, length must be greater than 1.", new [] { "AuthorName" });
            }
 

 
            // Capacity (decimal) minimum
            if(this.Capacity < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value greater than or equal to 0.", new [] { "Capacity" });
            }


            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }
 

 
            // Favorites (decimal) minimum
            if(this.Favorites < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Favorites, must be a value greater than or equal to 0.", new [] { "Favorites" });
            }


 
            // Heat (decimal) minimum
            if(this.Heat < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Heat, must be a value greater than or equal to 0.", new [] { "Heat" });
            }


 
            // Id (string) pattern
            Regex regexId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{4}\\-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }


            // ImageUrl (string) minLength
            if(this.ImageUrl != null && this.ImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be greater than 1.", new [] { "ImageUrl" });
            }
 

            // LabsPublicationDate (string) minLength
            if(this.LabsPublicationDate != null && this.LabsPublicationDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LabsPublicationDate, length must be greater than 1.", new [] { "LabsPublicationDate" });
            }
 

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }
 

 
            // Occupants (decimal) minimum
            if(this.Occupants < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Occupants, must be a value greater than or equal to 0.", new [] { "Occupants" });
            }


            // Organization (string) minLength
            if(this.Organization != null && this.Organization.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Organization, length must be greater than 1.", new [] { "Organization" });
            }
 

 
            // Popularity (decimal) minimum
            if(this.Popularity < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Popularity, must be a value greater than or equal to 0.", new [] { "Popularity" });
            }


 
            // PrivateOccupants (decimal) minimum
            if(this.PrivateOccupants < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateOccupants, must be a value greater than or equal to 0.", new [] { "PrivateOccupants" });
            }


 
            // PublicOccupants (decimal) minimum
            if(this.PublicOccupants < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicOccupants, must be a value greater than or equal to 0.", new [] { "PublicOccupants" });
            }


            // ThumbnailImageUrl (string) minLength
            if(this.ThumbnailImageUrl != null && this.ThumbnailImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThumbnailImageUrl, length must be greater than 1.", new [] { "ThumbnailImageUrl" });
            }
 

 

 
            // Version (decimal) minimum
            if(this.Version < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, must be a value greater than or equal to 0.", new [] { "Version" });
            }


 
            // Visits (decimal) minimum
            if(this.Visits < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Visits, must be a value greater than or equal to 0.", new [] { "Visits" });
            }

            yield break;
        }
    }

}
