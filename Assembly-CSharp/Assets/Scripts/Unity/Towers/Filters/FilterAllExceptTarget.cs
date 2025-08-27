namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterAllExceptTarget : Filter
{
	public FilterAllExceptTarget parent; //Field offset: 0x88
	public bool cantBePaused; //Field offset: 0x90
	public string expCantBePaused; //Field offset: 0x98

	public virtual FilterModel Def
	{
		 get { } //Length: 109
	}

	public FilterAllExceptTarget() { }

	public virtual FilterModel get_Def() { }

}

