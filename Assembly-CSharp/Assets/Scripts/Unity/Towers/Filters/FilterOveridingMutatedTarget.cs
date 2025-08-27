namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterOveridingMutatedTarget : Filter
{
	public FilterOveridingMutatedTarget parent; //Field offset: 0x88
	public string mutationOverideOrder; //Field offset: 0x90
	public string expMutationOverideOrder; //Field offset: 0x98
	public string highestPriorityMutationId; //Field offset: 0xA0
	public string expHighestPriorityMutationId; //Field offset: 0xA8
	public string defaultMutationId; //Field offset: 0xB0
	public string expDefaultMutationId; //Field offset: 0xB8

	public virtual FilterModel Def
	{
		 get { } //Length: 212
	}

	public FilterOveridingMutatedTarget() { }

	public virtual FilterModel get_Def() { }

}

