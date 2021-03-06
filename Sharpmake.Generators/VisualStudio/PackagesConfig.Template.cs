// Copyright (c) 2018 Ubisoft Entertainment
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
namespace Sharpmake.Generators.VisualStudio
{
    internal partial class PackagesConfig
    {
        public static class Template
        {
            public static string Begin =
@"<?xml version=""1.0"" encoding=""utf-8""?>
<packages>";

            public static string End =
@"
</packages>";

            public static string DependenciesItem =
@"
  <package id=""[dependency.Name]"" version=""[dependency.Version]"" targetFramework=""[framework]"" />";
        }
    }
}
