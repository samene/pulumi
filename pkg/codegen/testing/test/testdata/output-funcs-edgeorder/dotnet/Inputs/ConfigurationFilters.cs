// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Myedgeorder.Inputs
{

    /// <summary>
    /// Configuration filters
    /// </summary>
    public sealed class ConfigurationFilters : Pulumi.InvokeArgs
    {
        [Input("filterableProperty")]
        private List<Inputs.FilterableProperty>? _filterableProperty;

        /// <summary>
        /// Filters specific to product
        /// </summary>
        public List<Inputs.FilterableProperty> FilterableProperty
        {
            get => _filterableProperty ?? (_filterableProperty = new List<Inputs.FilterableProperty>());
            set => _filterableProperty = value;
        }

        /// <summary>
        /// Product hierarchy information
        /// </summary>
        [Input("hierarchyInformation", required: true)]
        public Inputs.HierarchyInformation HierarchyInformation { get; set; } = null!;

        public ConfigurationFilters()
        {
        }
        public static new ConfigurationFilters Empty => new ConfigurationFilters();
    }
}
