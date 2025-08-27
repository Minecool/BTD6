namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ProjectileHeight : ProjectileBehavior
{
	public ProjectileHeightModel projectileHeight; //Field offset: 0x68
	private IPath heightEase; //Field offset: 0x70
	private Vector3 towerPosition; //Field offset: 0x78

	public ProjectileHeight() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

