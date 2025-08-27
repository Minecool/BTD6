namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ActivateTempTargetPrioSupportZone : ActivateTowerSupportZone
{
	public ActivateTempTargetPrioSupportZoneModel activateTempTargetPrioSupportZoneModel; //Field offset: 0x88
	private List<RootBehavior> createdBehaviors; //Field offset: 0x90

	public ActivateTempTargetPrioSupportZone() { }

	protected virtual bool CanEffectThisTower() { }

	public virtual bool CanUseAbility() { }

	protected virtual float GetLifespan() { }

	protected virtual float GetRange() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual bool IsUnique() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual float MaxNumTowersModified() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

