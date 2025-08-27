namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class ApplyTowerFreeze : MapSimulationBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Tower tower; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <OnTowerCreated>b__0(FreezeInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_1
	{
		public Tower parentTower; //Field offset: 0x10

		public <>c__DisplayClass4_1() { }

		internal bool <OnTowerCreated>b__1(FreezeInfo x) { }

	}

	internal class FreezeInfo
	{
		public ObjectId towerID; //Field offset: 0x10
		public int nextFreezeRound; //Field offset: 0x14
		public int previousFreezeRound; //Field offset: 0x18

		public FreezeInfo(ObjectId towerID, int nextFreezeRound, int previousFreezeRound) { }

		public void SetRounds(int next, int prev) { }

	}

	private ApplyTowerFreezeModel behaviorModel; //Field offset: 0x58
	public List<FreezeInfo> towerFreezeInfo; //Field offset: 0x60

	public ApplyTowerFreeze() { }

	private void FreezeTower(ObjectId towerID, int roundRemaining) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerRemoved(Tower tower) { }

	private void PlayFreezeSound() { }

	private void RoundEnd(int round) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

