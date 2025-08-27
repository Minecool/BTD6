namespace System.Web.Util;

public class HttpEncoder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal HttpEncoder <.cctor>b__13_0() { }

	}

	private static Char[] hexChars; //Field offset: 0x0
	private static object entitiesLock; //Field offset: 0x8
	private static Lazy<HttpEncoder> defaultEncoder; //Field offset: 0x10
	private static Lazy<HttpEncoder> currentEncoderLazy; //Field offset: 0x18
	private static HttpEncoder currentEncoder; //Field offset: 0x20

	public static HttpEncoder Current
	{
		 get { } //Length: 202
	}

	private static HttpEncoder() { }

	public HttpEncoder() { }

	public static HttpEncoder get_Current() { }

	private static HttpEncoder GetCustomEncoderFromConfig() { }

	internal static bool NotEncoded(char c) { }

	protected private override Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	internal static void UrlEncodeChar(char c, Stream result, bool isUnicode) { }

	internal static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

}

