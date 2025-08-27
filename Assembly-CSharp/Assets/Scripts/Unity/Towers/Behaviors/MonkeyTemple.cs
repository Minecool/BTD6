namespace Assets.Scripts.Unity.Towers.Behaviors;

public class MonkeyTemple : TowerBehavior
{
	public MonkeyTemple parent; //Field offset: 0x98
	public int towerGroupCount; //Field offset: 0xA0
	public string expTowerGroupCount; //Field offset: 0xA8
	public int placeAnimation; //Field offset: 0xB0
	public string expPlaceAnimation; //Field offset: 0xB8
	public int upgradeAnimation; //Field offset: 0xC0
	public string expUpgradeAnimation; //Field offset: 0xC8
	public float weaponDelay; //Field offset: 0xD0
	public string expWeaponDelay; //Field offset: 0xD8
	public string templeId; //Field offset: 0xE0
	public string expTempleId; //Field offset: 0xE8
	public Effect effect; //Field offset: 0xF0
	public Effect expEffect; //Field offset: 0xF8
	public Effect towerEffect; //Field offset: 0x100
	public Effect expTowerEffect; //Field offset: 0x108
	public Effect heroEffect; //Field offset: 0x110
	public Effect expHeroEffect; //Field offset: 0x118
	public Effect darkTransformationEffect; //Field offset: 0x120
	public Effect expDarkTransformationEffect; //Field offset: 0x128
	public Effect darkTheAntiBloonSacrificeEffect; //Field offset: 0x130
	public Effect expDarkTheAntiBloonSacrificeEffect; //Field offset: 0x138
	public Effect darkLegendOfTheNightSacrificeEffect; //Field offset: 0x140
	public Effect expDarkLegendOfTheNightSacrificeEffect; //Field offset: 0x148
	public int darkTransformationAnimation; //Field offset: 0x150
	public string expDarkTransformationAnimation; //Field offset: 0x158
	public float darkTransformationWeaponDelay; //Field offset: 0x160
	public string expDarkTransformationWeaponDelay; //Field offset: 0x168
	public AudioClip darkTransformSound; //Field offset: 0x170
	public AudioClip expDarkTransformSound; //Field offset: 0x178
	public AudioClip darkAltTransformSound; //Field offset: 0x180
	public AudioClip expDarkAltTransformSound; //Field offset: 0x188
	public float heroOverlapYAdjustment; //Field offset: 0x190
	public string expHeroOverlapYAdjustment; //Field offset: 0x198
	public GameObject[] darkTempleObjects; //Field offset: 0x1A0

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1355
	}

	public MonkeyTemple() { }

	public virtual TowerBehaviorModel get_Def() { }

}

