namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class PursuitSettingCustom : PursuitSetting
{
	public PursuitSettingCustomModel pursuitSettingCustomModel; //Field offset: 0xD0
	public TargetType currentTargetType; //Field offset: 0xD8
	public Tower parentTower; //Field offset: 0xF0
	private Nullable<Vector2> lastPositionInsideParent; //Field offset: 0xF8

	public PursuitSettingCustom() { }

	public virtual void Attatched() { }

	protected virtual Vector2 FinalTweakToPursuitDestination(Vector2 pursuitDestination, Bloon target) { }

	protected virtual Target GetPursuitTarget() { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

