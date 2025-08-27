namespace Assets.Scripts.Simulation.Props;

public abstract class PropBehavior : EntityBehavior
{
	public Prop prop; //Field offset: 0x60

	protected PropBehavior() { }

	public virtual void Cleanup() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

}

