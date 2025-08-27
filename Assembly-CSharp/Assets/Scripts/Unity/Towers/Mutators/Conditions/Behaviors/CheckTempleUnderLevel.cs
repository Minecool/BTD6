namespace Assets.Scripts.Unity.Towers.Mutators.Conditions.Behaviors;

public class CheckTempleUnderLevel : Conditional
{
	public int cost; //Field offset: 0x88
	public string expCost; //Field offset: 0x90
	public string towerSet; //Field offset: 0x98
	public string expTowerSet; //Field offset: 0xA0
	public string templeType; //Field offset: 0xA8
	public string expTempleType; //Field offset: 0xB0

	public virtual ConditionalModel Def
	{
		 get { } //Length: 209
	}

	public CheckTempleUnderLevel() { }

	public virtual ConditionalModel get_Def() { }

}

