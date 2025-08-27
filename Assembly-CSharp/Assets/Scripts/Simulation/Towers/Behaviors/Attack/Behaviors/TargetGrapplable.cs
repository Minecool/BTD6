namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetGrapplable : TargetSupplier
{
	public TargetGrapplableModel targetGrapplableModel; //Field offset: 0x68
	private MultiHookManager multiHookManager; //Field offset: 0x70
	private BloonFilter bloonFilter; //Field offset: 0x78

	public TargetGrapplable() { }

	private static float BloonDanger(Bloon bloon) { }

	private bool FilterBloon(Bloon bloon) { }

	public int GetHooksRequired(Bloon bloon) { }

	public virtual string GetName() { }

	public virtual Target GetTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

