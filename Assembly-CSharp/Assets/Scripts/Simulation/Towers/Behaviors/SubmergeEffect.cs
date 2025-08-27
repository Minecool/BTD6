namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SubmergeEffect : TowerBehavior
{
	public SubmergeEffectModel submergeEffectModel; //Field offset: 0x68
	public Entity effectEntity; //Field offset: 0x70

	public SubmergeEffect() { }

	private Entity CreateEffect() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	public void TowerSuspendedStateChanged() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

