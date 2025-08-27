namespace Assets.Scripts.Data.Behaviors.TowerFilters;

[CreateAssetMenu(fileName = "FilterInTowerTiers", menuName = "BTD6/Behaviors/TowerFilters/FilterInTowerTiers")]
public class FilterInTowerTiers : TowerFilter
{
	public int path1MinTier; //Field offset: 0x28
	public int path1MaxTier; //Field offset: 0x2C
	public int path2MinTier; //Field offset: 0x30
	public int path2MaxTier; //Field offset: 0x34
	public int path3MinTier; //Field offset: 0x38
	public int path3MaxTier; //Field offset: 0x3C

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 173
	}

	public FilterInTowerTiers() { }

	public virtual TowerFilterModel get_Def() { }

}

