using System;

namespace Snap.ZStandard;

[AttributeUsage(AttributeTargets.All, AllowMultiple =false, Inherited = false)]
internal sealed class NativeTypeNameAttribute : Attribute
{
    public NativeTypeNameAttribute(string value)
    {
    }
}