// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A Class representing an AvsHost along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AvsHostResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAvsHostResource method.
    /// Otherwise you can get one from its parent resource <see cref="AvsPrivateCloudClusterResource"/> using the GetAvsHost method.
    /// </summary>
    public partial class AvsHostResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AvsHostResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="privateCloudName"> The privateCloudName. </param>
        /// <param name="clusterName"> The clusterName. </param>
        /// <param name="hostId"> The hostId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string privateCloudName, string clusterName, string hostId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/hosts/{hostId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _avsHostHostsClientDiagnostics;
        private readonly HostsRestOperations _avsHostHostsRestClient;
        private readonly AvsHostData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AVS/privateClouds/clusters/hosts";

        /// <summary> Initializes a new instance of the <see cref="AvsHostResource"/> class for mocking. </summary>
        protected AvsHostResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvsHostResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AvsHostResource(ArmClient client, AvsHostData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AvsHostResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AvsHostResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _avsHostHostsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Avs", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string avsHostHostsApiVersion);
            _avsHostHostsRestClient = new HostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, avsHostHostsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AvsHostData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Host
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/hosts/{hostId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Host_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AvsHostResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _avsHostHostsClientDiagnostics.CreateScope("AvsHostResource.Get");
            scope.Start();
            try
            {
                var response = await _avsHostHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Host
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AVS/privateClouds/{privateCloudName}/clusters/{clusterName}/hosts/{hostId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Host_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AvsHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AvsHostResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _avsHostHostsClientDiagnostics.CreateScope("AvsHostResource.Get");
            scope.Start();
            try
            {
                var response = _avsHostHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvsHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
