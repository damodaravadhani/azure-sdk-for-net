// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CognitiveServices.Vision.Face.Models
{
    using Microsoft.CognitiveServices;
    using Microsoft.CognitiveServices.Vision;
    using Microsoft.CognitiveServices.Vision.Face;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A rectangle within which a face can be found
    /// </summary>
    public partial class FaceRectangle
    {
        /// <summary>
        /// Initializes a new instance of the FaceRectangle class.
        /// </summary>
        public FaceRectangle()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceRectangle class.
        /// </summary>
        /// <param name="width">The width of the rectangle, in pixels.</param>
        /// <param name="height">The height of the rectangle, in
        /// pixels.</param>
        /// <param name="left">The distance from the left edge if the image to
        /// the left edge of the rectangle, in pixels.</param>
        /// <param name="top">The distance from the top edge if the image to
        /// the top edge of the rectangle, in pixels.</param>
        public FaceRectangle(int width, int height, int left, int top)
        {
            Width = width;
            Height = height;
            Left = left;
            Top = top;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the width of the rectangle, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the rectangle, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the distance from the left edge if the image to the
        /// left edge of the rectangle, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public int Left { get; set; }

        /// <summary>
        /// Gets or sets the distance from the top edge if the image to the top
        /// edge of the rectangle, in pixels.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int Top { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
