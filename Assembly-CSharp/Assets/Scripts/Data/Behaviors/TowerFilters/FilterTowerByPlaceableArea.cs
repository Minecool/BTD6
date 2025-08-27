namespace Assets.Scripts.Data.Behaviors.TowerFilters;

[CreateAssetMenu(fileName = "FilterTowerByPlaceableArea", menuName = "BTD6/Behaviors/TowerFilters/FilterTowerByPlaceableArea")]
public class FilterTowerByPlaceableArea : TowerFilter
{
	public AreaType[] placeableAreas; //Field offset: 0x28

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 105
	}

	public FilterTowerByPlaceableArea() { }

	public virtual TowerFilterModel get_Def() { }

}

