namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterTowerByPlaceableArea : TowerFilter
{
	public FilterTowerByPlaceableArea parent; //Field offset: 0x88
	public string placeableArea; //Field offset: 0x90
	public string expPlaceableArea; //Field offset: 0x98

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 606
	}

	public FilterTowerByPlaceableArea() { }

	public virtual TowerFilterModel get_Def() { }

}

