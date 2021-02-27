﻿// Copyright (c) 2021 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Reactive.Linq;
using ReactiveUI.Fody.Helpers;
using Xunit;

namespace ReactiveUI.Fody.Tests
{
    /// <summary>
    /// Tests for the ObservableAsPropertyAttribute.
    /// </summary>
    public class ObservableAsPropertyTests
    {
        /// <summary>
        /// Confirms the mock generated class returns the correct value.
        /// </summary>
        [Fact]
        public void TestPropertyReturnsFoo()
        {
            var model = new ObservableAsTestModel();
            Assert.Equal("foo", model.TestProperty);
        }
    }
}
