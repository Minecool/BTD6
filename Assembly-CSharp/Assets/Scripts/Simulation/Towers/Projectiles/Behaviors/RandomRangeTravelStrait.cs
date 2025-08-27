namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RandomRangeTravelStrait : ProjectileBehavior
{
	public RandomRangeTravelStraitModel randomRangeTravelStraitModel; //Field offset: 0x68
	private int lifespanFrames; //Field offset: 0x70
	private float startSpeed; //Field offset: 0x74

	public RandomRangeTravelStrait() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public void Recalculate() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

