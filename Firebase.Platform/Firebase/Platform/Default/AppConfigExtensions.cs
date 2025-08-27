namespace Firebase.Platform.Default;

internal class AppConfigExtensions : IAppConfigExtensions
{
	private static readonly Uri DefaultUpdateUrl; //Field offset: 0x0
	private static readonly string Default; //Field offset: 0x8
	private static readonly object Sync; //Field offset: 0x10
	private static AppConfigExtensions _instance; //Field offset: 0x18
	private static readonly Dictionary<Int32, Dictionary`2<String, String>> SStringState; //Field offset: 0x20

	public static IAppConfigExtensions Instance
	{
		 get { } //Length: 79
	}

	private static AppConfigExtensions() { }

	protected AppConfigExtensions() { }

	public static IAppConfigExtensions get_Instance() { }

}

