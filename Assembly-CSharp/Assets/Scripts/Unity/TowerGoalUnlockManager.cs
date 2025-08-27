namespace Assets.Scripts.Unity;

public class TowerGoalUnlockManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TowerModel, Boolean> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__4_0(TowerModel tower) { }

	}

	internal class UnlockGoalDef
	{
		public string towerId; //Field offset: 0x10
		public KonFuze goal; //Field offset: 0x18
		public string iapName; //Field offset: 0x20
		public string iapBundleName; //Field offset: 0x28

		public UnlockGoalDef() { }

	}

	private readonly List<UnlockGoalDef> goals; //Field offset: 0x10

	public List<UnlockGoalDef> Goals
	{
		 get { } //Length: 5
	}

	public TowerGoalUnlockManager(GameModel model) { }

	public void AddTowardsCurrentGoal(int amount) { }

	public static bool CanShowGoalStatsAreRecorded() { }

	public void CompleteCurrentGoal() { }

	public void CompleteGoalForTower(string towerId) { }

	public List<UnlockGoalDef> get_Goals() { }

	public int GetCurrentGoal() { }

	private UnlockGoalDef GetCurrentGoalDef(bool checkLevel = true) { }

	public UnlockGoalDef GetGoalDefForTowerId(string towerId) { }

	public string GetIapBundleNameFromIap(string iapName) { }

	public UnlockGoalDef GetNextCompletedGoal() { }

	private UnlockGoalDef GetNextUnachievedGoal() { }

	public int GetProgressForCurrentGoal() { }

	public int GetProgressForTower(string towerId) { }

	public int GetRemaining() { }

	public StoreItem GetStoreItemForTowerInGoal(string towerId) { }

	public string GetTowerForCurrentGoal() { }

	public string GetTowerUnlockedFromIap(string iapName) { }

	public void HardReset() { }

	public bool HasCurrentGoal() { }

	public void InGameDestroyed() { }

	public void InGameInitialised() { }

	public bool IsCurrentGoalCompleted() { }

	public bool IsGiftboxReadyToOpen() { }

	public bool IsLevelLocked() { }

	public bool IsRequirementForGoalReached(string towerId) { }

	public bool IsThereAnUnachievedGoal() { }

	public bool IsTowerUnlockedThroughGoal(string towerId) { }

	private void SetCallbacks() { }

	public void Validate() { }

}

