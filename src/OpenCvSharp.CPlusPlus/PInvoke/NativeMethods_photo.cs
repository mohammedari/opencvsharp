﻿/*
 * (C) 2008-2014 shimat
 * This code is licenced under the LGPL.
 */

using System;
using System.Runtime.InteropServices;

namespace OpenCvSharp.CPlusPlus
{
    internal static partial class NativeMethods
    {
        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void photo_inpaint(IntPtr src, IntPtr inpaintMask,
            IntPtr dst, double inpaintRadius, int flags);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void photo_fastNlMeansDenoising(IntPtr src, IntPtr dst, float h,
            int templateWindowSize, int searchWindowSize);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void photo_fastNlMeansDenoisingColored(IntPtr src, IntPtr dst,
            float h, float hColor, int templateWindowSize, int searchWindowSize);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void photo_fastNlMeansDenoisingMulti(IntPtr[] srcImgs, int srcImgsLength,
            IntPtr dst, int imgToDenoiseIndex, int temporalWindowSize,
            float h, int templateWindowSize, int searchWindowSize);

        [DllImport(DllExtern, CallingConvention = CallingConvention.Cdecl)]
        public static extern void photo_fastNlMeansDenoisingColoredMulti(IntPtr[] srcImgs, int srcImgsLength,
            IntPtr dst, int imgToDenoiseIndex, int temporalWindowSize,
            float h, float hColor, int templateWindowSize, int searchWindowSize);

    }
}