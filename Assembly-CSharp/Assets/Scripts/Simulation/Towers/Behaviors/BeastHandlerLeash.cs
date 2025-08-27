namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class BeastHandlerLeash : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <GetActiveBeasts>d__67 : IEnumerable<Tower>, IEnumerable, IEnumerator<Tower>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Tower <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public BeastHandlerLeash <>4__this; //Field offset: 0x28

		private override Tower System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Tower>.Current
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
		public <GetActiveBeasts>d__67(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Tower> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Towers.Tower>.GetEnumerator() { }

		[DebuggerHidden]
		private override Tower System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Tower>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetAdditionalDisplayMeshes>d__68 : IEnumerable<Mesh>, IEnumerable, IEnumerator<Mesh>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Mesh <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private TowerModel towerModel; //Field offset: 0x28
		public TowerModel <>3__towerModel; //Field offset: 0x30
		public BeastHandlerLeash <>4__this; //Field offset: 0x38
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x40

		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.Current
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
		public <GetAdditionalDisplayMeshes>d__68(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Mesh> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Display.Mesh>.GetEnumerator() { }

		[DebuggerHidden]
		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const string MoveButtonName = "MoveButton"; //Field offset: 0x0
	private const string MoveButtonSecondName = "MoveButtonSecond"; //Field offset: 0x0
	public BeastHandlerLeashModel beastHandlerLeashModel; //Field offset: 0x68
	private Attack spawnerAttack; //Field offset: 0x70
	private Attack spawnerAttackSecond; //Field offset: 0x78
	private Tower leashedTower; //Field offset: 0x80
	private Tower leashedTowerSecond; //Field offset: 0x88
	private readonly Int32[] timesOfLastMoves; //Field offset: 0x90
	private readonly List<BeastHandlerLeash> leashesToRemoveList; //Field offset: 0x98
	private readonly List<TimedMutator> mutatorsToRemoveList; //Field offset: 0xA0
	private Entity targetImg; //Field offset: 0xA8
	private readonly Dictionary<String, HashSet`1<BeastHandlerLeash>> contributingHandlersByBeast; //Field offset: 0xB0
	private readonly Dictionary<String, BeastHandlerLeash> beastsLostThroughContribution; //Field offset: 0xB8
	private readonly List<Entity> lineDotDisplays; //Field offset: 0xC0
	private bool drawing; //Field offset: 0xC8
	private bool dontShowBuffedText; //Field offset: 0xC9
	protected TSMInfoModel newInfo; //Field offset: 0xD0

	public Dictionary<String, HashSet`1<BeastHandlerLeash>> ContributingHandlersByBeast
	{
		 get { } //Length: 8
	}

	public Tower LeashedTower
	{
		 get { } //Length: 21
	}

	public Tower LeashedTowerSecond
	{
		 get { } //Length: 21
	}

	public BeastHandlerLeash() { }

	public virtual void ApplyCustomInputData(CustomInputData data) { }

	public bool Contribute(BeastHandlerLeash contributing, TowerModel beastToContributeModel) { }

	public bool DoesValidTowerExistForMerge(string beastTowerId) { }

	private void DrawContributions(PrefabReference displayReference, List<Entity> lineDotDisplays, ref int totalDots, string beastTowerId = null) { }

	public Dictionary<String, HashSet`1<BeastHandlerLeash>> get_ContributingHandlersByBeast() { }

	public Tower get_LeashedTower() { }

	public Tower get_LeashedTowerSecond() { }

	[IteratorStateMachine(typeof(<GetActiveBeasts>d__67))]
	public IEnumerable<Tower> GetActiveBeasts() { }

	[IteratorStateMachine(typeof(<GetAdditionalDisplayMeshes>d__68))]
	public virtual IEnumerable<Mesh> GetAdditionalDisplayMeshes(TowerModel towerModel, Vector3 position, bool isFromHover) { }

	public BeastHandlerLeash GetBeastHandlerContributingTowards(string beastTowerId) { }

	public int GetCurrentContributionsByBeast(string beastTowerId, int tier = -1) { }

	public Tower GetMatchingBeast(string towerBaseId, int tier = -1) { }

	public float GetPowerPercentForBeast(string beastTowerId) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public int GetTotalPowerForBeast(string beastBaseId) { }

	public virtual string GetTowerBehaviorCustomInputClass(string buttonId) { }

	public virtual object GetTowerBehaviorCustomInputData(string buttonId) { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public bool HasActiveBeasts() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsBeastLostThroughContribution(string beastTowerId) { }

	public bool IsContributingToAnotherHandler() { }

	public bool IsHandlerContributing(BeastHandlerLeash handlerToCheck, string beastTowerId) { }

	private bool IsPartOfContributionChain(BeastHandlerLeash leash, string beastTowerId) { }

	public bool IsPathSegmentInRange() { }

	private bool IsTowerValidForMerge(Tower beastTower, Tower towerToCheck) { }

	public bool IsWithinRangeOfWater() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selection) { }

	private void OnTowerDestroyed(Tower destroyedTower) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private int PlotPointsBetweenTowers(PrefabReference displayReference, List<Entity> lineDotDisplays, Vector3 positionA, Vector3 positionB, ref int totalDots) { }

	private void PlotPointsForContributions() { }

	private void Process(int elapsed) { }

	private Tower ProcessLeashedTower(Tower leashedTowerToProcess, Attack spawnerAttackToProcess, TowerModel leashedTowerTowerModel, out bool isUpdated) { }

	public void RemoveContribution(BeastHandlerLeash beastHandlerLeash) { }

	public void ResetLeashedTowerPosition(Tower towerToReset) { }

	private void RotateToLeashedTower(Tower towerToRotateTo, bool animate) { }

	public void StartDraw() { }

	public void StopDraw() { }

	private void SyncMutators(Tower leashedTowerToSync) { }

	private void TowerSuspendedStateChanged() { }

	private void UpdateContributionBuffForPet(Tower leashedTowerToUpdate, TowerModel leashedTowerToUpdateModel) { }

	private void UpdateContributions(TowerModel leashedTowerToUpdateModel, Tower leashedTowerToUpdate) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private bool UpdatePowerMutator(int power, Tower updateBuffForTower, TowerModel leashedTowerToUpdateModel) { }

	private void UpdateSpawnerAttacks() { }

}

