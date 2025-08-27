namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateProjectileOnTowerDestroy : TowerBehavior
{
	public CreateProjectileOnTowerDestroyModel createProjectileOnTowerDestroyModel; //Field offset: 0x68
	public bool expireImmediately; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78

	public CreateProjectileOnTowerDestroy() { }

	private void CreateProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnExpire() { }

	public virtual void OnSold(float amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

