namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(HighlightAbilitiesOnTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HighlightAbilitiesOnTriggerModel : SimulationBehaviorModel
{
	public string triggerId; //Field offset: 0x30
	public String[] abilityIds; //Field offset: 0x38

	public HighlightAbilitiesOnTriggerModel(string triggerId, String[] abilityIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

