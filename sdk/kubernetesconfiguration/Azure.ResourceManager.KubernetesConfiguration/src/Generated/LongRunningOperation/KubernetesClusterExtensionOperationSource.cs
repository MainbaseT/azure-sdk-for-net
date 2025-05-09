// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration
{
    internal class KubernetesClusterExtensionOperationSource : IOperationSource<KubernetesClusterExtensionResource>
    {
        private readonly ArmClient _client;

        internal KubernetesClusterExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        KubernetesClusterExtensionResource IOperationSource<KubernetesClusterExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<KubernetesClusterExtensionData>(response.Content);
            return new KubernetesClusterExtensionResource(_client, data);
        }

        async ValueTask<KubernetesClusterExtensionResource> IOperationSource<KubernetesClusterExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<KubernetesClusterExtensionData>(response.Content);
            return await Task.FromResult(new KubernetesClusterExtensionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
