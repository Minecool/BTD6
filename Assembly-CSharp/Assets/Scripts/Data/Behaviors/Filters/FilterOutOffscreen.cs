namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterOutOffscreen", menuName = "BTD6/Behaviors/Filters/FilterOutOffscreen")]
public class FilterOutOffscreen : Filter
{
	public bool includeBloonRadius; //Field offset: 0x30

	public virtual FilterModel Def
	{
		 get { } //Length: 106
	}

	public FilterOutOffscreen() { }

	public virtual FilterModel get_Def() { }

}

