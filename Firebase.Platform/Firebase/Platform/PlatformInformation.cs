namespace Firebase.Platform;

internal static class PlatformInformation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String> <>9__6_0; //Field offset: 0x8
		public static Func<String> <>9__18_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <get_DefaultConfigLocation>b__6_0() { }

		internal string <get_RuntimeVersion>b__18_0() { }

	}

	private static string runtimeVersion; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static float <RealtimeSinceStartupSafe>k__BackingField; //Field offset: 0x8

	internal static string DefaultConfigLocation
	{
		internal get { } //Length: 261
	}

	internal static bool IsAndroid
	{
		internal get { } //Length: 71
	}

	internal static bool IsIOS
	{
		internal get { } //Length: 114
	}

	internal static float RealtimeSinceStartup
	{
		internal get { } //Length: 9
	}

	internal static float RealtimeSinceStartupSafe
	{
		[CompilerGenerated]
		internal set { } //Length: 69
	}

	internal static string RuntimeName
	{
		internal get { } //Length: 44
	}

	internal static string RuntimeVersion
	{
		internal get { } //Length: 339
	}

	internal static string get_DefaultConfigLocation() { }

	internal static bool get_IsAndroid() { }

	internal static bool get_IsIOS() { }

	internal static float get_RealtimeSinceStartup() { }

	internal static string get_RuntimeName() { }

	internal static string get_RuntimeVersion() { }

	[CompilerGenerated]
	internal static void set_RealtimeSinceStartupSafe(float value) { }

}

