namespace UnityEngine.Analytics;

[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
[NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
public static class Analytics
{

	public static AnalyticsResult CustomEvent(string customEventName, IDictionary<String, Object> eventData) { }

	[ThreadSafe]
	internal static bool IsInitialized() { }

	public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey = "", string prefix = "") { }

	private static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo) { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	internal static AnalyticsResult RegisterEventWithLimit(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer) { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	private static AnalyticsResult SendCustomEvent(CustomEventData eventData) { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	private static AnalyticsResult SendCustomEventName(string customEventName) { }

	public static AnalyticsResult SendEvent(string eventName, object parameters, int ver = 1, string prefix = "") { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	[ThreadSafe]
	internal static AnalyticsResult SendEventWithLimit(string eventName, object parameters, int ver, string prefix) { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	private static AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature) { }

	public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

}

