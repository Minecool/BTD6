namespace Assets.Scripts.Simulation.Behaviors;

public class TextDisplayBehavior : RootBehavior
{
	public readonly TextDisplayNode node; //Field offset: 0x58
	public DisplayCategory DisplayCategory; //Field offset: 0x60

	public TextDisplayBehavior() { }

	public virtual void Attatched() { }

	protected virtual void OnDestroy() { }

}

