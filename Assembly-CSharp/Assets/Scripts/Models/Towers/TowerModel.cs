namespace Assets.Scripts.Models.Towers;

[CanvasModel("Tower Model")]
[Implementation(typeof(Tower), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerModel : EntityModel, IPlaceableEntity
{
	internal enum TowerSize
	{
		UNSET = 0,
		small = 1,
		medium = 2,
		large = 3,
		XL = 4,
	}

	public float cost; //Field offset: 0x60
	public float range; //Field offset: 0x64
	public bool ignoreBlockers; //Field offset: 0x68
	public bool isGlobalRange; //Field offset: 0x69
	public int tier; //Field offset: 0x6C
	public Int32[] tiers; //Field offset: 0x70
	public TowerSet towerSet; //Field offset: 0x78
	public SpriteReference icon; //Field offset: 0x80
	public PrefabReference icon3D; //Field offset: 0x88
	public SpriteReference portrait; //Field offset: 0x90
	public SpriteReference instaIcon; //Field offset: 0x98
	public AreaType[] areaTypes; //Field offset: 0xA0
	public ApplyModModel[] mods; //Field offset: 0xA8
	public bool ignoreTowerForSelection; //Field offset: 0xB0
	public FootprintModel footprint; //Field offset: 0xB8
	public bool dontDisplayUpgrades; //Field offset: 0xC0
	public SpriteReference emoteSpriteSmall; //Field offset: 0xC8
	public SpriteReference emoteSpriteLarge; //Field offset: 0xD0
	public bool doesntRotate; //Field offset: 0xD8
	public UpgradePathModel[] upgrades; //Field offset: 0xE0
	public String[] appliedUpgrades; //Field offset: 0xE8
	public TargetType[] targetTypes; //Field offset: 0xF0
	public UpgradePathModel paragonUpgrade; //Field offset: 0xF8
	public bool isSubTower; //Field offset: 0x100
	public bool isBakable; //Field offset: 0x101
	public string powerName; //Field offset: 0x108
	public bool showPowerTowerBuffs; //Field offset: 0x110
	public float animationSpeed; //Field offset: 0x114
	public string towerSelectionMenuThemeId; //Field offset: 0x118
	public PrefabReference secondarySelectionMenu; //Field offset: 0x120
	public bool ignoreCoopAreas; //Field offset: 0x128
	public bool canAlwaysBeSold; //Field offset: 0x129
	public bool blockSelling; //Field offset: 0x12A
	public bool isParagon; //Field offset: 0x12B
	public bool ignoreMaxSellPercent; //Field offset: 0x12C
	public bool isStunned; //Field offset: 0x12D
	public string geraldoItemName; //Field offset: 0x130
	public float sellbackModifierAdd; //Field offset: 0x138
	public string skinName; //Field offset: 0x140
	private Nullable<Boolean> isBeastHandlerPet; //Field offset: 0x148
	private Nullable<Boolean> selectParentOnSelected; //Field offset: 0x14A
	public bool dontAddMutatorsFromParent; //Field offset: 0x14C
	public bool showBuffs; //Field offset: 0x14D
	public bool destroyTowerOnRedistribution; //Field offset: 0x14E
	public float displayScale; //Field offset: 0x150
	private string beastHandlerLeashMutationId; //Field offset: 0x158
	public bool loadedFromSave; //Field offset: 0x160
	public bool useAirUnitHeight; //Field offset: 0x161
	private PowerProTowerModel _powerProTowerModel; //Field offset: 0x168
	private TowerSize towerSize; //Field offset: 0x170

	public string BeastHandlerLeashMutationId
	{
		 get { } //Length: 81
	}

	public virtual float DisplayScale
	{
		 get { } //Length: 9
	}

	public bool IsBaseTower
	{
		 get { } //Length: 36
	}

	public bool IsBeastHandlerPet
	{
		 get { } //Length: 184
	}

	public bool IsExclusivelyWaterBased
	{
		 get { } //Length: 156
	}

	public bool isGeraldoItem
	{
		 get { } //Length: 12
	}

	public bool isPowerProTower
	{
		 get { } //Length: 130
	}

	public bool isPowerTower
	{
		 get { } //Length: 12
	}

	public virtual bool IsSubEntity
	{
		 get { } //Length: 8
	}

	public PowerProTowerModel powerProTowerModel
	{
		 get { } //Length: 100
	}

	public bool SelectParentOnSelected
	{
		 get { } //Length: 184
	}

	public TargetType[] TargetTypes
	{
		 get { } //Length: 29
	}

	public TowerModel(string name, string baseId, TowerSet towerSet, PrefabReference display, float cost = 100, float radius = 0.7, float range = 1, bool ignoreBlockers = false, bool isGlobalRange = false, int tier = 0, Int32[] tiers = null, String[] appliedUpgrades = null, UpgradePathModel[] upgrades = null, UpgradePathModel paragonUpgrade = null, Model[] behaviors = null, AreaType[] areaTypes = null, Nullable<SpriteReference> icon = null, Nullable<PrefabReference> icon3D = null, Nullable<SpriteReference> portrait = null, Nullable<SpriteReference> instaIcon = null, ApplyModModel[] mods = null, bool ignoreTowerForSelection = false, bool isSubTower = false, bool isBakable = false, FootprintModel footprint = null, bool dontDisplayUpgrades = false, string powerName = null, float animationSpeed = 1, Nullable<SpriteReference> emoteSpriteSmall = null, Nullable<SpriteReference> emoteSpriteLarge = null, bool doesntRotate = false, bool showPowerTowerBuffs = false, string towerSelectionMenuThemeId = "Default", bool ignoreCoopAreas = false, bool canAlwaysBeSold = false, bool blockSelling = false, bool isParagon = false, float sellbackModifierAdd = 0, string geraldoItemName = null, bool ignoreMaxSellPercent = false, bool isStunned = false, bool dontAddMutatorsFromParent = false, float displayScale = 1, bool showBuffs = true, bool destroyTowerOnRedistribution = false, PrefabReference secondarySelectionMenu = null, bool useAirUnitHeight = false, string skinName = null) { }

	public bool CheckSet(TowerSet set, bool inverseSet) { }

	public bool CheckTiers(Int32[] tiers, bool mustBeEqual, bool inverseTiers) { }

	public bool CheckTiersAreEqual(int pathOneTier, int pathTwoTier, int pathThreeTier) { }

	public virtual Model Clone() { }

	private bool CompareArrays(AreaType[] a1, AreaType[] a2) { }

	public override bool ContainsAreaType(AreaType areaType) { }

	public void CopyFrom(TowerModel rhs) { }

	public string get_BeastHandlerLeashMutationId() { }

	public virtual float get_DisplayScale() { }

	public bool get_IsBaseTower() { }

	public bool get_IsBeastHandlerPet() { }

	public bool get_IsExclusivelyWaterBased() { }

	public bool get_isGeraldoItem() { }

	public bool get_isPowerProTower() { }

	public bool get_isPowerTower() { }

	public virtual bool get_IsSubEntity() { }

	public PowerProTowerModel get_powerProTowerModel() { }

	public bool get_SelectParentOnSelected() { }

	public TargetType[] get_TargetTypes() { }

	public virtual float GetPrimaryWeaponThrowMarkerHeight() { }

	public TowerSize GetTowerSize() { }

	public override bool IsAmphibiousBased() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsHero() { }

	public override bool IsPlaceableInAreaType(AreaType areaType) { }

	public bool IsStandardTower() { }

	public override bool IsWaterBased() { }

	public void UpdateTargetProviders() { }

}

