namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CollectCashZone : TowerBehavior
{
	public CollectCashZoneModel collectCashZoneModel; //Field offset: 0x68
	private Vector3Boxed collectPoint; //Field offset: 0x70

	public CollectCashZone() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayAnimation(Projectile projectile) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

