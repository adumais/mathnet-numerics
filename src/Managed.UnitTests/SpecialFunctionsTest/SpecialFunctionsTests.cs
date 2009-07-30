﻿// <copyright file="SpecialFunctionsTests.cs" company="Math.NET">
// Math.NET Numerics, part of the Math.NET Project
// http://mathnet.opensourcedotnet.info
//
// Copyright (c) 2009 Math.NET
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// </copyright>

namespace MathNet.Numerics.UnitTests.SpecialFunctionTests
{
    using System;
    using MbUnit.Framework;
    using MathNet.Numerics;

    class SpecialFunctionsTests
    {
        [Test]
        [Row(Double.NaN, Double.NaN)]
        [Row(0.1, 2.2527126517342059020062379568954763844479865649307379)]
        [Row(1.0, 0.0)]
        [Row(1.5, -0.12078223763524522234551844578164721225185272790259947)]
        [Row(Constants.Pi / 2, -0.11590380084550241329912089415904874214542604767006895)]
        [Row(2.0, 0.0)]
        [Row(2.5, 0.28468287047291915963249466968270192432013769555989498)]
        [Row(3.0, 0.693147180559945309417232121458176568075500134360255)]
        [Row(Constants.Pi, 0.82769459232343710152957855845235995115350173412073715)]
        [Row(3.5, 1.2009736023470742248160218814507129957702389154681574)]
        [Row(4.0, 1.7917594692280550008124773583807022727229906921830034)]
        [Row(4.5, 2.4537365708424422205041425034357161573318235106897606)]
        [Row(5.0, 3.1780538303479456196469416012970554088739909609035161)]
        [Row(5.5, 3.9578139676187162938774008558225909985513044919750065)]
        [Row(10.1, 13.02752673863323715481371189614224148681183971709386)]
        public void GammaLn(double x, double f)
        {
            AssertHelpers.AlmostEqual(f, SpecialFunctions.GammaLn(x), 14);
        }

        [Test]
        [Row(Double.NaN, Double.NaN)]
        [Row(-1.5, 2.3632718012073547030642233111215269103967326081631802)]
        [Row(-0.5, -3.544907701811032054596334966682290365595098912244773)]
        [Row(0.1, 9.5135076986687312858079798958252325009137161063903012)]
        [Row(1.0, 1.0)]
        [Row(1.5, 0.88622692545275801364908374167057259139877472806119326)]
        [Row(Constants.Pi / 2, 0.89056089038153932801065963535912100593354196288475879)]
        [Row(2.0, 1.0)]
        [Row(2.5, 1.3293403881791370204736256125058588870981620920917912)]
        [Row(3.0, 2.0)]
        [Row(Constants.Pi, 2.2880377953400324179595889090602339228896881533562229)]
        [Row(3.5, 3.3233509704478425511840640312646472177454052302294767)]
        [Row(4.0, 6.0)]
        [Row(4.5, 11.631728396567448929144224109426265262108918305803166)]
        [Row(5.0, 24.0)]
        [Row(5.5, 52.342777784553520181149008492418193679490132376114268)]
        [Row(10.1, 454760.75144158558537612486797710217749925965322893332)]
        public void Gamma(double x, double f)
        {
            AssertHelpers.AlmostEqual(f, SpecialFunctions.Gamma(x), 13);
        }
    }
}
