﻿// Copyright 2016, 2017, 2018 TRUMPF Werkzeugmaschinen GmbH + Co. KG.
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

namespace Trumpf.Coparoo.Web.Demo
{
    using System.Linq;

    using Trumpf.Coparoo.Web.PageTests;
    public class SeminareTests : PageObjectTests<Events>
    {
        [PageTest]
        public void CheckSeminarCount()
        {
            Page.On<Events>().SearchFor("praxis qualitätssicherung");
            Await(() => Page.On<Events>().SeminarZeilen.Count()).WaitFor(c => c == 0, "0 seminars in list");
        }
    }
}