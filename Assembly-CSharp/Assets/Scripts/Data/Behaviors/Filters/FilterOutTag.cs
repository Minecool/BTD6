namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterOutTag", menuName = "BTD6/Behaviors/Filters/FilterOutTag")]
public class FilterOutTag : Filter
{
	public string bloonTag; //Field offset: 0x30
	public string disableWhenSupportMutatorID; //Field offset: 0x38

	public virtual FilterModel Def
	{
		 get { } //Length: 182
	}

	public FilterOutTag() { }

	public virtual FilterModel get_Def() { }

}

