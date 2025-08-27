namespace Assets.Scripts.Data.Behaviors.TowerFilters;

[CreateAssetMenu(fileName = "FilterInBaseTowerId", menuName = "BTD6/Behaviors/TowerFilters/FilterInBaseTowerId")]
public class FilterInBaseTowerId : TowerFilter
{
	public string baseId; //Field offset: 0x28

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 159
	}

	public FilterInBaseTowerId() { }

	public virtual TowerFilterModel get_Def() { }

}

