namespace Assets.Scripts.Simulation.Map;

public class RegenRemovable : CommonBehaviorProxy<IEntityBehavior>, ISelectable, ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{
	public RegenRemovableModel regenRemovableModel; //Field offset: 0x150
	public bool isActive; //Field offset: 0x158

	public RegenRemovable() { }

	public override void Hilight() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Remove() { }

	public override void Selected() { }

	public override void UnHighlight() { }

	public override void UnSelected() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

