namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterInBaseTowerId : TowerFilter
{
	public FilterInBaseTowerId parent; //Field offset: 0x88
	public string baseId; //Field offset: 0x90
	public string expBaseId; //Field offset: 0x98

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 162
	}

	public FilterInBaseTowerId() { }

	public virtual TowerFilterModel get_Def() { }

}

