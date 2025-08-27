namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class AbilityCreateTower : AbilityBehavior
{
	public AbilityCreateTower parent; //Field offset: 0x88
	public Tower tower; //Field offset: 0x90
	public Tower expTower; //Field offset: 0x98
	public bool isAirBasedTower; //Field offset: 0xA0
	public string expIsAirBasedTower; //Field offset: 0xA8
	public bool trackCirclePosition; //Field offset: 0xB0
	public string exptrackCirclePosition; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 178
	}

	public AbilityCreateTower() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

