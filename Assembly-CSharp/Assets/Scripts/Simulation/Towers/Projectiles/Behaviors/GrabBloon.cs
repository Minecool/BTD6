namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class GrabBloon : ProjectileBehavior
{
	public GrabBloonModel grabBloonModel; //Field offset: 0x68

	public GrabBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

