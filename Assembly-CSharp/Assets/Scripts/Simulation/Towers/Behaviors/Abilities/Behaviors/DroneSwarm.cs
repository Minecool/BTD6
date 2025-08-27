namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class DroneSwarm : AbilityBehavior
{
	public DroneSwarmModel droneSwarmModel; //Field offset: 0x68
	private int activatedAt; //Field offset: 0x70
	private bool isActive; //Field offset: 0x74
	private bool hasSetTargetTypes; //Field offset: 0x75
	private DroneSupport droneSupport; //Field offset: 0x78
	private bool isMovingBack; //Field offset: 0x80
	private List<Tower> dronesToRemove; //Field offset: 0x88

	public DroneSwarm() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private void Deactivate() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	private void SetTargetTypes() { }

	private void StartMovingBack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

