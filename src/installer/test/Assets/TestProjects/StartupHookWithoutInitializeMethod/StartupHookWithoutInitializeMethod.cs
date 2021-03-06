// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

internal class StartupHook
{
    public static void Init()
    {
        // This hook should not be called because it doesn't have the
        // correct name (Initialize). Instead, the startup hook
        // provider code should throw an exception.
        Console.WriteLine("Hello from startup hook!");
    }
}
