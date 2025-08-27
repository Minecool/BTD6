namespace NinjaKiwi.Common.Analytics;

[CreateAssetMenu(menuName = "Ninja Kiwi/Analytics/Manager")]
public class NKAnalytics : ScriptableObjectSingleton<NKAnalytics>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<AnalyticsService> <>9__14_0; //Field offset: 0x8
		public static Action<AnalyticsService> <>9__15_0; //Field offset: 0x10
		public static Action<AnalyticsService> <>9__19_0; //Field offset: 0x18
		public static Action<AnalyticsService> <>9__48_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal void <_Reset>b__19_0(AnalyticsService s) { }

		internal void <ApplicationQuitting>b__14_0(AnalyticsService s) { }

		internal void <DidReceiveMemoryWarning>b__15_0(AnalyticsService s) { }

		internal void <ResetUserLinkAuth>b__48_0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__44
	{
		public static readonly <>c__44<T> <>9; //Field offset: 0x0
		public static Func<RuntimePlatform, String> <>9__44_0; //Field offset: 0x0

		private static <>c__44`1() { }

		public <>c__44`1() { }

		internal string <_AddService>b__44_0(RuntimePlatform x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public bool pauseStatus; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal void <ApplicationFocusChanged>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public bool isStaging; //Field offset: 0x10
		public string buildId; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <_Initialise>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public AnalyticsData data; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal void <_Send>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public string productId; //Field offset: 0x10
		public string productName; //Field offset: 0x18
		public float price; //Field offset: 0x20
		public string currency; //Field offset: 0x28

		public <>c__DisplayClass30_0() { }

		internal void <_SendIAPEvent>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public AnalyticsData data; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <_SendAttributionEvent>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public int age; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal void <_SetDoNotTrack>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public AnalyticsServiceFilter filter; //Field offset: 0x10
		public Action<AnalyticsService> action; //Field offset: 0x18

		public <>c__DisplayClass46_0() { }

		internal void <DoForEachInitialisedService>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public int appId; //Field offset: 0x10
		public int skuId; //Field offset: 0x14
		public string sessionId; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal void <SetUserLinkAuth>b__0(AnalyticsService s) { }

	}

	[CompilerGenerated]
	private sealed class <Process>d__12 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NKAnalytics <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Process>d__12(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class AnalyticsServiceDescriptor : ISerializationCallbackReceiver
	{
		public AnalyticsService service; //Field offset: 0x10
		[EnumAsCommaDelimitedString(typeof(RuntimePlatform), True)]
		[SerializeField]
		private string platforms; //Field offset: 0x18
		[CompilerGenerated]
		private long <PlatformMask>k__BackingField; //Field offset: 0x20

		public internal long PlatformMask
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			internal set { } //Length: 5
		}

		public AnalyticsServiceDescriptor() { }

		[CompilerGenerated]
		public long get_PlatformMask() { }

		public override void OnAfterDeserialize() { }

		public override void OnBeforeSerialize() { }

		[CompilerGenerated]
		internal void set_PlatformMask(long value) { }

	}

	private class AnalyticsServicesContainer
	{
		public AnalyticsServiceDescriptor[] items; //Field offset: 0x10

		public AnalyticsServicesContainer() { }

	}

	internal sealed class SendHookDelegate : MulticastDelegate
	{

		public SendHookDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AnalyticsData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(AnalyticsData data) { }

	}

	[SerializeField]
	private bool eventsEnabled; //Field offset: 0x18
	[ReorderableList("items", True)]
	[SerializeField]
	private AnalyticsServicesContainer analyticsServices; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Initialised>k__BackingField; //Field offset: 0x28
	private long platformMask; //Field offset: 0x30
	private Dictionary<AnalyticsEventGroup, AnalyticsGroupSettings> groupSettings; //Field offset: 0x38
	public SendHookDelegate sendHook; //Field offset: 0x40
	private string _UserId; //Field offset: 0x48

	public static bool EventsEnabled
	{
		 get { } //Length: 137
		 set { } //Length: 68
	}

	public Dictionary<AnalyticsEventGroup, AnalyticsGroupSettings> GroupSettings
	{
		 get { } //Length: 5
	}

	public private bool Initialised
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public static string UserId
	{
		 get { } //Length: 63
	}

	private void _AddService(T analyticsService, RuntimePlatform[] platforms) { }

	private T _GetService() { }

	private void _Initialise(bool isStaging, string userId, string buildId) { }

	private void _Reset() { }

	private void _Send(AnalyticsData data, AnalyticsEventGroup eventGroup, AnalyticsServiceFilter eventFilter) { }

	private void _SendAttributionEvent(AnalyticsData data, AnalyticsServiceFilter eventFilter) { }

	private void _SendIAPEvent(string productId, string productName, float price, string currency, AnalyticsServiceFilter eventFilter = 3) { }

	private void _SetDoNotTrack(int age) { }

	public void _SetSendHook(SendHookDelegate hook) { }

	private void _SetUserId(string userId) { }

	public NKAnalytics() { }

	public static void AddService(T analyticsService, RuntimePlatform[] platforms) { }

	private void ApplicationFocusChanged(bool pauseStatus) { }

	private void ApplicationQuitting() { }

	private void DidReceiveMemoryWarning() { }

	private void DoForEachInitialisedService(Action<AnalyticsService> action, AnalyticsServiceFilter filter) { }

	private void DoForEachService(Action<AnalyticsService> action) { }

	public static bool get_EventsEnabled() { }

	public Dictionary<AnalyticsEventGroup, AnalyticsGroupSettings> get_GroupSettings() { }

	[CompilerGenerated]
	public bool get_Initialised() { }

	public static string get_UserId() { }

	public static T GetService() { }

	public static void Initialise(bool isStaging, string userId, string buildId = null) { }

	[IteratorStateMachine(typeof(<Process>d__12))]
	private IEnumerator Process() { }

	public static void Reset() { }

	public static void ResetUserLinkAuth() { }

	public static void Send(AnalyticsData data, AnalyticsEventGroup eventGroup = 0, AnalyticsServiceFilter eventFilter = 1) { }

	public static void SendAttributionEvent(AnalyticsData data, AnalyticsServiceFilter eventFilter = 1) { }

	public static void SendIAPEvent(string productId, string productName, float price, string currency, AnalyticsServiceFilter eventFilter = 3) { }

	public static void set_EventsEnabled(bool value) { }

	[CompilerGenerated]
	private void set_Initialised(bool value) { }

	public static void SetDoNotTrack(int age) { }

	public static void SetSendHook(SendHookDelegate hook) { }

	public static void SetUserId(string userId) { }

	public static void SetUserLinkAuth(int appId, int skuId, string sessionId) { }

	private bool ShouldSendForGroup(AnalyticsEventGroup eventGroup) { }

}

