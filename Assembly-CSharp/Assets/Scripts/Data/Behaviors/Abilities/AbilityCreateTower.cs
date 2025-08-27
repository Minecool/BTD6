namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "AbilityCreateTower", menuName = "BTD6/Behaviors/Abilities/AbilityCreateTower")]
public class AbilityCreateTower : AbilityBehavior
{
	public Tower tower; //Field offset: 0x30
	public bool isAirBasedTower; //Field offset: 0x38
	public bool trackCirclePosition; //Field offset: 0x39
	public string exptrackCirclePosition; //Field offset: 0x40

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 181
	}

	public AbilityCreateTower() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

