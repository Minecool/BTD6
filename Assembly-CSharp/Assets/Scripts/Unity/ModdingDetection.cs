namespace Assets.Scripts.Unity;

public static class ModdingDetection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FileInfo, String> <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <HasMelonLoader>b__25_0(FileInfo x) { }

	}

	public const string ModDeveloperCommandLineArg_ForDevUseOnlyPlease = "moddingDev"; //Field offset: 0x0
	private static Nullable<Boolean> hasMelonLoader; //Field offset: 0x0
	private static bool isModdedClient; //Field offset: 0x2
	private static string analyticApp; //Field offset: 0x8
	private static string analyticFileNames; //Field offset: 0x10

	public static bool CanShowLoginReminder_PleaseDontMod
	{
		 get { } //Length: 18
	}

	public static bool CanShowModdingWarning_PleaseDontMod
	{
		 get { } //Length: 7
	}

	public static bool CanSubmitLeaderboardScores_UnfairToMod
	{
		 get { } //Length: 18
	}

	public static bool CanUpdateDailyChallengeStats_SillyToMod
	{
		 get { } //Length: 18
	}

	public static bool HasModDeveloperCommandLineArg_PleaseDontMod
	{
		 get { } //Length: 147
	}

	public static bool IsModdedCoop_UnfairToMod
	{
		 get { } //Length: 7
	}

	public static bool IsModdedCrashLog
	{
		 get { } //Length: 7
	}

	public static bool IsModdedStartSession
	{
		 get { } //Length: 7
	}

	public static ValueTuple<String, String> ModdedSessionInfo
	{
		 get { } //Length: 101
	}

	private static bool AreModsEnabled() { }

	public static bool get_CanShowLoginReminder_PleaseDontMod() { }

	public static bool get_CanShowModdingWarning_PleaseDontMod() { }

	public static bool get_CanSubmitLeaderboardScores_UnfairToMod() { }

	public static bool get_CanUpdateDailyChallengeStats_SillyToMod() { }

	public static bool get_HasModDeveloperCommandLineArg_PleaseDontMod() { }

	public static bool get_IsModdedCoop_UnfairToMod() { }

	public static bool get_IsModdedCrashLog() { }

	public static bool get_IsModdedStartSession() { }

	public static ValueTuple<String, String> get_ModdedSessionInfo() { }

	private static ValueTuple<Boolean, String> HasMelonLoader() { }

	private static bool IsModDevArgument(string v) { }

	private static bool IsModdingLibrary(FileInfo fileInfo) { }

}

