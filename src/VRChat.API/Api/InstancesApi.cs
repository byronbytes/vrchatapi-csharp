/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.7
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using VRChat.API.Client;
using VRChat.API.Model;

namespace VRChat.API.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstancesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Instance
        /// </summary>
        /// <remarks>
        /// Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>Instance</returns>
        Instance GetInstance(string worldId, string instanceId);

        /// <summary>
        /// Get Instance
        /// </summary>
        /// <remarks>
        /// Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of Instance</returns>
        ApiResponse<Instance> GetInstanceWithHttpInfo(string worldId, string instanceId);
        /// <summary>
        /// Get Instance Short Name
        /// </summary>
        /// <remarks>
        /// Returns an instance short name.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>string</returns>
        string GetShortName(string worldId, string instanceId);

        /// <summary>
        /// Get Instance Short Name
        /// </summary>
        /// <remarks>
        /// Returns an instance short name.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> GetShortNameWithHttpInfo(string worldId, string instanceId);
        /// <summary>
        /// Send Self Invite
        /// </summary>
        /// <remarks>
        /// Sends an invite to the instance to yourself.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>Success</returns>
        Success SendSelfInvite(string worldId, string instanceId);

        /// <summary>
        /// Send Self Invite
        /// </summary>
        /// <remarks>
        /// Sends an invite to the instance to yourself.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of Success</returns>
        ApiResponse<Success> SendSelfInviteWithHttpInfo(string worldId, string instanceId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstancesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Instance
        /// </summary>
        /// <remarks>
        /// Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Instance</returns>
        System.Threading.Tasks.Task<Instance> GetInstanceAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Instance
        /// </summary>
        /// <remarks>
        /// Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Instance)</returns>
        System.Threading.Tasks.Task<ApiResponse<Instance>> GetInstanceWithHttpInfoAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Instance Short Name
        /// </summary>
        /// <remarks>
        /// Returns an instance short name.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> GetShortNameAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Instance Short Name
        /// </summary>
        /// <remarks>
        /// Returns an instance short name.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> GetShortNameWithHttpInfoAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Send Self Invite
        /// </summary>
        /// <remarks>
        /// Sends an invite to the instance to yourself.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Success</returns>
        System.Threading.Tasks.Task<Success> SendSelfInviteAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Send Self Invite
        /// </summary>
        /// <remarks>
        /// Sends an invite to the instance to yourself.
        /// </remarks>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Success)</returns>
        System.Threading.Tasks.Task<ApiResponse<Success>> SendSelfInviteWithHttpInfoAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInstancesApi : IInstancesApiSync, IInstancesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InstancesApi : IInstancesApi
    {
        private VRChat.API.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InstancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstancesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InstancesApi(string basePath)
        {
            this.Configuration = VRChat.API.Client.Configuration.MergeConfigurations(
                VRChat.API.Client.GlobalConfiguration.Instance,
                new VRChat.API.Client.Configuration { BasePath = basePath }
            );
            this.Client = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = VRChat.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstancesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InstancesApi(VRChat.API.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = VRChat.API.Client.Configuration.MergeConfigurations(
                VRChat.API.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new VRChat.API.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = VRChat.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstancesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InstancesApi(VRChat.API.Client.ISynchronousClient client, VRChat.API.Client.IAsynchronousClient asyncClient, VRChat.API.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = VRChat.API.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public VRChat.API.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public VRChat.API.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public VRChat.API.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public VRChat.API.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Instance Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>Instance</returns>
        public Instance GetInstance(string worldId, string instanceId)
        {
            VRChat.API.Client.ApiResponse<Instance> localVarResponse = GetInstanceWithHttpInfo(worldId, instanceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Instance Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of Instance</returns>
        public VRChat.API.Client.ApiResponse<Instance> GetInstanceWithHttpInfo(string worldId, string instanceId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'worldId' when calling InstancesApi->GetInstance");

            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'instanceId' when calling InstancesApi->GetInstance");

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("worldId", VRChat.API.Client.ClientUtils.ParameterToString(worldId)); // path parameter
            localVarRequestOptions.PathParameters.Add("instanceId", VRChat.API.Client.ClientUtils.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Instance>("/instances/{worldId}:{instanceId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstance", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Instance Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Instance</returns>
        public async System.Threading.Tasks.Task<Instance> GetInstanceAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<Instance> localVarResponse = await GetInstanceWithHttpInfoAsync(worldId, instanceId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Instance Returns an instance. Please read [Instances Tutorial](https://vrchatapi.github.io/tutorials/instances/) for more information on Instances.  If an invalid instanceId is provided, this endpoint will simply return \&quot;null\&quot;!
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Instance)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<Instance>> GetInstanceWithHttpInfoAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'worldId' when calling InstancesApi->GetInstance");

            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'instanceId' when calling InstancesApi->GetInstance");


            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("worldId", VRChat.API.Client.ClientUtils.ParameterToString(worldId)); // path parameter
            localVarRequestOptions.PathParameters.Add("instanceId", VRChat.API.Client.ClientUtils.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Instance>("/instances/{worldId}:{instanceId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInstance", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Instance Short Name Returns an instance short name.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>string</returns>
        public string GetShortName(string worldId, string instanceId)
        {
            VRChat.API.Client.ApiResponse<string> localVarResponse = GetShortNameWithHttpInfo(worldId, instanceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Instance Short Name Returns an instance short name.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of string</returns>
        public VRChat.API.Client.ApiResponse<string> GetShortNameWithHttpInfo(string worldId, string instanceId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'worldId' when calling InstancesApi->GetShortName");

            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'instanceId' when calling InstancesApi->GetShortName");

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("worldId", VRChat.API.Client.ClientUtils.ParameterToString(worldId)); // path parameter
            localVarRequestOptions.PathParameters.Add("instanceId", VRChat.API.Client.ClientUtils.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/instances/{worldId}:{instanceId}/shortName", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetShortName", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Instance Short Name Returns an instance short name.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> GetShortNameAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<string> localVarResponse = await GetShortNameWithHttpInfoAsync(worldId, instanceId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Instance Short Name Returns an instance short name.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<string>> GetShortNameWithHttpInfoAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'worldId' when calling InstancesApi->GetShortName");

            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'instanceId' when calling InstancesApi->GetShortName");


            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json"
            };


            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("worldId", VRChat.API.Client.ClientUtils.ParameterToString(worldId)); // path parameter
            localVarRequestOptions.PathParameters.Add("instanceId", VRChat.API.Client.ClientUtils.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<string>("/instances/{worldId}:{instanceId}/shortName", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetShortName", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send Self Invite Sends an invite to the instance to yourself.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>Success</returns>
        public Success SendSelfInvite(string worldId, string instanceId)
        {
            VRChat.API.Client.ApiResponse<Success> localVarResponse = SendSelfInviteWithHttpInfo(worldId, instanceId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send Self Invite Sends an invite to the instance to yourself.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <returns>ApiResponse of Success</returns>
        public VRChat.API.Client.ApiResponse<Success> SendSelfInviteWithHttpInfo(string worldId, string instanceId)
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'worldId' when calling InstancesApi->SendSelfInvite");

            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'instanceId' when calling InstancesApi->SendSelfInvite");

            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("worldId", VRChat.API.Client.ClientUtils.ParameterToString(worldId)); // path parameter
            localVarRequestOptions.PathParameters.Add("instanceId", VRChat.API.Client.ClientUtils.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Success>("/instances/{worldId}:{instanceId}/invite", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendSelfInvite", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Send Self Invite Sends an invite to the instance to yourself.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Success</returns>
        public async System.Threading.Tasks.Task<Success> SendSelfInviteAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            VRChat.API.Client.ApiResponse<Success> localVarResponse = await SendSelfInviteWithHttpInfoAsync(worldId, instanceId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Send Self Invite Sends an invite to the instance to yourself.
        /// </summary>
        /// <exception cref="VRChat.API.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="worldId"></param>
        /// <param name="instanceId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Success)</returns>
        public async System.Threading.Tasks.Task<VRChat.API.Client.ApiResponse<Success>> SendSelfInviteWithHttpInfoAsync(string worldId, string instanceId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'worldId' is set
            if (worldId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'worldId' when calling InstancesApi->SendSelfInvite");

            // verify the required parameter 'instanceId' is set
            if (instanceId == null)
                throw new VRChat.API.Client.ApiException(400, "Missing required parameter 'instanceId' when calling InstancesApi->SendSelfInvite");


            VRChat.API.Client.RequestOptions localVarRequestOptions = new VRChat.API.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = VRChat.API.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = VRChat.API.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("worldId", VRChat.API.Client.ClientUtils.ParameterToString(worldId)); // path parameter
            localVarRequestOptions.PathParameters.Add("instanceId", VRChat.API.Client.ClientUtils.ParameterToString(instanceId)); // path parameter

            // authentication (apiKeyCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }
            // authentication (authCookie) required
            // cookie parameter support
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("auth")))
            {
                localVarRequestOptions.Cookies.Add(new Cookie("auth", this.Configuration.GetApiKeyWithPrefix("auth")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Success>("/instances/{worldId}:{instanceId}/invite", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SendSelfInvite", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
