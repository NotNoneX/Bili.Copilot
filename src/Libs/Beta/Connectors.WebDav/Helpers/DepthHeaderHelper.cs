﻿//<auto-generated/>
using System;

namespace WebDav
{
    internal static class DepthHeaderHelper
    {
        public static string GetValueForPropfind(ApplyTo.Propfind applyTo)
        {
            switch (applyTo)
            {
                case ApplyTo.Propfind.ResourceOnly:
                    return "0";
                case ApplyTo.Propfind.ResourceAndChildren:
                    return "1";
                case ApplyTo.Propfind.ResourceAndAncestors:
                    return "infinity";
                default:
                    throw new ArgumentOutOfRangeException(nameof(applyTo));
            }
        }

        public static string GetValueForCopy(ApplyTo.Copy applyTo)
        {
            switch (applyTo)
            {
                case ApplyTo.Copy.ResourceOnly:
                    return "0";
                case ApplyTo.Copy.ResourceAndAncestors:
                    return "infinity";
                default:
                    throw new ArgumentOutOfRangeException(nameof(applyTo));
            }
        }

        public static string GetValueForLock(ApplyTo.Lock applyTo)
        {
            switch (applyTo)
            {
                case ApplyTo.Lock.ResourceOnly:
                    return "0";
                case ApplyTo.Lock.ResourceAndAncestors:
                    return "infinity";
                default:
                    throw new ArgumentOutOfRangeException(nameof(applyTo));
            }
        }
    }
}