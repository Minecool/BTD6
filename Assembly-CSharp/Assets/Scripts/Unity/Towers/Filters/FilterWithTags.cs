namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterWithTags : Filter
{
	public FilterWithTags parent; //Field offset: 0x88
	public string bloonTags; //Field offset: 0x90
	public string expBloonTags; //Field offset: 0x98
	public bool inclusive; //Field offset: 0xA0
	public string expInclusive; //Field offset: 0xA8

	public virtual FilterModel Def
	{
		 get { } //Length: 189
	}

	public FilterWithTags() { }

	public virtual FilterModel get_Def() { }

}

