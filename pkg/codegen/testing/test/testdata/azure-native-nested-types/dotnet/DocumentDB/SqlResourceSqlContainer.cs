// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.DocumentDB
{
    /// <summary>
    /// An Azure Cosmos DB container.
    /// API Version: 2021-03-15.
    /// 
    /// ## Example Usage
    /// ### CosmosDBSqlContainerCreateUpdate
    /// ```csharp
    /// using Pulumi;
    /// using AzureNative = Pulumi.AzureNative;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var sqlResourceSqlContainer = new AzureNative.DocumentDB.SqlResourceSqlContainer("sqlResourceSqlContainer", new AzureNative.DocumentDB.SqlResourceSqlContainerArgs
    ///         {
    ///             AccountName = "ddb1",
    ///             ContainerName = "containerName",
    ///             DatabaseName = "databaseName",
    ///             Location = "West US",
    ///             Options = ,
    ///             Resource = new AzureNative.DocumentDB.Inputs.SqlContainerResourceArgs
    ///             {
    ///                 ConflictResolutionPolicy = new AzureNative.DocumentDB.Inputs.ConflictResolutionPolicyArgs
    ///                 {
    ///                     ConflictResolutionPath = "/path",
    ///                     Mode = "LastWriterWins",
    ///                 },
    ///                 DefaultTtl = 100,
    ///                 Id = "containerName",
    ///                 IndexingPolicy = new AzureNative.DocumentDB.Inputs.IndexingPolicyArgs
    ///                 {
    ///                     Automatic = true,
    ///                     ExcludedPaths = {},
    ///                     IncludedPaths = 
    ///                     {
    ///                         new AzureNative.DocumentDB.Inputs.IncludedPathArgs
    ///                         {
    ///                             Indexes = 
    ///                             {
    ///                                 new AzureNative.DocumentDB.Inputs.IndexesArgs
    ///                                 {
    ///                                     DataType = "String",
    ///                                     Kind = "Range",
    ///                                     Precision = -1,
    ///                                 },
    ///                                 new AzureNative.DocumentDB.Inputs.IndexesArgs
    ///                                 {
    ///                                     DataType = "Number",
    ///                                     Kind = "Range",
    ///                                     Precision = -1,
    ///                                 },
    ///                             },
    ///                             Path = "/*",
    ///                         },
    ///                     },
    ///                     IndexingMode = "consistent",
    ///                 },
    ///                 PartitionKey = new AzureNative.DocumentDB.Inputs.ContainerPartitionKeyArgs
    ///                 {
    ///                     Kind = "Hash",
    ///                     Paths = 
    ///                     {
    ///                         "/AccountNumber",
    ///                     },
    ///                 },
    ///                 UniqueKeyPolicy = new AzureNative.DocumentDB.Inputs.UniqueKeyPolicyArgs
    ///                 {
    ///                     UniqueKeys = 
    ///                     {
    ///                         new AzureNative.DocumentDB.Inputs.UniqueKeyArgs
    ///                         {
    ///                             Paths = 
    ///                             {
    ///                                 "/testPath",
    ///                             },
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             ResourceGroupName = "rg1",
    ///             Tags = ,
    ///         });
    ///     }
    /// 
    /// }
    /// 
    /// ```
    /// 
    /// ## Import
    /// 
    /// An existing resource can be imported using its type token, name, and identifier, e.g.
    /// 
    /// ```sh
    /// $ pulumi import azure-native:documentdb:SqlResourceSqlContainer containerName /subscriptions/subid/resourceGroups/rg1/providers/Microsoft.DocumentDB/databaseAccounts/ddb1/sqlDatabases/databaseName/sqlContainers/containerName 
    /// ```
    /// </summary>
    [AzureNativeResourceType("azure-native:documentdb:SqlResourceSqlContainer")]
    public partial class SqlResourceSqlContainer : Pulumi.CustomResource
    {
        [Output("resource")]
        public Output<Outputs.SqlContainerGetPropertiesResponseResource?> Resource { get; private set; } = null!;


        /// <summary>
        /// Create a SqlResourceSqlContainer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SqlResourceSqlContainer(string name, SqlResourceSqlContainerArgs? args = null, CustomResourceOptions? options = null)
            : base("azure-native:documentdb:SqlResourceSqlContainer", name, args ?? new SqlResourceSqlContainerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SqlResourceSqlContainer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-native:documentdb:SqlResourceSqlContainer", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing SqlResourceSqlContainer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SqlResourceSqlContainer Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SqlResourceSqlContainer(name, id, options);
        }
    }

    public sealed class SqlResourceSqlContainerArgs : Pulumi.ResourceArgs
    {
        public SqlResourceSqlContainerArgs()
        {
        }
        public static new SqlResourceSqlContainerArgs Empty => new SqlResourceSqlContainerArgs();
    }
}
