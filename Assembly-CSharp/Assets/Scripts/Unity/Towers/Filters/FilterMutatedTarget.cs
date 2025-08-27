namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterMutatedTarget : Filter
{
	public FilterMutatedTarget parent; //Field offset: 0x88
	public string mutationId; //Field offset: 0x90
	public string expMutationId; //Field offset: 0x98
	public bool inverse; //Field offset: 0xA0
	public string expInverse; //Field offset: 0xA8

	public virtual FilterModel Def
	{
		 get { } //Length: 135
	}

	public FilterMutatedTarget() { }

	public virtual FilterModel get_Def() { }

}

