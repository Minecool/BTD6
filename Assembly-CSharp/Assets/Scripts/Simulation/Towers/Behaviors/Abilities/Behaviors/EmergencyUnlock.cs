namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class EmergencyUnlock : AbilityBehavior
{
	public EmergencyUnlockModel emergencyUnlockModel; //Field offset: 0x68
	private EmergencyUnlockSimBehavior simBehavior; //Field offset: 0x70
	private bool wasAvailableLastFrame; //Field offset: 0x78

	public EmergencyUnlock() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	private void PlayActivateSound() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual bool ShowAbilityInBottomRow() { }

	public virtual bool ShowInAbilityMenu() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

