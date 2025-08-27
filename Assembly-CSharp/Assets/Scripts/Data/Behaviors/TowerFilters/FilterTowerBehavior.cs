namespace Assets.Scripts.Data.Behaviors.TowerFilters;

[CreateAssetMenu(fileName = "FilterTowerBehavior", menuName = "BTD6/Behaviors/TowerFilters/FilterTowerBehavior")]
public class FilterTowerBehavior : TowerFilter
{
	public string behaviorNames; //Field offset: 0x28
	public bool inclusive; //Field offset: 0x30
	public bool requiresAllBehaviors; //Field offset: 0x31

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 203
	}

	public FilterTowerBehavior() { }

	public virtual TowerFilterModel get_Def() { }

}

