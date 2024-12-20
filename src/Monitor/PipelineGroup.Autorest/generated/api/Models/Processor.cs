// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Extensions;

    /// <summary>Processor Info.</summary>
    public partial class Processor :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessor,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessorInternal
    {

        /// <summary>Backing field for <see cref="Batch" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessor _batch;

        /// <summary>Batch processor configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessor Batch { get => (this._batch = this._batch ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.BatchProcessor()); set => this._batch = value; }

        /// <summary>Size of the batch.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Inlined)]
        public int? BatchSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessorInternal)Batch).BatchSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessorInternal)Batch).BatchSize = value ?? default(int); }

        /// <summary>Timeout in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Inlined)]
        public int? BatchTimeout { get => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessorInternal)Batch).Timeout; set => ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessorInternal)Batch).Timeout = value ?? default(int); }

        /// <summary>Internal Acessors for Batch</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessor Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessorInternal.Batch { get => (this._batch = this._batch ?? new Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.BatchProcessor()); set { {_batch = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IProcessorInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of processor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Batch";

        /// <summary>The type of processor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Processor" /> instance.</summary>
        public Processor()
        {

        }
    }
    /// Processor Info.
    public partial interface IProcessor :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.IJsonSerializable
    {
        /// <summary>Size of the batch.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Size of the batch.",
        SerializedName = @"batchSize",
        PossibleTypes = new [] { typeof(int) })]
        int? BatchSize { get; set; }
        /// <summary>Timeout in milliseconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Timeout in milliseconds.",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(int) })]
        int? BatchTimeout { get; set; }
        /// <summary>The name of processor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of processor.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The type of processor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of processor.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Processor Info.
    internal partial interface IProcessorInternal

    {
        /// <summary>Batch processor configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.IBatchProcessor Batch { get; set; }
        /// <summary>Size of the batch.</summary>
        int? BatchSize { get; set; }
        /// <summary>Timeout in milliseconds.</summary>
        int? BatchTimeout { get; set; }
        /// <summary>The name of processor.</summary>
        string Name { get; set; }
        /// <summary>The type of processor.</summary>
        string Type { get; set; }

    }
}