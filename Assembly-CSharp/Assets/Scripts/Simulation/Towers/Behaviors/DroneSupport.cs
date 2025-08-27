namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DroneSupport : TowerBehavior
{
	public DroneSupportModel droneSupportModel; //Field offset: 0x68
	private List<Tower> drones; //Field offset: 0x70
	private List<TimedMutator> toRemoveList; //Field offset: 0x78
	public bool spawnAndUpdateDrones; //Field offset: 0x80
	public bool canMakeDrones; //Field offset: 0x81

	public List<Tower> Drones
	{
		 get { } //Length: 5
	}

	public DroneSupport() { }

	public List<Tower> get_Drones() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	private void OnTowerDestroyed(Tower destroyedTower) { }

	private void OnTowerRepositioned(bool onTheMove) { }

	public virtual void OnUpgrade(bool playUpgradeEffect) { }

	private void Process(int elapsed) { }

	public void RemoveDrone(Tower droneToRemove) { }

	public void SpawnDrones() { }

	private void SyncMutators() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateDroneTargetTypes() { }

}

