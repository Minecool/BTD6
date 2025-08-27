namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterTowerByPlaceableArea), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterTowerByPlaceableAreaModel : TowerFilterModel
{
	public AreaType[] areaTypes; //Field offset: 0x30

	public FilterTowerByPlaceableAreaModel(string name, AreaType[] areaTypes) { }

	public virtual Model Clone() { }

	private bool CompareArrays(AreaType[] a1, AreaType[] a2) { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

