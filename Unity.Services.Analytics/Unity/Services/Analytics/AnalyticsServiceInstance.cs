namespace Unity.Services.Analytics;

internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder, IBufferIds
{
	public enum ConsentFlow
	{
		Neither = 0,
		Old = 1,
		New = 2,
	}

	private const string k_ForgetCallingId = "com.unity.services.analytics.Events.OptOut"; //Field offset: 0x0
	private const string m_StartUpCallingId = "com.unity.services.analytics.Events.Startup"; //Field offset: 0x0
	private readonly TimeSpan k_BackgroundSessionRefreshPeriod; //Field offset: 0x10
	private readonly StdCommonParams m_CommonParams; //Field offset: 0x18
	private readonly IPlayerId m_PlayerId; //Field offset: 0x20
	private readonly IInstallationId m_InstallId; //Field offset: 0x28
	private readonly IDataGenerator m_DataGenerator; //Field offset: 0x30
	private readonly ICoreStatsHelper m_CoreStatsHelper; //Field offset: 0x38
	private readonly IConsentTracker m_ConsentTracker; //Field offset: 0x40
	private readonly IDispatcher m_DataDispatcher; //Field offset: 0x48
	private readonly IAnalyticsForgetter m_AnalyticsForgetter; //Field offset: 0x50
	private readonly IExternalUserId m_CustomUserId; //Field offset: 0x58
	private readonly IAnalyticsServiceSystemCalls m_SystemCalls; //Field offset: 0x60
	private readonly IAnalyticsContainer m_Container; //Field offset: 0x68
	internal IBuffer m_DataBuffer; //Field offset: 0x70
	[CompilerGenerated]
	private string <SessionID>k__BackingField; //Field offset: 0x78
	private int m_BufferLengthAtLastGameRunning; //Field offset: 0x80
	private DateTime m_ApplicationPauseTime; //Field offset: 0x88
	private bool m_IsActive; //Field offset: 0x90
	private ConsentFlow m_ConsentFlow; //Field offset: 0x94
	private bool m_StartUpEventsRecorded; //Field offset: 0x98
	private readonly TransactionCurrencyConverter converter; //Field offset: 0xA0

	internal int AutoflushPeriodMultiplier
	{
		internal get { } //Length: 99
	}

	internal string CustomAnalyticsId
	{
		internal get { } //Length: 70
	}

	public override string InstallId
	{
		 get { } //Length: 70
	}

	public override string PlayerId
	{
		 get { } //Length: 73
	}

	public override string SessionId
	{
		 get { } //Length: 70
	}

	public private override string SessionID
	{
		[CompilerGenerated]
		 get { } //Length: 70
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public override string UserId
	{
		 get { } //Length: 190
	}

	internal AnalyticsServiceInstance(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IConsentTracker consentTracker, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IInstallationId installId, IPlayerId playerId, string environment, IExternalUserId customAnalyticsId, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container) { }

	internal void ApplicationPaused(bool paused) { }

	internal void ApplicationQuit() { }

	public override long ConvertCurrencyToMinorUnits(string currencyCode, double value) { }

	public override void CustomData(string eventName, IDictionary<String, Object> eventParams, Nullable<Int32> eventVersion, bool includeCommonParams, bool includePlayerIds, string callingMethodIdentifier) { }

	private void DataDeletionCompleted() { }

	private void Deactivate() { }

	internal void DeactivateWithDataDeletionRequest() { }

	public override void Flush() { }

	internal int get_AutoflushPeriodMultiplier() { }

	internal string get_CustomAnalyticsId() { }

	public override string get_InstallId() { }

	public override string get_PlayerId() { }

	public override string get_SessionId() { }

	[CompilerGenerated]
	public override string get_SessionID() { }

	public override string get_UserId() { }

	public override string GetAnalyticsUserID() { }

	internal void OldForgetMeEventUploaded() { }

	internal void RecordGameRunningIfNecessary() { }

	internal void RefreshSessionID() { }

	internal void ResumeDataDeletionIfNecessary() { }

	private void SerializeObject(string eventName, string key, object value) { }

	[CompilerGenerated]
	private void set_SessionID(string value) { }

	private void SetVariableCommonParams() { }

}

