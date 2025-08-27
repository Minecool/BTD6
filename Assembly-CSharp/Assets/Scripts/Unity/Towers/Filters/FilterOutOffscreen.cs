namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterOutOffscreen : Filter
{
	public FilterOutOffscreen parent; //Field offset: 0x88
	public bool includeBloonRadius; //Field offset: 0x90
	public string expIncludeBloonRadius; //Field offset: 0x98

	public virtual FilterModel Def
	{
		 get { } //Length: 109
	}

	public FilterOutOffscreen() { }

	public virtual FilterModel get_Def() { }

}

