namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterTowerBehavior : TowerFilter
{
	public FilterTowerBehavior parent; //Field offset: 0x88
	public string behaviorNames; //Field offset: 0x90
	public string expBehaviorNames; //Field offset: 0x98
	public bool inclusive; //Field offset: 0xA0
	public string expInclusive; //Field offset: 0xA8
	public bool requiresAllBehaviors; //Field offset: 0xB0
	public string expRequiresAllBehaviors; //Field offset: 0xB8

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 212
	}

	public FilterTowerBehavior() { }

	public virtual TowerFilterModel get_Def() { }

}

