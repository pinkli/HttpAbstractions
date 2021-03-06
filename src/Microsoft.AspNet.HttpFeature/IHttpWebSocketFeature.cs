// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

#if NET45
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.Framework.Runtime;

namespace Microsoft.AspNet.HttpFeature
{
    [AssemblyNeutral]
    public interface IHttpWebSocketFeature
    {
        bool IsWebSocketRequest { get; set; }
        Task<WebSocket> AcceptAsync();
    }
}
#endif