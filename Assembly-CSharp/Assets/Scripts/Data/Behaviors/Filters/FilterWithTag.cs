namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterWithTag", menuName = "BTD6/Behaviors/Filters/FilterWithTag")]
public class FilterWithTag : Filter
{
	public string bloonTag; //Field offset: 0x30
	public string inclusive; //Field offset: 0x38

	public virtual FilterModel Def
	{
		 get { } //Length: 159
	}

	public FilterWithTag() { }

	public virtual FilterModel get_Def() { }

}

