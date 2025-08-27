namespace Assets.Scripts.Unity.Towers;

public class Tower : Upgradeable, CascadeProxyAnchor
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public Tower <>4__this; //Field offset: 0x10
		public string label; //Field offset: 0x18

		public <>c__DisplayClass69_0() { }

		internal GenericCascadingExpression <AddVariablesToExpression>b__0() { }

	}

	public Tower parent; //Field offset: 0x80
	public string baseId; //Field offset: 0x88
	public string expBaseId; //Field offset: 0x90
	public string towerSet; //Field offset: 0x98
	public string expTowerSet; //Field offset: 0xA0
	public float cost; //Field offset: 0xA8
	public string expCost; //Field offset: 0xB0
	public float radius; //Field offset: 0xB8
	public string expRadius; //Field offset: 0xC0
	public float range; //Field offset: 0xC8
	public string expRange; //Field offset: 0xD0
	public bool ignoreBlockers; //Field offset: 0xD8
	public string expIgnoreBlockers; //Field offset: 0xE0
	public string placeableArea; //Field offset: 0xE8
	public string expPlaceableArea; //Field offset: 0xF0
	public bool ignoreTower; //Field offset: 0xF8
	public string expIgnoreTower; //Field offset: 0x100
	public bool isGlobalRange; //Field offset: 0x108
	public string expIsGlobalRange; //Field offset: 0x110
	public bool dontDisplayUpgrades; //Field offset: 0x118
	public string expDontDisplayUpgrades; //Field offset: 0x120
	public bool doesntRotate; //Field offset: 0x128
	public string expDoesntRotate; //Field offset: 0x130
	public bool canAlwaysBeSold; //Field offset: 0x138
	public string expCanAlwaysBeSold; //Field offset: 0x140
	public float sellbackModifierAdd; //Field offset: 0x148
	public string expSellbackModifierAdd; //Field offset: 0x150
	public bool ignoreMaxSellPercent; //Field offset: 0x158
	public string expIgnoreMaxSellPercent; //Field offset: 0x160
	public bool blockSelling; //Field offset: 0x168
	public string expBlockSelling; //Field offset: 0x170
	public bool dontAddMutatorsFromParent; //Field offset: 0x178
	public string expDontAddMutatorsFromParent; //Field offset: 0x180
	public bool destroyTowerOnRedistribution; //Field offset: 0x188
	public string expDestroyTowerOnRedistribution; //Field offset: 0x190
	public bool useAirUnitHeight; //Field offset: 0x198
	public string expUseAirUnitHeight; //Field offset: 0x1A0
	public bool ignoreCoopAreas; //Field offset: 0x1A8
	public string expIgnoreCoopAreas; //Field offset: 0x1B0
	private bool isSubTower; //Field offset: 0x1B8
	private Int32[] tiers; //Field offset: 0x1C0
	public GameObject secondarySelectionMenu; //Field offset: 0x1C8
	public GameObject expSecondarySelectionMenu; //Field offset: 0x1D0
	public GameObject icon; //Field offset: 0x1D8
	public GameObject expIcon; //Field offset: 0x1E0
	public GameObject icon3D; //Field offset: 0x1E8
	public GameObject expIcon3D; //Field offset: 0x1F0
	public GameObject portrait; //Field offset: 0x1F8
	public GameObject expPortrait; //Field offset: 0x200
	public GameObject instaIcon; //Field offset: 0x208
	public GameObject expInstaIcon; //Field offset: 0x210
	public GameObject display; //Field offset: 0x218
	public GameObject expDisplay; //Field offset: 0x220
	public GameObject emoteSpriteSmall; //Field offset: 0x228
	public GameObject expEmoteSpriteSmall; //Field offset: 0x230
	public GameObject emoteSpriteLarge; //Field offset: 0x238
	public GameObject expEmoteSpriteLarge; //Field offset: 0x240
	public string towerSelectionMenuThemeId; //Field offset: 0x248
	public string expTowerSelectionMenuThemeId; //Field offset: 0x250
	private TowerModel def; //Field offset: 0x258
	private Cache<CascadingItem> _newBase; //Field offset: 0x260
	private UpgradePath cacheGetParentUpgradePath; //Field offset: 0x268
	private Upgrade[] cacheGetUpgrades; //Field offset: 0x270
	private UpgradePath[] cacheGetUpgradePaths; //Field offset: 0x278

	public TowerModel Def
	{
		 get { } //Length: 6446
	}

	public bool IsCrossPathed
	{
		 get { } //Length: 89
	}

	public virtual Model Model
	{
		 get { } //Length: 7
	}

	public Cache<CascadingItem> NewBase
	{
		 get { } //Length: 242
	}

	public Tower() { }

	protected virtual void AddVariablesToExpression(string label, GenericCascadingExpression expression) { }

	public TowerModel BuildJson() { }

	private String[] GatherAppliedUpgrades() { }

	private Model[] GatherBehaviors() { }

	private UpgradePathModel[] GatherUpgrades() { }

	public TowerModel get_Def() { }

	public bool get_IsCrossPathed() { }

	public virtual Model get_Model() { }

	public Cache<CascadingItem> get_NewBase() { }

	private SpriteReference GetCorrectTierTwoPortrait(int tier1, int tier2, int tier3, out SpriteReference instaIcon) { }

	private CascadingItem GetNewBase() { }

	public int GetNumberOfPathsUsed() { }

	private UpgradePathModel GetParagonUpgrade() { }

	protected virtual CascadingItem GetParent() { }

	public UpgradePath GetParentUpgradePath() { }

	public int GetTier() { }

	public Int32[] GetTiers() { }

	public UpgradePath[] GetUpgradePaths() { }

	public Upgrade[] GetUpgrades() { }

	private bool IsParagon() { }

	private Transform ResursiveSearch(Transform child, string name, Transform matchingMarker) { }

	protected void SetIsSubTower(bool isSubTower) { }

	private TowerBehavior[] StripTowerBehavoiurs(TowerBehavior[] behaviours) { }

}

