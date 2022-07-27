// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Example
{
    [ExampleResourceType("example::Person")]
    public partial class Person : Pulumi.CustomResource
    {
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        [Output("pets")]
        public Output<ImmutableArray<Outputs.Pet>> Pets { get; private set; } = null!;


        /// <summary>
        /// Create a Person resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Person(string name, PersonArgs? args = null, CustomResourceOptions? options = null)
            : base("example::Person", name, args ?? new PersonArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Person(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("example::Person", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Person resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Person Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Person(name, id, options);
        }
    }

    public sealed class PersonArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("pets")]
        private InputList<Inputs.PetArgs>? _pets;
        public InputList<Inputs.PetArgs> Pets
        {
            get => _pets ?? (_pets = new InputList<Inputs.PetArgs>());
            set => _pets = value;
        }

        public PersonArgs()
        {
        }
        public static new PersonArgs Empty => new PersonArgs();
    }
}
