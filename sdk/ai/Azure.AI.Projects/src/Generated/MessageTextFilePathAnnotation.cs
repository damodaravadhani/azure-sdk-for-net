// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Projects
{
    /// <summary> A citation within the message that points to a file located at a specific path. </summary>
    public partial class MessageTextFilePathAnnotation : MessageTextAnnotation
    {
        /// <summary> Initializes a new instance of <see cref="MessageTextFilePathAnnotation"/>. </summary>
        /// <param name="type"> The object type. </param>
        /// <param name="text"> The textual content associated with this text annotation item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="internalDetails"> A URL for the file that's generated when the agent used the code_interpreter tool to generate a file. </param>
        /// <param name="startIndex"> The first text index associated with this text annotation. </param>
        /// <param name="endIndex"> The last text index associated with this text annotation. </param>
        internal MessageTextFilePathAnnotation(string type, string text, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalMessageTextFilePathDetails internalDetails, int? startIndex, int? endIndex) : base(type, text, serializedAdditionalRawData)
        {
            InternalDetails = internalDetails;
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTextFilePathAnnotation"/> for deserialization. </summary>
        internal MessageTextFilePathAnnotation()
        {
        }
        /// <summary> The first text index associated with this text annotation. </summary>
        public int? StartIndex { get; }
        /// <summary> The last text index associated with this text annotation. </summary>
        public int? EndIndex { get; }
    }
}
