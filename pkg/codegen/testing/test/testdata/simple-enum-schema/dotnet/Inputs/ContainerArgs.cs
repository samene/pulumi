// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Plant.Inputs
{

    public sealed class ContainerArgs : Pulumi.ResourceArgs
    {
        [Input("brightness")]
        public Input<Pulumi.Plant.ContainerBrightness>? Brightness { get; set; }

        [Input("color")]
        public InputUnion<Pulumi.Plant.ContainerColor, string>? Color { get; set; }

        [Input("material")]
        public Input<string>? Material { get; set; }

        [Input("size", required: true)]
        public Input<Pulumi.Plant.ContainerSize> Size { get; set; } = null!;

        public ContainerArgs()
        {
            Brightness = Pulumi.Plant.ContainerBrightness.One;
        }
        public static new ContainerArgs Empty => new ContainerArgs();
    }
}
