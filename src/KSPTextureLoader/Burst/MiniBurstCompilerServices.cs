using System;

namespace Unity.Burst.CompilerServices;

[AttributeUsage(AttributeTargets.Method)]
internal class IgnoreWarningAttribute : Attribute
{
    public IgnoreWarningAttribute(int warning) { }
}
