namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class FilterTargetAngleFilter : WeaponBehavior
{
	public FilterTargetAngleFilterModel filterTargetAngleFilterModel; //Field offset: 0x68
	private DisplayBehavior display; //Field offset: 0x70
	private bool attemptDisplayBehaviorSearch; //Field offset: 0x78
	public List<FilterTargetAngleFilter> filterTargetAngleFilterBehaviors; //Field offset: 0x80
	public int timeOfLastTargetUpdate; //Field offset: 0x88
	public bool lastFireResult; //Field offset: 0x8C

	public FilterTargetAngleFilter() { }

	public virtual bool FilterEmission() { }

	private void FindDisplay() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

