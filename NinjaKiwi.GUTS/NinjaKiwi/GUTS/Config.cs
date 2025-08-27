namespace NinjaKiwi.GUTS;

public static class Config
{
	[CompilerGenerated]
	private static int <AppId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static int <SkuId>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static Func<DateTime> <GetServerTime>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static Func<String> <GetLinkSession>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static Environments <Environment>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private static TimeSpan <WebRequestTimeout>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private static Action<String> <Log>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private static Action<String> <LogWarning>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private static Action<String> <LogError>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private static TimeSpan <SweepstakesCacheTime>k__BackingField; //Field offset: 0x40

	internal static string ApiUrl
	{
		internal get { } //Length: 242
	}

	internal static int AppId
	{
		[CompilerGenerated]
		internal get { } //Length: 77
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal static Environments Environment
	{
		[CompilerGenerated]
		internal get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 83
	}

	internal static Func<String> GetLinkSession
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	internal static Func<DateTime> GetServerTime
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	internal static Action<String> Log
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	internal static Action<String> LogError
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	internal static Action<String> LogWarning
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	internal static int SkuId
	{
		[CompilerGenerated]
		internal get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 83
	}

	public static TimeSpan SweepstakesCacheTime
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		 set { } //Length: 85
	}

	public static TimeSpan WebRequestTimeout
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		 set { } //Length: 85
	}

	private static Config() { }

	internal static string get_ApiUrl() { }

	[CompilerGenerated]
	internal static int get_AppId() { }

	[CompilerGenerated]
	internal static Environments get_Environment() { }

	[CompilerGenerated]
	internal static Func<String> get_GetLinkSession() { }

	[CompilerGenerated]
	internal static Func<DateTime> get_GetServerTime() { }

	[CompilerGenerated]
	internal static Action<String> get_Log() { }

	[CompilerGenerated]
	internal static Action<String> get_LogError() { }

	[CompilerGenerated]
	internal static Action<String> get_LogWarning() { }

	[CompilerGenerated]
	internal static int get_SkuId() { }

	[CompilerGenerated]
	public static TimeSpan get_SweepstakesCacheTime() { }

	[CompilerGenerated]
	public static TimeSpan get_WebRequestTimeout() { }

	public static void Initialize(int appId, int skuId, Func<DateTime> getServerTime, Func<String> getLinkSession, Environments environment, Action<String> log = null, Action<String> logWarning = null, Action<String> logError = null) { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_AppId(int value) { }

	[CompilerGenerated]
	private static void set_Environment(Environments value) { }

	[CompilerGenerated]
	private static void set_GetLinkSession(Func<String> value) { }

	[CompilerGenerated]
	private static void set_GetServerTime(Func<DateTime> value) { }

	[CompilerGenerated]
	private static void set_Log(Action<String> value) { }

	[CompilerGenerated]
	private static void set_LogError(Action<String> value) { }

	[CompilerGenerated]
	private static void set_LogWarning(Action<String> value) { }

	[CompilerGenerated]
	private static void set_SkuId(int value) { }

	[CompilerGenerated]
	public static void set_SweepstakesCacheTime(TimeSpan value) { }

	[CompilerGenerated]
	public static void set_WebRequestTimeout(TimeSpan value) { }

	internal static void Validate() { }

}

