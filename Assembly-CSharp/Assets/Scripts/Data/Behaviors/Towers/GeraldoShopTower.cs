namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "GeraldoShopTower", menuName = "BTD6/Behaviors/Towers/GeraldoShopTower")]
public class GeraldoShopTower : Tower
{
	public string geraldoItemName; //Field offset: 0xF0

	public virtual TowerModel Def
	{
		 get { } //Length: 1367
	}

	public GeraldoShopTower() { }

	public virtual TowerModel get_Def() { }

}

