namespace NinjaKiwi.Common.Analytics;

internal static class AnalyticsToStringConvert
{
	private struct AnalyticsToString_Bool : IAnalyticsToString<Boolean>, IAnalyticsToString
	{

		public override string Apply(bool value) { }

	}

	private struct AnalyticsToString_DateTime : IAnalyticsToString<DateTime>, IAnalyticsToString
	{

		public override string Apply(DateTime value) { }

	}

	private struct AnalyticsToString_Default : IAnalyticsToString<T>, IAnalyticsToString
	{

		public override string Apply(T value) { }

	}

	private interface IAnalyticsToString
	{

	}

	private interface IAnalyticsToString : IAnalyticsToString
	{

		public string Apply(T value) { }

	}

	private static Dictionary<Type, IAnalyticsToString> m_Functors; //Field offset: 0x0

	private static AnalyticsToStringConvert() { }

	public static string Apply(T value) { }

}

