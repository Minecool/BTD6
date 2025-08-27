namespace Assets.Scripts.Data.Behaviors.TowerFilters;

[CreateAssetMenu(fileName = "FilterParagon", menuName = "BTD6/Behaviors/TowerFilters/FilterParagon")]
public class FilterParagon : TowerFilter
{
	public bool inclusive; //Field offset: 0x28

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 106
	}

	public FilterParagon() { }

	public virtual TowerFilterModel get_Def() { }

}

