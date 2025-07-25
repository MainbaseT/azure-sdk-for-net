// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the options for creating or updating a project deployment. </summary>
    public partial class ConversationAuthoringCreateDeploymentDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringCreateDeploymentDetails"/>. </summary>
        /// <param name="trainedModelLabel"> Represents the trained model label. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trainedModelLabel"/> is null. </exception>
        public ConversationAuthoringCreateDeploymentDetails(string trainedModelLabel)
        {
            Argument.AssertNotNull(trainedModelLabel, nameof(trainedModelLabel));

            TrainedModelLabel = trainedModelLabel;
            AssignedResources = new ChangeTrackingList<ConversationAuthoringDeploymentResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringCreateDeploymentDetails"/>. </summary>
        /// <param name="trainedModelLabel"> Represents the trained model label. </param>
        /// <param name="assignedResources"> Represents the resources to be assigned to the deployment. If provided, the deployment will be rolled out to the resources provided here as well as the original resource in which the project is created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationAuthoringCreateDeploymentDetails(string trainedModelLabel, IList<ConversationAuthoringDeploymentResource> assignedResources, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TrainedModelLabel = trainedModelLabel;
            AssignedResources = assignedResources;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringCreateDeploymentDetails"/> for deserialization. </summary>
        internal ConversationAuthoringCreateDeploymentDetails()
        {
        }

        /// <summary> Represents the trained model label. </summary>
        public string TrainedModelLabel { get; }
        /// <summary> Represents the resources to be assigned to the deployment. If provided, the deployment will be rolled out to the resources provided here as well as the original resource in which the project is created. </summary>
        public IList<ConversationAuthoringDeploymentResource> AssignedResources { get; }
    }
}
