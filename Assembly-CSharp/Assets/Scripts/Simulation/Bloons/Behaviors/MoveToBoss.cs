namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class MoveToBoss : BloonBehavior
{
	public MoveToBossModel moveToBossModel; //Field offset: 0x70
	private Bloon bossBloon; //Field offset: 0x78

	public MoveToBoss() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

