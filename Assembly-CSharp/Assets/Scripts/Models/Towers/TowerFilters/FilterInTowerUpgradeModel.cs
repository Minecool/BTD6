namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterInTowerUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterInTowerUpgradeModel : TowerFilterModel
{
	public int path1; //Field offset: 0x30
	public int path2; //Field offset: 0x34
	public int path3; //Field offset: 0x38
	public bool includeAbove; //Field offset: 0x3C

	public FilterInTowerUpgradeModel(string name, int path1, int path2, int path3, bool includeAbove) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

