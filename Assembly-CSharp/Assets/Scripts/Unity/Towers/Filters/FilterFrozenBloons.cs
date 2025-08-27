namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterFrozenBloons : Filter
{
	public FilterFrozenBloons parent; //Field offset: 0x88

	public virtual FilterModel Def
	{
		 get { } //Length: 88
	}

	public FilterFrozenBloons() { }

	public virtual FilterModel get_Def() { }

}

