namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterWithChance : Filter
{
	public FilterWithChance parent; //Field offset: 0x88
	public float filterPercentage; //Field offset: 0x90
	public string expFilterPercentage; //Field offset: 0x98

	public virtual FilterModel Def
	{
		 get { } //Length: 109
	}

	public FilterWithChance() { }

	public virtual FilterModel get_Def() { }

}

