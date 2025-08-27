namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DamageInRingRadius : Damage
{
	public DamageInRingRadiusModel damageInRingRadiusModel; //Field offset: 0x70

	public DamageInRingRadius() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

