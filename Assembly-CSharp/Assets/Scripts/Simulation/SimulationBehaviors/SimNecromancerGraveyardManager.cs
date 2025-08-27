namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class SimNecromancerGraveyardManager : SimulationBehavior
{
	[CompilerGenerated]
	private sealed class <NecroTowers>d__23 : IEnumerable<KeyValuePair`2<ObjectId, NecroData>>, IEnumerable, IEnumerator<KeyValuePair`2<ObjectId, NecroData>>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair<ObjectId, NecroData> <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		public SimNecromancerGraveyardManager <>4__this; //Field offset: 0x30
		private Enumerator<ObjectId, List<NecroData>> <>7__wrap1; //Field offset: 0x38

		private override KeyValuePair<ObjectId, NecroData> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Assets.Scripts.ObjectId,Assets.Scripts.Simulation.SimulationBehaviors.NecroData>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 69
		}

		[DebuggerHidden]
		public <NecroTowers>d__23(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<KeyValuePair`2<ObjectId, NecroData>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Assets.Scripts.ObjectId,Assets.Scripts.Simulation.SimulationBehaviors.NecroData>>.GetEnumerator() { }

		[DebuggerHidden]
		private override KeyValuePair<ObjectId, NecroData> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Assets.Scripts.ObjectId,Assets.Scripts.Simulation.SimulationBehaviors.NecroData>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private SimNecromancerGraveyardManagerModel simNecromancerGraveyardManagerModel; //Field offset: 0x58
	private Dictionary<ObjectId, List`1<NecroData>> necroTowers; //Field offset: 0x60
	private Tower towerNecroTier5; //Field offset: 0x68
	private ObjectId bloonIdLastChecked; //Field offset: 0x70
	private ObjectId bloonIdLayerId; //Field offset: 0x74

	public ObjectId BloonIdLastChecked
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public ObjectId BloonIdLayerId
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public Tower TowerNecroTier5
	{
		 get { } //Length: 5
	}

	public SimNecromancerGraveyardManager() { }

	public ObjectId get_BloonIdLastChecked() { }

	public ObjectId get_BloonIdLayerId() { }

	public Tower get_TowerNecroTier5() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsTier5Wizard(Tower tower) { }

	[IteratorStateMachine(typeof(<NecroTowers>d__23))]
	public IEnumerable<KeyValuePair`2<ObjectId, NecroData>> NecroTowers() { }

	protected virtual void OnDestroy() { }

	public void OnPostTowerDestroyed(Tower tower) { }

	public void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public void OnTowerUpgraded(Tower tower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public int RegisterNecroTower(ObjectId towerId, NecroData data) { }

	public void set_BloonIdLastChecked(ObjectId value) { }

	public void set_BloonIdLayerId(ObjectId value) { }

	public bool TryGetNecroTower(ObjectId towerId, int idx, out NecroData data) { }

	public void UnregisterNecroTower(ObjectId towerId, int idx) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

