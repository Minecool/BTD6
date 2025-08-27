namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterTowerParent : TowerFilter
{
	public FilterTowerParent parent; //Field offset: 0x88

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 88
	}

	public FilterTowerParent() { }

	public virtual TowerFilterModel get_Def() { }

}

