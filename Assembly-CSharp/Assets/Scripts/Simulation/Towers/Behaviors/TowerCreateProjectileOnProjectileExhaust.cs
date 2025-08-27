namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerCreateProjectileOnProjectileExhaust : TowerBehavior
{
	public TowerCreateProjectileOnProjectileExhaustModel towerCreateProjectileOnProjectileExhaustModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70

	public TowerCreateProjectileOnProjectileExhaust() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void OnProjectileExhausted(Projectile projectile) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

