// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Example.Inputs
{

    public sealed class ObjectWithNodeOptionalInputsArgs : Pulumi.ResourceArgs
    {
        [Input("bar")]
        public Input<int>? Bar { get; set; }

        [Input("foo", required: true)]
        public Input<string> Foo { get; set; } = null!;

        public ObjectWithNodeOptionalInputsArgs()
        {
        }
        public static new ObjectWithNodeOptionalInputsArgs Empty => new ObjectWithNodeOptionalInputsArgs();
    }
}
