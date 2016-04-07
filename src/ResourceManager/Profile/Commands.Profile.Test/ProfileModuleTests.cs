﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Resources.Test.ScenarioTests;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.Profile.Test
{
    public class ProfileModuleTests
    {
        public XunitTracingInterceptor xunitLogger;

        public ProfileModuleTests(ITestOutputHelper output)
        {
            xunitLogger = new XunitTracingInterceptor(output);
        }
 
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void WarningOnIncompatibleVersions()
        {
            ProfileController.NewInstance.RunPsTest(
                xunitLogger, 
                "db1ab6f0-4769-4b27-930e-01e2ef9c123c", 
                "Test-LoadProfileModule");
        }
    }
}
