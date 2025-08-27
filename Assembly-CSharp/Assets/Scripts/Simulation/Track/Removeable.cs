namespace Assets.Scripts.Simulation.Track;

public class Removeable : CommonBehaviorProxy<IEntityBehavior>, ISelectable, ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{
	public RemoveableModel removeableModel; //Field offset: 0x150
	public bool isActive; //Field offset: 0x158

	public Removeable() { }

	public override void Hilight() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public override void Selected() { }

	public override void UnHighlight() { }

	public override void UnSelected() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

