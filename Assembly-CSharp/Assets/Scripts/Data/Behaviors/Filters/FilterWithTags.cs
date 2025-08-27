namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterWithTags", menuName = "BTD6/Behaviors/Filters/FilterWithTags")]
public class FilterWithTags : Filter
{
	public string bloonTags; //Field offset: 0x30
	public bool inclusive; //Field offset: 0x38

	public virtual FilterModel Def
	{
		 get { } //Length: 183
	}

	public FilterWithTags() { }

	public virtual FilterModel get_Def() { }

}

