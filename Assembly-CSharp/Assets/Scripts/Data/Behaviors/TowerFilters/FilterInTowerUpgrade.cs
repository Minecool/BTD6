namespace Assets.Scripts.Data.Behaviors.TowerFilters;

[CreateAssetMenu(fileName = "FilterInTowerUpgrade", menuName = "BTD6/Behaviors/TowerFilters/FilterInTowerUpgrade")]
public class FilterInTowerUpgrade : TowerFilter
{
	public int path1; //Field offset: 0x28
	public int path2; //Field offset: 0x2C
	public int path3; //Field offset: 0x30
	public bool includeAbove; //Field offset: 0x34

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 150
	}

	public FilterInTowerUpgrade() { }

	public virtual TowerFilterModel get_Def() { }

}

