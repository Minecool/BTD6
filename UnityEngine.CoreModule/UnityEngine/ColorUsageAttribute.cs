namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public sealed class ColorUsageAttribute : PropertyAttribute
{
	public readonly bool showAlpha; //Field offset: 0x10
	public readonly bool hdr; //Field offset: 0x11
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minBrightness; //Field offset: 0x14
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxBrightness; //Field offset: 0x18
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minExposureValue; //Field offset: 0x1C
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxExposureValue; //Field offset: 0x20

	public ColorUsageAttribute(bool showAlpha) { }

}

