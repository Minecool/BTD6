namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Tower", menuName = "BTD6/Behaviors/Tower Asset", order = 1)]
public class Tower : Upgradeable
{
	[SerializeField]
	public string baseId; //Field offset: 0x28
	[SerializeField]
	public TowerSet towerSet; //Field offset: 0x30
	[SerializeField]
	public AreaType[] placeableAreas; //Field offset: 0x38
	[SerializeField]
	public float cost; //Field offset: 0x40
	[SerializeField]
	public float radius; //Field offset: 0x44
	[SerializeField]
	public float range; //Field offset: 0x48
	[SerializeField]
	public bool ignoreBlockers; //Field offset: 0x4C
	[SerializeField]
	public bool ignoreTower; //Field offset: 0x4D
	[SerializeField]
	public bool isGlobalRange; //Field offset: 0x4E
	[SerializeField]
	public bool dontDisplayUpgrades; //Field offset: 0x4F
	[SerializeField]
	public bool doesntRotate; //Field offset: 0x50
	[SerializeField]
	public bool canAlwaysBeSold; //Field offset: 0x51
	[SerializeField]
	public bool ignoreMaxSellPercent; //Field offset: 0x52
	[SerializeField]
	public bool blockSelling; //Field offset: 0x53
	[SerializeField]
	public bool dontAddMutatorsFromParent; //Field offset: 0x54
	[SerializeField]
	public bool destroyTowerOnRedistribution; //Field offset: 0x55
	[SerializeField]
	public float sellbackModifierAdd; //Field offset: 0x58
	[SerializeField]
	public PrefabReference secondarySelectionMenu; //Field offset: 0x60
	[SerializeField]
	public SpriteReference icon; //Field offset: 0x68
	[SerializeField]
	public SpriteReference portrait; //Field offset: 0x70
	[SerializeField]
	public SpriteReference instaIcon; //Field offset: 0x78
	[SerializeField]
	public PrefabReference display; //Field offset: 0x80
	[SerializeField]
	public SpriteReference emoteSpriteSmall; //Field offset: 0x88
	[SerializeField]
	public SpriteReference emoteSpriteLarge; //Field offset: 0x90
	[SerializeField]
	public string towerSelectionMenuThemeId; //Field offset: 0x98
	[SerializeField]
	public String[] appliedUpgrades; //Field offset: 0xA0
	[SerializeField]
	public Int32[] tiers; //Field offset: 0xA8
	[SerializeField]
	public int tier; //Field offset: 0xB0
	[JsonConverter(typeof(BehaviorConverter))]
	[SerializeField]
	public Behavior[] behaviors; //Field offset: 0xB8
	[SerializeField]
	public Footprint footprint; //Field offset: 0xC0
	[SerializeField]
	public ApplyMod[] mods; //Field offset: 0xC8
	[SerializeField]
	public MonkeyAnimationController controller; //Field offset: 0xD0
	[SerializeField]
	public UpgradePath[] upgradePaths; //Field offset: 0xD8
	[SerializeField]
	public Hero hero; //Field offset: 0xE0
	[SerializeField]
	public EntityEvent[] events; //Field offset: 0xE8

	public virtual TowerModel Def
	{
		 get { } //Length: 1376
	}

	public virtual EntityEvent[] Events
	{
		 get { } //Length: 8
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public Tower() { }

	public virtual TowerModel get_Def() { }

	public virtual EntityEvent[] get_Events() { }

	public virtual Model get_Model() { }

}

