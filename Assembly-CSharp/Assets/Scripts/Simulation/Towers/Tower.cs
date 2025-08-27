namespace Assets.Scripts.Simulation.Towers;

public class Tower : CommonBehaviorProxy<ITowerBehavior>, ISelectable, ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{
	[CompilerGenerated]
	private sealed class <AddDiscountZoneBuffs>d__151 : IEnumerable<BuffQuery>, IEnumerable, IEnumerator<BuffQuery>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BuffQuery <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x40
		public Tower <>4__this; //Field offset: 0x48
		private Enumerator<DiscountZone> <>7__wrap1; //Field offset: 0x50

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
		public <AddDiscountZoneBuffs>d__151(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <AddOtherBuffs>d__152 : IEnumerable<BuffQuery>, IEnumerable, IEnumerator<BuffQuery>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BuffQuery <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x40
		public Tower <>4__this; //Field offset: 0x48
		private IEnumerator<WeaponBehavior> <>7__wrap1; //Field offset: 0x50
		private IEnumerator<BuffQuery> <>7__wrap2; //Field offset: 0x58

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
		public <AddOtherBuffs>d__152(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

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

	[CompilerGenerated]
	private sealed class <FindDiscountZones>d__149 : IEnumerable<DiscountZone>, IEnumerable, IEnumerator<DiscountZone>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private DiscountZone <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Tower <>4__this; //Field offset: 0x28
		private int path; //Field offset: 0x30
		public int <>3__path; //Field offset: 0x34
		private Enumerator<String, List<DiscountZone>> <>7__wrap1; //Field offset: 0x38
		private Enumerator<DiscountZone> <>7__wrap2; //Field offset: 0x50

		private override DiscountZone System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Behaviors.DiscountZone>.Current
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
		public <FindDiscountZones>d__149(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<DiscountZone> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Towers.Behaviors.DiscountZone>.GetEnumerator() { }

		[DebuggerHidden]
		private override DiscountZone System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Behaviors.DiscountZone>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class OnUpgradedWithTowerDelegate : MulticastDelegate
	{

		public OnUpgradedWithTowerDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower tower, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Tower tower) { }

	}

	public string uniqueId; //Field offset: 0x150
	public float worth; //Field offset: 0x158
	public long damageDealt; //Field offset: 0x160
	public float cashEarned; //Field offset: 0x168
	public float appliedCash; //Field offset: 0x16C
	public int createdAt; //Field offset: 0x170
	public int createdAtRoundTime; //Field offset: 0x174
	public int originalOwner; //Field offset: 0x178
	public bool ignoreBlockersCheckIfChanged; //Field offset: 0x17C
	public bool shouldShowCashIconInstead; //Field offset: 0x17D
	public bool canTargetCamo; //Field offset: 0x17E
	public bool isBeingRedeployed; //Field offset: 0x17F
	public TowerModel towerModel; //Field offset: 0x180
	public List<RootBehavior> modelBehaviors; //Field offset: 0x188
	public RootObjectLockList<WeaponBehavior> weaponBehaviorsInDependants; //Field offset: 0x190
	public RootObjectLockList<AttackBehavior> attackBehaviorsInDependants; //Field offset: 0x198
	public List<TowerUpgradeLock> towerUpgradeLocks; //Field offset: 0x1A0
	public List<TowerTierLock> towerTierLocks; //Field offset: 0x1A8
	public RootObjectLockList<ITowerBehavior> towerBehaviors; //Field offset: 0x1B0
	public long necroBloonsReanimated; //Field offset: 0x1B8
	private ObjectId areaPlacedOn; //Field offset: 0x1C0
	public Action<Tower, ObjectId, ObjectId> OnAreaChanged; //Field offset: 0x1C8
	public List<Area> createdAreas; //Field offset: 0x1D0
	public Action<Boolean> towerRepositioned; //Field offset: 0x1D8
	private string lostTargetType; //Field offset: 0x1E0
	private string loadedTargetType; //Field offset: 0x1E8
	public string namedMonkeyKey; //Field offset: 0x1F0
	public string towerSkinName; //Field offset: 0x1F8
	public List<BuffQuery> activeBuffs; //Field offset: 0x200
	[CompilerGenerated]
	private bool <IsSuspendedButNotScaled>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private bool <IsSelectionBlocked>k__BackingField; //Field offset: 0x209
	[CompilerGenerated]
	private bool <IsSellingBlocked>k__BackingField; //Field offset: 0x20A
	[CompilerGenerated]
	private bool <IsNotUpgradeable>k__BackingField; //Field offset: 0x20B
	[CompilerGenerated]
	private bool <LockTargetTypeSwitching>k__BackingField; //Field offset: 0x20C
	[CompilerGenerated]
	private int <CustomMapTowerIndexId>k__BackingField; //Field offset: 0x210
	private int path1NumBlockedTiers; //Field offset: 0x214
	private int path2NumBlockedTiers; //Field offset: 0x218
	private int path3NumBlockedTiers; //Field offset: 0x21C
	public string powerId; //Field offset: 0x220
	[CompilerGenerated]
	private OnUpgradedWithTowerDelegate OnUpgradedWithTowerEvent; //Field offset: 0x228
	private int nextEffect; //Field offset: 0x230
	private HashSet<DiscountZone> discountZones; //Field offset: 0x238

	public event OnUpgradedWithTowerDelegate OnUpgradedWithTowerEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public ObjectId AreaPlacedOn
	{
		 get { } //Length: 7
		 set { } //Length: 72
	}

	public virtual RootObjectLockList<ITowerBehavior> Behaviors
	{
		 get { } //Length: 8
	}

	public private int CustomMapTowerIndexId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsNotUpgradeable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsSelectable
	{
		 get { } //Length: 52
	}

	public private bool IsSelectionBlocked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsSellingBlocked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public virtual bool IsStunned
	{
		 get { } //Length: 33
	}

	public private bool IsSuspendedButNotScaled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool LockTargetTypeSwitching
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public int owner
	{
		 get { } //Length: 61
		 set { } //Length: 77
	}

	public Pet Pet
	{
		 get { } //Length: 68
	}

	public float SaleValue
	{
		 get { } //Length: 231
	}

	public Tower() { }

	[CompilerGenerated]
	public void add_OnUpgradedWithTowerEvent(OnUpgradedWithTowerDelegate value) { }

	[IteratorStateMachine(typeof(<AddDiscountZoneBuffs>d__151))]
	private IEnumerable<BuffQuery> AddDiscountZoneBuffs() { }

	private void AddMapBasedMutators() { }

	public virtual void AddMutator(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, bool cascadeMutators = false, bool includeSubTowers = false, bool ignoreRecursionCheck = false, int roundsRemaining = -1, bool isParagonMutator = false, bool cantBeAbsorbed = false) { }

	private void AddMutatorFromParent(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, int roundsRemaining = -1) { }

	public void AddMutatorIncludeSubTowers(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, int roundsRemaining = -1) { }

	[IteratorStateMachine(typeof(<AddOtherBuffs>d__152))]
	private IEnumerable<BuffQuery> AddOtherBuffs() { }

	public void AddParagonMutator(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, int roundsRemaining = -1) { }

	private void AddParagonMutatorFromParent(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, int roundsRemaining = -1) { }

	public void AddParagonMutatorIncludeSubTowers(BehaviorMutator mutator, int time = -1, bool updateDuration = true, bool applyMutation = true, bool onlyTimeoutWhenActive = false, bool useRoundTime = true, int roundsRemaining = -1) { }

	public void AddPoppedCash(float cash) { }

	public void ApplyTargetTypeData(TargetType type, Vector2[] data) { }

	public void ApplyTargetTypeData(TargetType type, Vector2 data) { }

	public virtual void Attatched() { }

	public void BindCustomMapId(int customMapTowerIndexId) { }

	private bool CanTargetCamo() { }

	public bool CanUpgradeToParagon() { }

	private void ChangeSuspendedState(bool makeSuspended, bool scaleTower = true) { }

	public bool CheckIfModelBehaviorExists() { }

	private void CheckTowerLocks() { }

	public void ClearTargetTypeData(TargetType type) { }

	public virtual bool FilterMutation(BehaviorMutator mutator, ICollection<BehaviorMutatorFilter> filters) { }

	[IteratorStateMachine(typeof(<FindDiscountZones>d__149))]
	private IEnumerable<DiscountZone> FindDiscountZones(int path) { }

	public void GatherTierLocks() { }

	public void GatherUpgradeLocks() { }

	public ObjectId get_AreaPlacedOn() { }

	public virtual RootObjectLockList<ITowerBehavior> get_Behaviors() { }

	[CompilerGenerated]
	public int get_CustomMapTowerIndexId() { }

	[CompilerGenerated]
	public bool get_IsNotUpgradeable() { }

	public bool get_IsSelectable() { }

	[CompilerGenerated]
	public bool get_IsSelectionBlocked() { }

	[CompilerGenerated]
	public bool get_IsSellingBlocked() { }

	public virtual bool get_IsStunned() { }

	[CompilerGenerated]
	public bool get_IsSuspendedButNotScaled() { }

	[CompilerGenerated]
	public bool get_LockTargetTypeSwitching() { }

	public int get_owner() { }

	public Pet get_Pet() { }

	public float get_SaleValue() { }

	public override float GetAdditionalSaleAmounts() { }

	public float GetAppliedCash() { }

	public Area GetAreaTowerIsPlacedOn() { }

	public float GetModifiedLeakLivesLost(Bloon leakedBloon, float livesLost) { }

	public int GetPathUpgradeTier(TowerUpgradePath upgradePath) { }

	public TowerSaveDataModel GetSaveData() { }

	public float GetTotalRateModifier() { }

	public override float GetTotalSaleTransforms() { }

	public UpgradeModel GetUpgrade(int path) { }

	public bool HasReachedParagonLimit(int maxNumberOfParagons) { }

	public override void Hilight() { }

	public override bool IfZeroSaleTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsParagonBased() { }

	public bool IsUpgradeBlocked(int path, int tier, out string reason) { }

	public void LateSetSaveData(TowerSaveDataModel towerData) { }

	public void MoveTower(Vector2 moveBy, bool updateThrowCache = true) { }

	public void OnBloonCreate(Bloon bloon) { }

	public void OnBloonDamaged(Bloon bloon, float effectiveDamage, Projectile projectile) { }

	public void OnBloonEnterTrack(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	public void OnExpire() { }

	public void OnLivesLost(bool fromLeak) { }

	public void OnPlace(bool playPlacementEffects = true) { }

	public void OnPreLivesLost(bool fromLeak) { }

	public virtual void OnProjectilesCreated(List<Projectile> projectiles) { }

	public void OnRoundComplete(int roundArrayIndex) { }

	public void OnRoundStart(int roundNo) { }

	public void OnSold(float amount) { }

	public void OnTowerCrit(Projectile projectile) { }

	public void OnTsmThemeAction(string themeId, string buttonId, TSMInfoModel info) { }

	public void OnUpgrade(bool playEffect) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public void PerformCustomUIAction() { }

	public void PositionTower(Vector2 newPosition, bool updateThrowCache = true) { }

	[CompilerGenerated]
	public void remove_OnUpgradedWithTowerEvent(OnUpgradedWithTowerDelegate value) { }

	public void RemoveMutatorIncludeSubTowers(BehaviorMutator mutator) { }

	public void RemoveMutatorsIncludeSubTowersById(string id) { }

	public void RotateAroundPivot(Vector2 pivotPoint, float rotation, bool updateThrowCache = true) { }

	public void RotateTower(float rotation, bool updateThrowCache, bool ignoreDoesNotRotate) { }

	public override void Selected() { }

	public void set_AreaPlacedOn(ObjectId value) { }

	[CompilerGenerated]
	private void set_CustomMapTowerIndexId(int value) { }

	[CompilerGenerated]
	private void set_IsNotUpgradeable(bool value) { }

	[CompilerGenerated]
	private void set_IsSelectionBlocked(bool value) { }

	[CompilerGenerated]
	private void set_IsSellingBlocked(bool value) { }

	[CompilerGenerated]
	private void set_IsSuspendedButNotScaled(bool value) { }

	[CompilerGenerated]
	private void set_LockTargetTypeSwitching(bool value) { }

	public void set_owner(int value) { }

	private void SetGlobalScale() { }

	public void SetIsNotUpgradable(bool value, int path1NumBlockedTiers, int path2NumBlockedTiers, int path3NumBlockedTiers) { }

	public void SetLockTargetTypeSwitching(bool lockTargetTypeSwitching) { }

	public void SetNextTargetType(bool prev = false) { }

	public void SetOnTheMoveTargetting(bool val) { }

	public void SetSaveData(TowerSaveDataModel towerData) { }

	public void SetSelectionBlocked(bool value) { }

	public void SetSellingBlocked(bool value) { }

	public void SetTargetType(TargetType type) { }

	public void ShowTowerEffect(string text, float lifespan) { }

	public bool Suspend(bool scaleTower = true) { }

	public override float TransformXp(float xp) { }

	public override void UnHighlight() { }

	public override void UnSelected() { }

	public void Unsuspend(bool scaleTower = true) { }

	private void UpdateBeastHandlerHighlight(bool highlight) { }

	public void UpdateBuffs() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateTargetType() { }

	public void UpdateThrowCache() { }

	public void UpdateThrowLocation() { }

}

