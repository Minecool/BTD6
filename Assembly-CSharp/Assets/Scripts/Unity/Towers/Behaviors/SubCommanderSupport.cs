namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SubCommanderSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0xC8
	public string expIsUnique; //Field offset: 0xD0
	public int pierceIncrease; //Field offset: 0xD8
	public string expPierceIncrease; //Field offset: 0xE0
	public int damageIncrease; //Field offset: 0xE8
	public string expDamageIncrease; //Field offset: 0xF0
	public float damageScale; //Field offset: 0xF8
	public string expDamageScale; //Field offset: 0x100
	public string filterTower; //Field offset: 0x108
	public string expFilterTower; //Field offset: 0x110
	public bool appliesToOwningTower; //Field offset: 0x118
	public string expAppliesToOwningTower; //Field offset: 0x120

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 805
	}

	public SubCommanderSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

