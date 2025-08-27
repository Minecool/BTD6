namespace Assets.Scripts.Simulation.Towers;

public class TowerManager : RootBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<DiscountZone> <>9__6_0; //Field offset: 0x8
		public static Func<AreaBuffModel, Boolean> <>9__8_0; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, Single>, Single> <>9__25_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GetAreaDiscount>b__8_0(AreaBuffModel x) { }

		internal int <GetZoneDiscount>b__6_0(DiscountZone a, DiscountZone b) { }

		internal float <TransformSellAmount>b__25_0(KeyValuePair<String, Single> pair) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public Tower newTower; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <RecordTowerHistory>b__0(TowerHistory x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Tower tower; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <UpgradeTower>b__0(TowerHistory x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public Tower tower; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <DestroyTower>b__0(TowerHistory x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public int inputIndex; //Field offset: 0x10

		public <>c__DisplayClass58_0() { }

		internal bool <HasParagonPlaced>b__0(Tower towerOfBaseId) { }

	}

	[CompilerGenerated]
	private sealed class <GetChildTowers>d__40 : IEnumerable<Tower>, IEnumerable, IEnumerator<Tower>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Tower <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private ObjectId parentTowerId; //Field offset: 0x24
		public ObjectId <>3__parentTowerId; //Field offset: 0x28
		public TowerManager <>4__this; //Field offset: 0x30
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x38

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
		public <GetChildTowers>d__40(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private sealed class <GetTowers>d__32 : IEnumerable<Tower>, IEnumerable, IEnumerator<Tower>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Tower <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TowerManager <>4__this; //Field offset: 0x28
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x30

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
		public <GetTowers>d__32(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private sealed class <GetTowersByBaseId>d__31 : IEnumerable<Tower>, IEnumerable, IEnumerator<Tower>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Tower <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TowerManager <>4__this; //Field offset: 0x28
		private string towerBaseId; //Field offset: 0x30
		public string <>3__towerBaseId; //Field offset: 0x38
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x40

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
		public <GetTowersByBaseId>d__31(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private sealed class <GetTowersInRange>d__30 : IEnumerable<Tower>, IEnumerable, IEnumerator<Tower>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Tower <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private float range; //Field offset: 0x24
		public float <>3__range; //Field offset: 0x28
		public TowerManager <>4__this; //Field offset: 0x30
		private Vector2 position; //Field offset: 0x38
		public Vector2 <>3__position; //Field offset: 0x40
		private float <rangeSquared>5__2; //Field offset: 0x48
		private IEnumerator<Tower> <>7__wrap2; //Field offset: 0x50

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
		public <GetTowersInRange>d__30(int <>1__state) { }

		private void <>m__Finally1() { }

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
	private sealed class <GetTowersWithRangeCircleOverlap>d__57 : IEnumerable<Tower>, IEnumerable, IEnumerator<Tower>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Tower <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TowerManager <>4__this; //Field offset: 0x28
		private string towerType; //Field offset: 0x30
		public string <>3__towerType; //Field offset: 0x38
		private float range; //Field offset: 0x40
		public float <>3__range; //Field offset: 0x44
		private Vector2 position; //Field offset: 0x48
		public Vector2 <>3__position; //Field offset: 0x50
		private IEnumerator<Tower> <>7__wrap1; //Field offset: 0x58

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
		public <GetTowersWithRangeCircleOverlap>d__57(int <>1__state) { }

		private void <>m__Finally1() { }

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

	private struct StackedCashbacks
	{
		public float percentCashback; //Field offset: 0x0
		public int stacks; //Field offset: 0x4

	}

	internal sealed class TowerFilter : MulticastDelegate
	{

		public TowerFilter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Tower t, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(Tower t) { }

	}

	public List<TowerHistory> towerHistory; //Field offset: 0x58
	public Dictionary<String, Int32> towerMaxBaseIdAtATime; //Field offset: 0x60
	private readonly Dictionary<String, List`1<DiscountZone>> discountStacks; //Field offset: 0x68
	private readonly Dictionary<String, Single> discountGroups; //Field offset: 0x70
	private readonly Dictionary<String, StackedCashbacks> cashbackGroups; //Field offset: 0x78
	private readonly Dictionary<String, Single> cashbackGroupsMax; //Field offset: 0x80
	private readonly List<Tower> closestTowersList; //Field offset: 0x88
	private readonly List<Single> closestTowerDistances; //Field offset: 0x90

	public TowerManager() { }

	public bool CanUpgradeTower(Tower tower, int path, int tier, int inputIndex, ref float cost, bool ignoreCost = false) { }

	public bool CanUpgradeTowerParagon(Tower tower, int inputIndex, ref float cost, double nonUpgradeCashInvestment) { }

	public Tower CreateAreaPlaceholderTower(TowerModel def, Vector3 position, ObjectId areaPlacedOn, int owner, float rotationY = 0) { }

	public Tower CreateTower(TowerModel def, Vector3 position, int inputIndex, ObjectId areaPlacedOn, ObjectId parentTowerId, TowerSaveDataModel loadingSaveData = null, bool isInstaTower = false, bool deductCash = true, float rotation = 0, bool playPlacementEffects = true, int costOverride = 0, int rogueTier = -1) { }

	public void DestroyTower(Tower tower, int inputIndex) { }

	private int FindInsertionIndexAtDistance(float distance, List<Single> distances) { }

	private float GetAreaDiscount(Vector2 position) { }

	public IEnumerable<Tower> GetChildTowers(Tower parentTower) { }

	[IteratorStateMachine(typeof(<GetChildTowers>d__40))]
	public IEnumerable<Tower> GetChildTowers(ObjectId parentTowerId) { }

	public Tower GetClosestTowerInRange(Vector2 position, float range, TowerFilter filter = null) { }

	public Tower GetClosestTowerInRange(Vector3Boxed position, float range, TowerFilter filter = null) { }

	public Tower GetClosestTowerInRange(Vector3 position, float range, TowerFilter filter = null) { }

	public IEnumerable<Tower> GetClosestTowers(Vector3Boxed position, int count = -1, TowerFilter filter = null) { }

	public IEnumerable<Tower> GetClosestTowers(Vector3 position, int count = -1, TowerFilter filter = null) { }

	public List<Tower> GetClosestTowers(Vector2 position, int count = -1, TowerFilter filter = null, float range = 99999) { }

	private float GetDiscountMultiplier(Dictionary<String, List`1<DiscountZone>> discountStacks) { }

	private bool GetFreeUpgrade(Vector3 position, Tower tower, int path, int tier) { }

	public Tower GetFurthestTowerInRange(Vector2 position, TowerFilter filter = null) { }

	public Tower GetMostExpensiveTower(TowerFilter filter = null) { }

	public float GetTotalSpentOnTowers() { }

	public void GetTowerAverages(out float avgAttackSpeed, out float avgDamage, out float avgPierce) { }

	public Tower GetTowerById(ObjectId id) { }

	private float GetTowerCost(TowerModel tower, Vector3 position, TowerInventory ti, int owner) { }

	public Tower GetTowerFromCustomModelIndexId(int customMapIndexId) { }

	public List<TowerHistory> GetTowerHistorySaveData() { }

	public Dictionary<String, Int32> GetTowerMaxBaseIdSaveData() { }

	[IteratorStateMachine(typeof(<GetTowers>d__32))]
	public IEnumerable<Tower> GetTowers() { }

	[IteratorStateMachine(typeof(<GetTowersByBaseId>d__31))]
	public IEnumerable<Tower> GetTowersByBaseId(string towerBaseId) { }

	public IEnumerable<Tower> GetTowersInRange(Vector3 position, float range) { }

	public IEnumerable<Tower> GetTowersInRange(Vector3Boxed position, float range) { }

	[IteratorStateMachine(typeof(<GetTowersInRange>d__30))]
	public IEnumerable<Tower> GetTowersInRange(Vector2 position, float range) { }

	[IteratorStateMachine(typeof(<GetTowersWithRangeCircleOverlap>d__57))]
	public IEnumerable<Tower> GetTowersWithRangeCircleOverlap(float range, Vector2 position, string towerType = null) { }

	public float GetTowerUpgradeCost(Tower tower, int path, int tier, float overrideBaseCost = -1, bool isParagonUpgrade = false) { }

	public Dictionary<String, List`1<DiscountZone>> GetZoneDiscount(TowerModel towerModel, Vector3 position, int path, int tier, int owner, string upgradeName = "") { }

	public bool HasParagonPlaced(string towerBaseId, int inputIndex) { }

	public bool IsParagonLocked(Tower tower, int inputIndex) { }

	public bool IsTowerPathTierLocked(Tower tower, int path, int tier, int inputIndex) { }

	private void RecordTowerHistory(Tower newTower, float cost) { }

	public void SellTower(Tower tower, int inputIndex) { }

	public void SetTowerHistorySaveData(List<TowerHistory> saveData) { }

	public void SetTowerMaxBaseIdSaveData(Dictionary<String, Int32> saveData) { }

	public void TempleCreated(Tower tower) { }

	private void TowerAreaChanged(Tower tower, ObjectId previousAreaID, ObjectId areaID) { }

	public void TowerMutated(Tower tower, BehaviorMutator mutator) { }

	public void TowerSacrificed(Tower tower, Tower sacrificedTo) { }

	public void TowerSold(Tower tower, float sellAmount, double cashBefore, double cashAfter) { }

	public void TowerXpUpdated(Tower tower) { }

	public float TransformSellAmount(Tower tower) { }

	public void UpgradeTower(int inputIndex, Tower tower, TowerModel def, int pathIndex, float upgradeCost, float costMultiplier = 1, bool triggerOnUpgraded = true, bool triggerOnUpgrade = true, bool playUpgradeEffect = true, bool isParagon = false, bool dontCountHeroTiers = false, int heroTiersToNotCount = 0, double nonUpgradeCashInvestment = 0) { }

}

