// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGet.DotnetTool
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            return NuGet.CommandLine.XPlat.Program.MainInternal(args, "nugetcdk");
        }
    }
}
