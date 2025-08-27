namespace Assets.Scripts.Simulation.Towers.Props;

public abstract class PropBehavior : RootBehavior
{
	public Prop prop; //Field offset: 0x58

	protected PropBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void OnPlace() { }

	public override void OnSold() { }

}

