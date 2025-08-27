namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class DroneSwarm : AbilityBehavior
{
	public DroneSwarm parent; //Field offset: 0x88
	public float duration; //Field offset: 0x90
	public string expDuration; //Field offset: 0x98
	public DroneSupport droneSupport; //Field offset: 0xA0
	public DroneSupport expDroneSupport; //Field offset: 0xA8
	public float droneEndRadius; //Field offset: 0xB0
	public string expDroneEndRadius; //Field offset: 0xB8

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 298
	}

	public DroneSwarm() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

