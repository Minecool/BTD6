namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddBonusDamagePerHitToBloon : ProjectileBehavior
{
	public AddBonusDamagePerHitToBloonModel def; //Field offset: 0x68

	public AddBonusDamagePerHitToBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

