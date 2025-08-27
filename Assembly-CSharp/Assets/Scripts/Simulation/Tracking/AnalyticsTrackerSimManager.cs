namespace Assets.Scripts.Simulation.Tracking;

public class AnalyticsTrackerSimManager : RootBehavior
{
	private Dictionary<Int32, AnalyticsTrackerSim> analyticsSimTrackers; //Field offset: 0x58
	[CompilerGenerated]
	private float <Cs>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private float <Ce>k__BackingField; //Field offset: 0x64

	public AnalyticsTrackerSim AnalyticsTracker
	{
		 get { } //Length: 443
	}

	public private float Ce
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float Cs
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public AnalyticsTrackerSimManager() { }

	public AnalyticsTrackerSim AnalyticsTrackerById(int playerId = 0) { }

	public AnalyticsTrackerSim get_AnalyticsTracker() { }

	[CompilerGenerated]
	public float get_Ce() { }

	[CompilerGenerated]
	public float get_Cs() { }

	public int GetPowerActivatedCount() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void InitialiseTracker(List<Byte> playerNumbers = null) { }

	public void OnCashEarned(int playerId, double cash, CashType from, CashSource source, Tower tower) { }

	public void OnCashSpent(int playerId, double cash, CashType from, CashSource source) { }

	public void OnLivesGained(double amount) { }

	public void OnLivesLost(double amount) { }

	public void OnShieldLost(double amount) { }

	[CompilerGenerated]
	private void set_Ce(float value) { }

	[CompilerGenerated]
	private void set_Cs(float value) { }

}

