namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TravelTowardsEmitTower : ProjectileBehavior
{
	public TravelTowardsEmitTowerModel travelTowardsEmitTowerModel; //Field offset: 0x68
	public float speedMultiplier; //Field offset: 0x70
	private Vector3 targetDirection; //Field offset: 0x74
	public bool isProcessing; //Field offset: 0x80

	public TravelTowardsEmitTower() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

