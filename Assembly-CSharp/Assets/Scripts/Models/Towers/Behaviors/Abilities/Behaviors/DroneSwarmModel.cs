namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(DroneSwarm), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DroneSwarmModel : AbilityBehaviorModel
{
	[SerializeField]
	private float duration; //Field offset: 0x30
	public int durationFrames; //Field offset: 0x34
	public DroneSupportModel droneSupportModel; //Field offset: 0x38
	public float droneEndRadius; //Field offset: 0x40
	public float droneEndRadiusSquared; //Field offset: 0x44

	public DroneSwarmModel(string name, float duration, DroneSupportModel droneSupportModel, float droneEndRadius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

