namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterMutatedTarget", menuName = "BTD6/Behaviors/Filters/FilterMutatedTarget")]
public class FilterMutatedTarget : Filter
{
	public string mutationId; //Field offset: 0x30
	public bool inverse; //Field offset: 0x38

	public virtual FilterModel Def
	{
		 get { } //Length: 129
	}

	public FilterMutatedTarget() { }

	public virtual FilterModel get_Def() { }

}

