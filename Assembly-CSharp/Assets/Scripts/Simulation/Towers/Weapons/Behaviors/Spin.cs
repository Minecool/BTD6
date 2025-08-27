namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class Spin : WeaponBehavior
{
	public SpinModel spinModel; //Field offset: 0x68
	private float angle; //Field offset: 0x70

	public Spin() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

