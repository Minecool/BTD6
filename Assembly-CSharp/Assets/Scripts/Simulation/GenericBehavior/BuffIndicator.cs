namespace Assets.Scripts.Simulation.GenericBehavior;

public class BuffIndicator : RootBehavior
{
	public BuffIndicatorModel buffIndicatorModel; //Field offset: 0x58

	public BuffIndicator() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

