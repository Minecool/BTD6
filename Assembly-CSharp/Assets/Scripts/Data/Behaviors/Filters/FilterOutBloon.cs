namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterOutBloon", menuName = "BTD6/Behaviors/Filters/FilterOutBloon")]
public class FilterOutBloon : Filter
{
	public string bloonId; //Field offset: 0x30

	public virtual FilterModel Def
	{
		 get { } //Length: 105
	}

	public FilterOutBloon() { }

	public virtual FilterModel get_Def() { }

}

