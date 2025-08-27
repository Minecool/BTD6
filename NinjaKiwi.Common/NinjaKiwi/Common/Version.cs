namespace NinjaKiwi.Common;

public struct Version : IComparable<Version>
{
	public readonly int VersionCode; //Field offset: 0x0
	public readonly int Major; //Field offset: 0x4
	public readonly int Minor; //Field offset: 0x8
	public readonly int Revision; //Field offset: 0xC

	public Version(int versionCode) { }

	public Version(int major, int minor, int revision) { }

	public int CompareMajorMinorTo(Version other) { }

	public override int CompareTo(Version other) { }

	public static Version FromVersionString(string str) { }

	public static string GetMajorMinorVersionString(string version) { }

	public string ToMajorMinorString(string separator) { }

	public virtual string ToString() { }

	public string ToString(string separator) { }

}

