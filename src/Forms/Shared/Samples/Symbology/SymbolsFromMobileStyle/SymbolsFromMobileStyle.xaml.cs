// Copyright 2019 Esri.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at: http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific
// language governing permissions and limitations under the License.

using Esri.ArcGISRuntime.Geometry;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Symbology;
using Esri.ArcGISRuntime.UI;
using Xamarin.Forms;

namespace ArcGISRuntime.Samples.SymbolsFromMobileStyle
{
    [ArcGISRuntime.Samples.Shared.Attributes.Sample(
        "Read symbols from a mobile style",
        "Symbology",
        "Open a local mobile style file (.stylx) and read its contents.",
        "")]
    [ArcGISRuntime.Samples.Shared.Attributes.OfflineData("1bd036f221f54a99abc9e46ff3511cbf")]
    public partial class SymbolsFromMobileStyle : ContentPage
    {
        public SymbolsFromMobileStyle()
        {
            InitializeComponent();

            // Create the UI, setup the control references and execute initialization.
            Initialize();
        }

        private void Initialize()
        {
        }
    }
}