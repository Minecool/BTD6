namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterWithTag : Filter
{
	public FilterWithTag parent; //Field offset: 0x88
	public string bloonTag; //Field offset: 0x90
	public string expBloonTag; //Field offset: 0x98
	public string inclusive; //Field offset: 0xA0
	public string expInclusive; //Field offset: 0xA8

	public virtual FilterModel Def
	{
		 get { } //Length: 165
	}

	public FilterWithTag() { }

	public virtual FilterModel get_Def() { }

}

