namespace UnityEngine.Analytics;

[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
public static class AnalyticsCommon
{

	public static bool ugsAnalyticsEnabled
	{
		 set { } //Length: 230
	}

	[StaticAccessor("GetUnityAnalyticsCommon()", StaticAccessorType::Dot (0))]
	private static bool ugsAnalyticsEnabledInternal
	{
		[NativeMethod("SetUGSAnalyticsUserOptStatus")]
		private set { } //Length: 230
	}

	public static void set_ugsAnalyticsEnabled(bool value) { }

	[NativeMethod("SetUGSAnalyticsUserOptStatus")]
	private static void set_ugsAnalyticsEnabledInternal(bool value) { }

}

