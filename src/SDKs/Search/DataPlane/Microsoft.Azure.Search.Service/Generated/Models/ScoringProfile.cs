// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines parameters for an Azure Search index that influence scoring in
    /// search queries.
    /// <see
    /// href="https://docs.microsoft.com/rest/api/searchservice/Add-scoring-profiles-to-a-search-index"
    /// />
    /// </summary>
    public partial class ScoringProfile
    {
        /// <summary>
        /// Initializes a new instance of the ScoringProfile class.
        /// </summary>
        public ScoringProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScoringProfile class.
        /// </summary>
        /// <param name="name">The name of the scoring profile.</param>
        /// <param name="textWeights">Parameters that boost scoring based on
        /// text matches in certain index fields.</param>
        /// <param name="functions">The collection of functions that influence
        /// the scoring of documents.</param>
        /// <param name="functionAggregation">A value indicating how the
        /// results of individual scoring functions should be combined.
        /// Defaults to "Sum". Ignored if there are no scoring functions.
        /// Possible values include: 'sum', 'average', 'minimum', 'maximum',
        /// 'firstMatching'</param>
        public ScoringProfile(string name, TextWeights textWeights = default(TextWeights), IList<ScoringFunction> functions = default(IList<ScoringFunction>), ScoringFunctionAggregation? functionAggregation = default(ScoringFunctionAggregation?))
        {
            Name = name;
            TextWeights = textWeights;
            Functions = functions;
            FunctionAggregation = functionAggregation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the scoring profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets parameters that boost scoring based on text matches in
        /// certain index fields.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public TextWeights TextWeights { get; set; }

        /// <summary>
        /// Gets or sets the collection of functions that influence the scoring
        /// of documents.
        /// </summary>
        [JsonProperty(PropertyName = "functions")]
        public IList<ScoringFunction> Functions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating how the results of individual
        /// scoring functions should be combined. Defaults to "Sum". Ignored if
        /// there are no scoring functions. Possible values include: 'sum',
        /// 'average', 'minimum', 'maximum', 'firstMatching'
        /// </summary>
        [JsonProperty(PropertyName = "functionAggregation")]
        public ScoringFunctionAggregation? FunctionAggregation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (TextWeights != null)
            {
                TextWeights.Validate();
            }
            if (Functions != null)
            {
                foreach (var element in Functions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
