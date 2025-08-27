namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterMoab", menuName = "BTD6/Behaviors/Filters/FilterMoab")]
public class FilterMoab : Filter
{
	public bool flip; //Field offset: 0x30

	public virtual FilterModel Def
	{
		 get { } //Length: 106
	}

	public FilterMoab() { }

	public virtual FilterModel get_Def() { }

}

