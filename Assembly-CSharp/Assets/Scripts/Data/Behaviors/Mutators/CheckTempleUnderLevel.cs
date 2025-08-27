namespace Assets.Scripts.Data.Behaviors.Mutators;

[CreateAssetMenu(fileName = "CheckTempleUnderLevel", menuName = "BTD6/Behaviors/Mutators/CheckTempleUnderLevel")]
public class CheckTempleUnderLevel : Conditional
{
	public int cost; //Field offset: 0x28
	public string towerSet; //Field offset: 0x30
	public string templeType; //Field offset: 0x38

	public virtual ConditionalModel Def
	{
		 get { } //Length: 200
	}

	public CheckTempleUnderLevel() { }

	public virtual ConditionalModel get_Def() { }

}

