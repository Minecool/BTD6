namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class FadeProjectile : ProjectileBehavior
{
	public FadeProjectileModel fadeProjectileModel; //Field offset: 0x68

	public FadeProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

