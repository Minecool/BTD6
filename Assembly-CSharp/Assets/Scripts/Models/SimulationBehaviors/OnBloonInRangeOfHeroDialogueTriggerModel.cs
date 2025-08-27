namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(OnBloonInRangeOfHeroDialogueTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnBloonInRangeOfHeroDialogueTriggerModel : SimulationBehaviorModel
{
	[TowerType]
	public string hero; //Field offset: 0x30
	[BloonType]
	public string bloonType; //Field offset: 0x38
	[SerializeReference]
	public DialogueDataModel dialogueModel; //Field offset: 0x40

	public OnBloonInRangeOfHeroDialogueTriggerModel(string hero, string bloonType, DialogueDataModel dialogueModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

