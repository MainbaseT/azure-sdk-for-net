// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Container resource requirements for sessions of the session pool.
/// </summary>
public partial class SessionContainerResources : ProvisionableConstruct
{
    /// <summary>
    /// Required CPU in cores, e.g. 0.5.
    /// </summary>
    public BicepValue<double> Cpu 
    {
        get { Initialize(); return _cpu!; }
        set { Initialize(); _cpu!.Assign(value); }
    }
    private BicepValue<double>? _cpu;

    /// <summary>
    /// Required memory, e.g. &quot;250Mb&quot;.
    /// </summary>
    public BicepValue<string> Memory 
    {
        get { Initialize(); return _memory!; }
        set { Initialize(); _memory!.Assign(value); }
    }
    private BicepValue<string>? _memory;

    /// <summary>
    /// Creates a new SessionContainerResources.
    /// </summary>
    public SessionContainerResources()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of SessionContainerResources.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _cpu = DefineProperty<double>("Cpu", ["cpu"]);
        _memory = DefineProperty<string>("Memory", ["memory"]);
    }
}
