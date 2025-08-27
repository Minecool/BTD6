namespace Assets.Scripts.Unity.Bridge;

public class TowerToSimulation : Selectable
{
	[CompilerGenerated]
	private sealed class <GetTowerBuffsFromSim>d__58 : IEnumerable<BuffQuery>, IEnumerable, IEnumerator<BuffQuery>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BuffQuery <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x40
		public TowerToSimulation <>4__this; //Field offset: 0x48
		private Enumerator<BuffQuery> <>7__wrap1; //Field offset: 0x50

		private override BuffQuery System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.BuffQuery>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 29
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 89
		}

		[DebuggerHidden]
		public <GetTowerBuffsFromSim>d__58(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<BuffQuery> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.BuffQuery>.GetEnumerator() { }

		[DebuggerHidden]
		private override BuffQuery System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.BuffQuery>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private UnityToSimulation sim; //Field offset: 0x10
	private Tower tower; //Field offset: 0x18
	private ObjectId Id; //Field offset: 0x20
	public HeroToSimulation hero; //Field offset: 0x28
	private bool destroyed; //Field offset: 0x30
	public Action OnDestroyed; //Field offset: 0x38
	public Action OnSelectionDisabled; //Field offset: 0x40
	public BeastHandlerToSimulation beastHandlerToSimulation; //Field offset: 0x48
	private List<AbilityToSimulation> result; //Field offset: 0x50
	private readonly List<TowerModel> subTowerModels; //Field offset: 0x58

	public List<AbilityToSimulation> Abilities
	{
		 get { } //Length: 843
	}

	public IEnumerable<BuffQuery> activeBuffs
	{
		 get { } //Length: 101
	}

	public float cashEarned
	{
		 get { } //Length: 31
	}

	public long damageDealt
	{
		 get { } //Length: 30
	}

	public TowerModel Def
	{
		 get { } //Length: 30
	}

	public virtual ObjectId id
	{
		 get { } //Length: 4
	}

	public bool IsNotUpgradeable
	{
		 get { } //Length: 58
	}

	public bool IsParagon
	{
		 get { } //Length: 42
	}

	public bool IsPowerTower
	{
		 get { } //Length: 41
	}

	public bool IsSelectable
	{
		 get { } //Length: 29
	}

	public bool IsSellingBlocked
	{
		 get { } //Length: 30
	}

	public bool IsStunned
	{
		 get { } //Length: 42
	}

	public bool IsTargetTypeSwitchingLocked
	{
		 get { } //Length: 30
	}

	public string namedMonkeyKey
	{
		 get { } //Length: 30
	}

	public int owner
	{
		 get { } //Length: 29
	}

	public Vector3 position
	{
		 get { } //Length: 214
	}

	public float rotation
	{
		 get { } //Length: 68
	}

	public float sellFor
	{
		 get { } //Length: 76
	}

	public Vector3 simPosition
	{
		 get { } //Length: 71
	}

	public TargetType TargetType
	{
		 get { } //Length: 95
	}

	public string towerSkinName
	{
		 get { } //Length: 30
	}

	public float worth
	{
		 get { } //Length: 31
	}

	public TowerToSimulation(UnityToSimulation sim, Tower tower, Hero hero = null) { }

	public void ApplyCustomInputData(CustomInputData data) { }

	public bool AreTiersLockedByGeraldo() { }

	public bool CanUpgradeToParagon() { }

	public void CollectFromBank() { }

	public void Destroy() { }

	public List<AbilityToSimulation> get_Abilities() { }

	public IEnumerable<BuffQuery> get_activeBuffs() { }

	public float get_cashEarned() { }

	public long get_damageDealt() { }

	public TowerModel get_Def() { }

	public virtual ObjectId get_id() { }

	public bool get_IsNotUpgradeable() { }

	public bool get_IsParagon() { }

	public bool get_IsPowerTower() { }

	public bool get_IsSelectable() { }

	public bool get_IsSellingBlocked() { }

	public bool get_IsStunned() { }

	public bool get_IsTargetTypeSwitchingLocked() { }

	public string get_namedMonkeyKey() { }

	public int get_owner() { }

	public Vector3 get_position() { }

	public float get_rotation() { }

	public float get_sellFor() { }

	public Vector3 get_simPosition() { }

	public TargetType get_TargetType() { }

	public string get_towerSkinName() { }

	public float get_worth() { }

	public float GetBankAmount() { }

	public BuffQuery[] GetBuffsAffectingPlacementTower(TowerModel placementTowerModel, Vector3 placementPosition, out bool towerBuffedThisTower, int owner) { }

	public InvestmentInfo GetCurrentParagonInvestment() { }

	public object GetCustomInputDataFromTowerBehaviors(string buttonId) { }

	public TowerBehavior GetCustomInputTowerBehavior(string buttonId) { }

	public float GetLoanAmount() { }

	public int GetMaxTierForPath(int path) { }

	public PowerDegreeMutator GetParagonDegreeMutator() { }

	public int GetParagonDisplayIndex() { }

	public Vector3 GetSimPosition() { }

	public Tower GetSimTower() { }

	public List<TowerModel> GetSubTowerModels() { }

	[IteratorStateMachine(typeof(<GetTowerBuffsFromSim>d__58))]
	public IEnumerable<BuffQuery> GetTowerBuffsFromSim() { }

	public float GetUpgradeCost(int pathIndex, int tier, float overrideBaseCost, bool isParagonUpgrade) { }

	public bool HasGlobalRangeBuffBehavior() { }

	public bool HasReachedParagonLimit(int maxParagons) { }

	public bool IsDestroyed() { }

	public bool IsDisplayVisible(PrefabReference reference) { }

	public bool IsInputBlocked() { }

	public bool IsUpgradeBlocked(int path, int tier, out string reason) { }

	public void PerformCustomUIAction() { }

	public void SelectableDisabled() { }

	public void SetNextTargetType(bool prev = false) { }

	public bool ShowWizardParagonMaxGraveyardPip() { }

	public void Upgrade(int pathIndex, bool isParagon, double nonUpgradeCashInvestment, Action<Boolean> callback) { }

}

