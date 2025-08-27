namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterOveridingMutatedTarget", menuName = "BTD6/Behaviors/Filters/FilterOveridingMutatedTarget")]
public class FilterOveridingMutatedTarget : Filter
{
	public string mutationOverideOrder; //Field offset: 0x30
	public string highestPriorityMutationId; //Field offset: 0x38
	public string defaultMutationId; //Field offset: 0x40

	public virtual FilterModel Def
	{
		 get { } //Length: 203
	}

	public FilterOveridingMutatedTarget() { }

	public virtual FilterModel get_Def() { }

}

