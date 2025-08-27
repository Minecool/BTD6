namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AddBehaviorToTowerTypeSupport : AddBehaviorToTowerSupport
{
	public string towerTypeIds; //Field offset: 0xF8
	public string expTowerTypeIds; //Field offset: 0x100

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 409
	}

	public AddBehaviorToTowerTypeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

