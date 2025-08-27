namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterWithChance", menuName = "BTD6/Behaviors/Filters/FilterWithChance")]
public class FilterWithChance : Filter
{
	public float filterPercentage; //Field offset: 0x30

	public virtual FilterModel Def
	{
		 get { } //Length: 106
	}

	public FilterWithChance() { }

	public virtual FilterModel get_Def() { }

}

