// <copyright file="CalculatorSpecs.cs" company="World-Direct">
// Copyright (c) World-Direct. All rights reserved.
// </copyright>

namespace Sonar.Specs
{
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// Contains the specification for the <see cref="Calculator"/> class.
    /// </summary>
    public class CalculatorSpecs
    {
        /// <summary>
        /// The calcutltor can add two numbers.
        /// </summary>
        [Fact]
        public void TheCalculatorCanAdd2Numbers()
        {
            var cut = new Calculator();

            var result = cut.Add(1, 2);

            result.Should().Be(3);
        }
    }
}
