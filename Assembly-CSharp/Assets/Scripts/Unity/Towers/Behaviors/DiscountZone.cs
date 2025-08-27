namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DiscountZone : TowerBehaviorBuff
{
	public DiscountZone parent; //Field offset: 0xB8
	public float discountMultiplier; //Field offset: 0xC0
	public string expDiscountMultiplier; //Field offset: 0xC8
	public float stackLimit; //Field offset: 0xD0
	public string expStackLimit; //Field offset: 0xD8
	public string stackName; //Field offset: 0xE0
	public string expStackName; //Field offset: 0xE8
	public bool affectSelf; //Field offset: 0xF0
	public string expAffectSelf; //Field offset: 0xF8
	public int tierCap; //Field offset: 0x100
	public string expTierCap; //Field offset: 0x108
	public string towerBaseIds; //Field offset: 0x110
	public string expTowerBaseIds; //Field offset: 0x118
	public string upgradeId; //Field offset: 0x120
	public string expUpgradeId; //Field offset: 0x128
	public bool dontAffectOthersInCoop; //Field offset: 0x130
	public string expDontAffectOthersInCoop; //Field offset: 0x138
	public int tierMin; //Field offset: 0x140
	public string expTierMin; //Field offset: 0x148
	public bool isGlobal; //Field offset: 0x150
	public string expIsGlobal; //Field offset: 0x158

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 346
	}

	public DiscountZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

