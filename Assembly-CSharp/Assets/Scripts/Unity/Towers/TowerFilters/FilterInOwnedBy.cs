namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterInOwnedBy : TowerFilter
{
	public FilterInOwnedBy parent; //Field offset: 0x88

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 88
	}

	public FilterInOwnedBy() { }

	public virtual TowerFilterModel get_Def() { }

}

