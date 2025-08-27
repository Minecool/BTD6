namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AddFreeTowerAfterRounds : TowerBehavior
{
	public AddFreeTowerAfterRounds parent; //Field offset: 0x98
	public string towerId; //Field offset: 0xA0
	public string expTowerId; //Field offset: 0xA8
	public int rounds; //Field offset: 0xB0
	public string expRounds; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 133
	}

	public AddFreeTowerAfterRounds() { }

	public virtual TowerBehaviorModel get_Def() { }

}

