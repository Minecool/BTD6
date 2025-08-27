namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class OverclockPermanent : AbilityBehavior
{
	public OverclockPermanentModel overclockPermanentModel; //Field offset: 0x68

	public OverclockPermanent() { }

	public void ApplyToTower(Tower towerToApplyTo) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

