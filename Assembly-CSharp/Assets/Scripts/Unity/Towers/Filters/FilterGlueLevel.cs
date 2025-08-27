namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterGlueLevel : Filter
{
	public FilterGlueLevel parent; //Field offset: 0x88
	public int glueLevel; //Field offset: 0x90
	public string expGlueLevel; //Field offset: 0x98

	public virtual FilterModel Def
	{
		 get { } //Length: 137
	}

	public FilterGlueLevel() { }

	public virtual FilterModel get_Def() { }

}

