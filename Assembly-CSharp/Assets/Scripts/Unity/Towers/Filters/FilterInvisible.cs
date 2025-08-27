namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterInvisible : Filter
{
	public FilterInvisible parent; //Field offset: 0x88
	public string isActive; //Field offset: 0x90
	public string expIsActive; //Field offset: 0x98
	public string ignoreBroadPhase; //Field offset: 0xA0
	public string expIgnoreBroadPhase; //Field offset: 0xA8

	public virtual FilterModel Def
	{
		 get { } //Length: 318
	}

	public FilterInvisible() { }

	public virtual FilterModel get_Def() { }

}

