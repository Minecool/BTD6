namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SlowForBloon : Slow
{
	public SlowForBloonModel slowForBloonModel; //Field offset: 0x78

	public SlowForBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

