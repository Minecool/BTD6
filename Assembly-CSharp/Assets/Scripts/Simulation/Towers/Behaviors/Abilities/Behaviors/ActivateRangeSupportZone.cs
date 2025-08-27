namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ActivateRangeSupportZone : ActivateTowerSupportZone
{
	public ActivateRangeSupportZoneModel activateRangeSupportZoneModel; //Field offset: 0x88
	private List<RootBehavior> createdBehaviors; //Field offset: 0x90

	public ActivateRangeSupportZone() { }

	protected virtual bool CanEffectThisTower() { }

	protected virtual float GetLifespan() { }

	protected virtual float GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual bool IsUnique() { }

	protected virtual float MaxNumTowersModified() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

