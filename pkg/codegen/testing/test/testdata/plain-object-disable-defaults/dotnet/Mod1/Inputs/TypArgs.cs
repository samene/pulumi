// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Example.Mod1.Inputs
{

    /// <summary>
    /// A test for namespaces (mod 1)
    /// </summary>
    public sealed class TypArgs : Pulumi.ResourceArgs
    {
        [Input("val")]
        public Input<string>? Val { get; set; }

        public TypArgs()
        {
            Val = "mod1";
        }
        public static new TypArgs Empty => new TypArgs();
    }
}
