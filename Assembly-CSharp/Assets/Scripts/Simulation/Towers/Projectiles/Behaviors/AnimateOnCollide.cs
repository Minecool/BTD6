namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AnimateOnCollide : ProjectileBehavior
{
	public AnimateOnCollideModel animateOnCollideModel; //Field offset: 0x68

	public AnimateOnCollide() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

