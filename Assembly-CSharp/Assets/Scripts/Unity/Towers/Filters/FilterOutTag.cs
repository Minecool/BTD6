namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterOutTag : Filter
{
	public FilterOutTag parent; //Field offset: 0x88
	public string bloonTag; //Field offset: 0x90
	public string expBloonTag; //Field offset: 0x98
	public string disableWhenSupportMutatorID; //Field offset: 0xA0
	public string expDisableWhenSupportMutatorID; //Field offset: 0xA8

	public virtual FilterModel Def
	{
		 get { } //Length: 222
	}

	public FilterOutTag() { }

	public virtual FilterModel get_Def() { }

}

