namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class MoveWithWind : BloonBehavior
{
	public MoveWithWindModel moveWithWindModel; //Field offset: 0x70

	public MoveWithWind() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

