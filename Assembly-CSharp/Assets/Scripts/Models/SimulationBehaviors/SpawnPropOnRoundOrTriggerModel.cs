namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SpawnPropOnRoundOrTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnPropOnRoundOrTriggerModel : SimulationBehaviorModel
{
	public string triggerId; //Field offset: 0x30
	public String[] prePlacePropIndexs; //Field offset: 0x38
	public Int32[] rounds; //Field offset: 0x40
	public bool AllAbilities; //Field offset: 0x48

	public SpawnPropOnRoundOrTriggerModel(string triggerId, String[] prePlacePropIndexs, Int32[] rounds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

