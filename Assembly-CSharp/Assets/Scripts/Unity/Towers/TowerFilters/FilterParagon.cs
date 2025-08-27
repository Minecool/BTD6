namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterParagon : TowerFilter
{
	public FilterParagon parent; //Field offset: 0x88
	public bool inclusive; //Field offset: 0x90
	public string expInclusive; //Field offset: 0x98

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 109
	}

	public FilterParagon() { }

	public virtual TowerFilterModel get_Def() { }

}

