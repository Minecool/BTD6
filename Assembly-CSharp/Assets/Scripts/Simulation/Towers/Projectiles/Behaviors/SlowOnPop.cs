namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SlowOnPop : Slow
{
	public SlowOnPopModel slowOnPopModel; //Field offset: 0x78

	public SlowOnPop() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual int GetLifespanFrames() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

