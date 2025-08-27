namespace Assets.Scripts.Models.TowerSets;

public class ShopTowerDetailsModel : TowerDetailsModel
{
	public int pathOneMax; //Field offset: 0x40
	public int pathTwoMax; //Field offset: 0x44
	public int pathThreeMax; //Field offset: 0x48

	public ShopTowerDetailsModel(string towerId, int towerIndex, int pathOneMax, int pathTwoMax, int pathThreeMax, int towerCount) { }

	public virtual Model Clone() { }

	public int GetPathMax(int path) { }

}

