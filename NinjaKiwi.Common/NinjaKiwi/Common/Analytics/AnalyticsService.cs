namespace NinjaKiwi.Common.Analytics;

public abstract class AnalyticsService : ScriptableObject
{
	public AnalyticsServiceFilter serviceFilter; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Initialised>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x1D
	[CompilerGenerated]
	private int <DoNotTrack>k__BackingField; //Field offset: 0x20

	public int DoNotTrack
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Initialised
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected AnalyticsService() { }

	public override void AppPause(bool pauseStatus) { }

	public override void AppWillQuit() { }

	public override void DidReceiveMemoryWarning() { }

	[CompilerGenerated]
	public int get_DoNotTrack() { }

	[CompilerGenerated]
	public bool get_Enabled() { }

	[CompilerGenerated]
	public bool get_Initialised() { }

	public override void Init(bool isStaging, string buildId) { }

	public override bool PassFilter(AnalyticsServiceFilter serviceFilter) { }

	public override void Process(float dt) { }

	public override void Reset() { }

	public abstract void ResetUserLinkAuth() { }

	public override void SendAttributionEvent(string userId, AnalyticsData data) { }

	public override void SendDataEventWithID(string userId, AnalyticsData data) { }

	public override void SendIAPEventWithID(string userId, string productId, string productName, float price, string currency) { }

	[CompilerGenerated]
	public void set_DoNotTrack(int value) { }

	[CompilerGenerated]
	public void set_Enabled(bool value) { }

	[CompilerGenerated]
	protected void set_Initialised(bool value) { }

	public override void SetUser(string name) { }

	public abstract void SetUserLinkAuth(int appId, int skuId, string sessionId) { }

}

