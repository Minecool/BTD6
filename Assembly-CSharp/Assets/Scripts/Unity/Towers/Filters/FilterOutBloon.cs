namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterOutBloon : Filter
{
	public FilterOutBloon parent; //Field offset: 0x88
	public string bloonId; //Field offset: 0x90
	public string expBloonId; //Field offset: 0x98

	public virtual FilterModel Def
	{
		 get { } //Length: 108
	}

	public FilterOutBloon() { }

	public virtual FilterModel get_Def() { }

}

