namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class PowerProjectile : ProjectileBehavior
{
	public PowerProjectileModel powerProjectileModel; //Field offset: 0x68

	public PowerProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

