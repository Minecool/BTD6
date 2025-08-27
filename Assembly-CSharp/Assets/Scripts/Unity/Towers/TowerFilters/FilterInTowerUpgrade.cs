namespace Assets.Scripts.Unity.Towers.TowerFilters;

public class FilterInTowerUpgrade : TowerFilter
{
	public FilterInTowerUpgrade parent; //Field offset: 0x88
	public int path1; //Field offset: 0x90
	public string expPath1; //Field offset: 0x98
	public int path2; //Field offset: 0xA0
	public string expPath2; //Field offset: 0xA8
	public int path3; //Field offset: 0xB0
	public string expPath3; //Field offset: 0xB8
	public bool includeAbove; //Field offset: 0xC0
	public string expIncludeAbove; //Field offset: 0xC8

	public virtual TowerFilterModel Def
	{
		 get { } //Length: 162
	}

	public FilterInTowerUpgrade() { }

	public virtual TowerFilterModel get_Def() { }

}

