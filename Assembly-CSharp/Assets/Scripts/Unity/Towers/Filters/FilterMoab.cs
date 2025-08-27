namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterMoab : Filter
{
	public FilterMoab parent; //Field offset: 0x88
	public bool flip; //Field offset: 0x90
	public string expFlip; //Field offset: 0x98

	public virtual FilterModel Def
	{
		 get { } //Length: 109
	}

	public FilterMoab() { }

	public virtual FilterModel get_Def() { }

}

