namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Slow : ProjectileBehavior
{
	public SlowModel slowModel; //Field offset: 0x68
	public int lifespan; //Field offset: 0x70

	public Slow() { }

	public virtual void Collide(Bloon bloon) { }

	public override int GetLifespanFrames() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

