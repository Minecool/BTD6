namespace Assets.Scripts.Data.Behaviors.TowerFilters;

[CreateAssetMenu(fileName = "FilterSet", menuName = "BTD6/Behaviors/TowerFilters/FilterSet")]
public class FilterSet : TowerFilter
{
	public string towerSets; //Field offset: 0x28

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 115
	}

	public FilterSet() { }

	public virtual TowerFilterModel get_Def() { }

}

