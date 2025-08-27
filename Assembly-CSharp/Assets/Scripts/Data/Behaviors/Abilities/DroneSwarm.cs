namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "DroneSwarm", menuName = "BTD6/Behaviors/Abilities/DroneSwarm")]
public class DroneSwarm : AbilityBehavior
{
	public float duration; //Field offset: 0x30
	public DroneSupport droneSupport; //Field offset: 0x38
	public float droneEndRadius; //Field offset: 0x40

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 263
	}

	public DroneSwarm() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

