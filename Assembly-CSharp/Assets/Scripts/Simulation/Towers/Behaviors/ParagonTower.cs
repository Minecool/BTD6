namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ParagonTower : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Tower, Int32> <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <StartSacrifice>b__29_0(Tower validTower) { }

	}

	public class InvestmentEffect
	{
		public Entity effect; //Field offset: 0x10
		public float baseScale; //Field offset: 0x18
		public Vector2 origin; //Field offset: 0x1C
		public Vector2 direction; //Field offset: 0x24
		public Vector2 destination; //Field offset: 0x2C
		public float distance; //Field offset: 0x34

		public InvestmentEffect() { }

	}

	internal struct InvestmentInfo
	{
		public float powerFromPops; //Field offset: 0x0
		public float powerFromMoneySpent; //Field offset: 0x4
		public float powerFromNonTier5Tiers; //Field offset: 0x8
		public float powerFromTier5Count; //Field offset: 0xC
		public float powerFromBonus; //Field offset: 0x10
		public float totalInvestment; //Field offset: 0x14

	}

	public ParagonTowerModel paragonTowerModel; //Field offset: 0x68
	private Entity effectDuring; //Field offset: 0x70
	private readonly List<InvestmentEffect> investmentEffects; //Field offset: 0x78
	private bool isActive; //Field offset: 0x80
	private int activeAt; //Field offset: 0x84
	private readonly Dictionary<Tower, List`1<Attack>> pausedAttacksForTower; //Field offset: 0x88
	private int effectsStartMovingAt; //Field offset: 0x90
	private int effectsStartScalingAt; //Field offset: 0x94
	private readonly Dictionary<ObjectId, Tower> towersPlacedOnAreasWithIds; //Field offset: 0x98
	public readonly List<Tower> towersIgnoredForSellTrigger; //Field offset: 0xA0
	public InvestmentInfo investmentInfo; //Field offset: 0xA8
	private float upgradeCost; //Field offset: 0xC0
	private double cashBefore; //Field offset: 0xC8
	private double cashAfter; //Field offset: 0xD0
	private double nonUpgradeCashInvestment; //Field offset: 0xD8
	private bool doSacrifice; //Field offset: 0xE0

	public bool IsActive
	{
		 get { } //Length: 8
	}

	public ParagonTower() { }

	[CompilerGenerated]
	private float <StartSacrifice>b__29_1(Tower sacrificedTier5Tower) { }

	private InvestmentInfo CombineInvestments(InvestmentInfo a, InvestmentInfo b) { }

	private void CreateDegreeText() { }

	public void Finish() { }

	public bool get_IsActive() { }

	public int GetCurrentDegree() { }

	public PowerDegreeMutator GetDegreeMutator(float investment, AssetPathModel displayDegree) { }

	public AssetPathModel GetDisplayDegree(int investment) { }

	public int GetDisplayDegreeIndex(float investment) { }

	private float GetInvestmentEffectScale(float investment) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	private InvestmentInfo GetTowerInvestment(Tower towerToUse, int tier5Index = 3) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	private void MakeNewInvestmentEffect(InvestmentInfo fromInfo, Tower sacrificedTower, float overDistance) { }

	protected virtual void OnDestroy() { }

	private void OnTowerUpgraded(Tower upgradedTower, TowerModel def, float upgradeCost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	public virtual void OnUpgraded(int pathIndex) { }

	private void PlayParagonUpgradeSound() { }

	private void Process(int elapsed) { }

	private void SetActive(bool active, bool setVisibility = true) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SetTowerActive(Tower towerToSet, bool active, bool setVisibility) { }

	public void StartSacrifice() { }

	public void UpdateDegree() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

