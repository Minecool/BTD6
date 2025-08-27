namespace UnityEngine.Analytics;

[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
[NativeHeader("Modules/UnityAnalyticsCommon/Public/UnityAnalyticsCommon.h")]
[NativeHeader("Modules/UnityConnect/UnityConnectSettings.h")]
[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
public static class Analytics
{

	public static AnalyticsResult CustomEvent(string customEventName, IDictionary<String, Object> eventData) { }

	[ThreadSafe]
	internal static bool IsInitialized() { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	private static AnalyticsResult SendCustomEvent(CustomEventData eventData) { }

	private static AnalyticsResult SendCustomEvent_Injected(IntPtr eventData) { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	private static AnalyticsResult SendCustomEventName(string customEventName) { }

	private static AnalyticsResult SendCustomEventName_Injected(ref ManagedSpanWrapper customEventName) { }

	[StaticAccessor("GetUnityAnalytics()", StaticAccessorType::Dot (0))]
	private static AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature) { }

	public static AnalyticsResult Transaction(string productId, decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService) { }

	private static AnalyticsResult Transaction_Injected(ref ManagedSpanWrapper productId, double amount, ref ManagedSpanWrapper currency, ref ManagedSpanWrapper receiptPurchaseData, ref ManagedSpanWrapper signature, bool usingIAPService) { }

}

