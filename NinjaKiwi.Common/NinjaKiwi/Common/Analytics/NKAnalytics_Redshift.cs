namespace NinjaKiwi.Common.Analytics;

[CreateAssetMenu(menuName = "Ninja Kiwi/Analytics/Services/Redshift")]
public class NKAnalytics_Redshift : AnalyticsService
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, DateTime>, String> <>9__39_1; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, DateTime>, DateTime> <>9__39_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Process>b__39_1(KeyValuePair<String, DateTime> kvp) { }

		internal DateTime <Process>b__39_2(KeyValuePair<String, DateTime> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public NKAnalytics_Redshift <>4__this; //Field offset: 0x10
		public QueuedEvent evt; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal void <SendSingleEvent>b__0(long s, string r) { }

		internal void <SendSingleEvent>b__1(long s, string r) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public NKAnalytics_Redshift <>4__this; //Field offset: 0x10
		public IEnumerable<QueuedEvent> evts; //Field offset: 0x18

		public <>c__DisplayClass76_0() { }

		internal void <SendMultiEvent>b__0(long s, string r) { }

		internal void <SendMultiEvent>b__1(long s, string r) { }

	}

	[CompilerGenerated]
	private struct <FlushQueue>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NKAnalytics_Redshift <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendMultiEvent>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NKAnalytics_Redshift <>4__this; //Field offset: 0x20
		public IEnumerable<QueuedEvent> evts; //Field offset: 0x28
		private <>c__DisplayClass76_0 <>8__1; //Field offset: 0x30
		private UnityWebRequest <request>5__2; //Field offset: 0x38
		private UnityWebRequestAsyncOperation <asyncOp>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendSingleEvent>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NKAnalytics_Redshift <>4__this; //Field offset: 0x20
		public QueuedEvent evt; //Field offset: 0x28
		private <>c__DisplayClass74_0 <>8__1; //Field offset: 0x30
		private UnityWebRequest <request>5__2; //Field offset: 0x38
		private UnityWebRequestAsyncOperation <asyncOp>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class AcceptRejectDelegate : MulticastDelegate
	{

		public AcceptRejectDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string eventName, long responseCode, string response, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string eventName, long responseCode, string response) { }

	}

	private class EventPayload
	{
		public string path; //Field offset: 0x10
		public string signature; //Field offset: 0x18
		public string data; //Field offset: 0x20

		public EventPayload() { }

	}

	private struct MultiPayload
	{
		public IEnumerable<EventPayload> events; //Field offset: 0x0

	}

	private class QueuedEvent
	{
		public string name; //Field offset: 0x10
		public float time; //Field offset: 0x18
		public int retries; //Field offset: 0x1C
		public string path; //Field offset: 0x20
		public Dictionary<String, String> data; //Field offset: 0x28

		public QueuedEvent() { }

	}

	private enum RequestResult
	{
		HttpSuccess = 0,
		HttpFailure = 1,
		NetworkError = 2,
	}

	private const string kLogTag = "<color=#FF99F1>[Analytics RS]</color>"; //Field offset: 0x0
	private const string kHeader_LinkAuth_AppId = "nk-appid"; //Field offset: 0x0
	private const string kHeader_Persistence = "x-persistence"; //Field offset: 0x0
	private const string kHeader_Signature = "signature"; //Field offset: 0x0
	private const string kHeader_DNT = "donottrack"; //Field offset: 0x0
	public const string kKeySessionId = "session_id"; //Field offset: 0x0
	public const string kKeySourceGame = "source_game"; //Field offset: 0x0
	public const string kKeyDelta = "_delta"; //Field offset: 0x0
	public const string kKeyCreatedAt = "created_at"; //Field offset: 0x0
	public const string kKeyUserId = "userId"; //Field offset: 0x0
	private static readonly Char[] forbiddenEventNameChars; //Field offset: 0x0
	private const string kTimeStampFormat = "yyyy-MM-dd HH:mm:ss"; //Field offset: 0x0
	private const string kHeader_LinkAuth_SessionId = "nk-sessionid"; //Field offset: 0x0
	private const string kHeader_LinkAuth_SkuId = "nk-skuid"; //Field offset: 0x0
	private static readonly Char[] forbiddenPayloadKeyChars; //Field offset: 0x8
	public bool verbose; //Field offset: 0x28
	public bool sendSessionId; //Field offset: 0x29
	public string gameName; //Field offset: 0x30
	public string stagingHost; //Field offset: 0x38
	public string productionHost; //Field offset: 0x40
	public int maxMultiBundle; //Field offset: 0x48
	public string multiEndpoint; //Field offset: 0x50
	public string PathFormat; //Field offset: 0x58
	public string AttributionPathFormat; //Field offset: 0x60
	public string salt; //Field offset: 0x68
	public int requestTimeout; //Field offset: 0x70
	public int eventRetries; //Field offset: 0x74
	public float bufferEventsForSeconds; //Field offset: 0x78
	public float offlineRetryTimer; //Field offset: 0x7C
	public TimeSpan disabledEventTimespan; //Field offset: 0x80
	public bool persistEvents; //Field offset: 0x88
	private string m_AppVersion; //Field offset: 0x90
	private string m_iSessionId; //Field offset: 0x98
	private Dictionary<String, DateTime> m_DisabledMessages; //Field offset: 0xA0
	private bool isOnline; //Field offset: 0xA8
	private List<QueuedEvent> m_EventQueue; //Field offset: 0xB0
	private List<QueuedEvent> m_SendingEvents; //Field offset: 0xB8
	private bool m_EventsInFlight; //Field offset: 0xC0
	private float m_tUntilFlush; //Field offset: 0xC4
	private NKAnalytics_AuthModel m_authentication; //Field offset: 0xC8
	[CompilerGenerated]
	private AcceptRejectDelegate EventAccepted; //Field offset: 0xD0
	[CompilerGenerated]
	private AcceptRejectDelegate EventRejected; //Field offset: 0xD8
	[CompilerGenerated]
	private string <Host>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private string <Platform>k__BackingField; //Field offset: 0xE8

	public event AcceptRejectDelegate EventAccepted
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event AcceptRejectDelegate EventRejected
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public string Host
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	private static DateTime Now
	{
		private get { } //Length: 64
	}

	public string Platform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string SessionId
	{
		 get { } //Length: 8
	}

	private static string TimeStamp
	{
		private get { } //Length: 184
	}

	private string UserAgent
	{
		private get { } //Length: 26
	}

	private static NKAnalytics_Redshift() { }

	public NKAnalytics_Redshift() { }

	[CompilerGenerated]
	private bool <Process>b__39_0(KeyValuePair<String, DateTime> kvp) { }

	[CompilerGenerated]
	public void add_EventAccepted(AcceptRejectDelegate value) { }

	[CompilerGenerated]
	public void add_EventRejected(AcceptRejectDelegate value) { }

	private Dictionary<String, String> AddDefaultColumns(Dictionary<String, String> eventData, string userId, bool sendCreatedAt, bool sendSessionId) { }

	private EventPayload ConstructPayload(QueuedEvent evt) { }

	private UnityWebRequest ConstructRequest(string url, string data, string signature = null) { }

	[AsyncStateMachine(typeof(<FlushQueue>d__73))]
	private Task FlushQueue() { }

	[CompilerGenerated]
	public string get_Host() { }

	private static DateTime get_Now() { }

	[CompilerGenerated]
	public string get_Platform() { }

	public string get_SessionId() { }

	private static string get_TimeStamp() { }

	private string get_UserAgent() { }

	public virtual void Init(bool isStaging, string buildId) { }

	private RequestResult OnComplete(UnityWebRequest request, Action<Int64, String> onSuccess, Action<Int64, String> onFailure) { }

	private void OnEventAccepted(long responseCode, string response, QueuedEvent evt) { }

	private void OnEventRejected(long responseCode, string response, QueuedEvent evt) { }

	private void OnMultiFailure(long responseCode, string response, IEnumerable<QueuedEvent> events) { }

	private void OnMultiSuccess(long responseCode, string response, IEnumerable<QueuedEvent> events) { }

	public virtual void Process(float dt) { }

	private void Queue(string eventName, string eventPath, Dictionary<String, String> eventData) { }

	[CompilerGenerated]
	public void remove_EventAccepted(AcceptRejectDelegate value) { }

	[CompilerGenerated]
	public void remove_EventRejected(AcceptRejectDelegate value) { }

	private void ReQueue(IEnumerable<QueuedEvent> evts) { }

	private void ReQueue(QueuedEvent evt) { }

	public virtual void Reset() { }

	public virtual void ResetUserLinkAuth() { }

	private string SanitizeEventName(string eventName) { }

	public virtual void SendAttributionEvent(string userId, AnalyticsData data) { }

	public virtual void SendDataEventWithID(string userId, AnalyticsData data) { }

	private void SendEvent(AnalyticsData data, string path, string userId, bool sendCreatedAt, bool sendSessionId) { }

	public virtual void SendIAPEventWithID(string userId, string productId, string productName, float price, string currency) { }

	[AsyncStateMachine(typeof(<SendMultiEvent>d__76))]
	private Task SendMultiEvent(IEnumerable<QueuedEvent> evts) { }

	[AsyncStateMachine(typeof(<SendSingleEvent>d__74))]
	private Task SendSingleEvent(QueuedEvent evt) { }

	[CompilerGenerated]
	public void set_Host(string value) { }

	[CompilerGenerated]
	public void set_Platform(string value) { }

	public virtual void SetUserLinkAuth(int appId, int skuId, string sessionId) { }

}

