﻿// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions.NumberToAmplitudeRatio
{
    public static class NumberToAmplitudeRatioExtensions
    {
        #region DecibelMicrovolt

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double)"/>
        public static AmplitudeRatio DecibelMicrovolts(this int value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double?)"/>
        public static AmplitudeRatio? DecibelMicrovolts(this int? value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double)"/>
        public static AmplitudeRatio DecibelMicrovolts(this long value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double?)"/>
        public static AmplitudeRatio? DecibelMicrovolts(this long? value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double)"/>
        public static AmplitudeRatio DecibelMicrovolts(this double value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double?)"/>
        public static AmplitudeRatio? DecibelMicrovolts(this double? value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double)"/>
        public static AmplitudeRatio DecibelMicrovolts(this float value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double?)"/>
        public static AmplitudeRatio? DecibelMicrovolts(this float? value) => AmplitudeRatio.FromDecibelMicrovolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double)"/>
        public static AmplitudeRatio DecibelMicrovolts(this decimal value) => AmplitudeRatio.FromDecibelMicrovolts(Convert.ToDouble(value));

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMicrovolts(double?)"/>
        public static AmplitudeRatio? DecibelMicrovolts(this decimal? value) => AmplitudeRatio.FromDecibelMicrovolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecibelMillivolt

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double)"/>
        public static AmplitudeRatio DecibelMillivolts(this int value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double?)"/>
        public static AmplitudeRatio? DecibelMillivolts(this int? value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double)"/>
        public static AmplitudeRatio DecibelMillivolts(this long value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double?)"/>
        public static AmplitudeRatio? DecibelMillivolts(this long? value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double)"/>
        public static AmplitudeRatio DecibelMillivolts(this double value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double?)"/>
        public static AmplitudeRatio? DecibelMillivolts(this double? value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double)"/>
        public static AmplitudeRatio DecibelMillivolts(this float value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double?)"/>
        public static AmplitudeRatio? DecibelMillivolts(this float? value) => AmplitudeRatio.FromDecibelMillivolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double)"/>
        public static AmplitudeRatio DecibelMillivolts(this decimal value) => AmplitudeRatio.FromDecibelMillivolts(Convert.ToDouble(value));

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelMillivolts(double?)"/>
        public static AmplitudeRatio? DecibelMillivolts(this decimal? value) => AmplitudeRatio.FromDecibelMillivolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecibelUnloaded

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double)"/>
        public static AmplitudeRatio DecibelsUnloaded(this int value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double?)"/>
        public static AmplitudeRatio? DecibelsUnloaded(this int? value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double)"/>
        public static AmplitudeRatio DecibelsUnloaded(this long value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double?)"/>
        public static AmplitudeRatio? DecibelsUnloaded(this long? value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double)"/>
        public static AmplitudeRatio DecibelsUnloaded(this double value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double?)"/>
        public static AmplitudeRatio? DecibelsUnloaded(this double? value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double)"/>
        public static AmplitudeRatio DecibelsUnloaded(this float value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double?)"/>
        public static AmplitudeRatio? DecibelsUnloaded(this float? value) => AmplitudeRatio.FromDecibelsUnloaded(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double)"/>
        public static AmplitudeRatio DecibelsUnloaded(this decimal value) => AmplitudeRatio.FromDecibelsUnloaded(Convert.ToDouble(value));

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelsUnloaded(double?)"/>
        public static AmplitudeRatio? DecibelsUnloaded(this decimal? value) => AmplitudeRatio.FromDecibelsUnloaded(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecibelVolt

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double)"/>
        public static AmplitudeRatio DecibelVolts(this int value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double?)"/>
        public static AmplitudeRatio? DecibelVolts(this int? value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double)"/>
        public static AmplitudeRatio DecibelVolts(this long value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double?)"/>
        public static AmplitudeRatio? DecibelVolts(this long? value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double)"/>
        public static AmplitudeRatio DecibelVolts(this double value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double?)"/>
        public static AmplitudeRatio? DecibelVolts(this double? value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double)"/>
        public static AmplitudeRatio DecibelVolts(this float value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double?)"/>
        public static AmplitudeRatio? DecibelVolts(this float? value) => AmplitudeRatio.FromDecibelVolts(value);

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double)"/>
        public static AmplitudeRatio DecibelVolts(this decimal value) => AmplitudeRatio.FromDecibelVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="AmplitudeRatio.FromDecibelVolts(double?)"/>
        public static AmplitudeRatio? DecibelVolts(this decimal? value) => AmplitudeRatio.FromDecibelVolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif