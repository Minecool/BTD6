namespace Assets.Scripts.Models.Towers.TowerFilters;

[Implementation(typeof(FilterInTowerTiers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FilterInTowerTiersModel : TowerFilterModel
{
	public int path1MinTier; //Field offset: 0x30
	public int path1MaxTier; //Field offset: 0x34
	public int path2MinTier; //Field offset: 0x38
	public int path2MaxTier; //Field offset: 0x3C
	public int path3MinTier; //Field offset: 0x40
	public int path3MaxTier; //Field offset: 0x44

	public FilterInTowerTiersModel(string name, int path1MinTier, int path1MaxTier, int path2MinTier, int path2MaxTier, int path3MinTier, int path3MaxTier) { }

	public virtual Model Clone() { }

	public virtual TowerFilter Create(FactoryFactory factory) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

