namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ParagonTower", menuName = "BTD6/Behaviors/Towers/ParagonTower")]
public class ParagonTower : Tower
{
	public UpgradePath paragonUpgrade; //Field offset: 0xF0

	public virtual TowerModel Def
	{
		 get { } //Length: 1414
	}

	public ParagonTower() { }

	public virtual TowerModel get_Def() { }

}

