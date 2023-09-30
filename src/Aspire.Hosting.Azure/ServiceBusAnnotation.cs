// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Aspire.Hosting.ApplicationModel;

namespace Aspire.Hosting.Azure;

public class ServiceBusAnnotation(string? @namespace): IDistributedApplicationComponentAnnotation
{
    public string? Namespace { get; } = @namespace;
}