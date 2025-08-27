namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerCreateProjectileOnCrit : TowerBehavior
{
	public TowerCreateProjectileOnCritModel towerCreateProjectileOnCritModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70

	public TowerCreateProjectileOnCrit() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnTowerCrit(Projectile projectile) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

