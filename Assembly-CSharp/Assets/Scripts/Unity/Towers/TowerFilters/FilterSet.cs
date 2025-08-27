namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterSet : TowerFilter
{
	public FilterSet parent; //Field offset: 0x88
	public string towerSets; //Field offset: 0x90
	public string expTowerSets; //Field offset: 0x98

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 118
	}

	public FilterSet() { }

	public virtual TowerFilterModel get_Def() { }

}

