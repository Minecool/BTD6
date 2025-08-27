namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class MorphBloon : ProjectileBehavior
{
	public MorphBloonModel morphBloonModel; //Field offset: 0x68

	public MorphBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

