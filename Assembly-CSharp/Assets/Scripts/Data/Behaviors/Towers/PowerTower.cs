namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PowerTower", menuName = "BTD6/Behaviors/Towers/PowerTower")]
public class PowerTower : Tower
{
	public string powerName; //Field offset: 0xF0
	public bool showBuffsForPowerTower; //Field offset: 0xF8

	public virtual TowerModel Def
	{
		 get { } //Length: 1385
	}

	public PowerTower() { }

	public virtual TowerModel get_Def() { }

}

