namespace Assets.Scripts.Models.Bloons.Behaviors.Actions;

[Implementation(typeof(GenerateArmourAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GenerateArmourActionModel : BloonBehaviorActionModel
{
	public const string SlowMutatorId = "Armour:WeightIncrease"; //Field offset: 0x0
	public string id; //Field offset: 0x38
	public String[] tags; //Field offset: 0x40
	public float amount; //Field offset: 0x48
	public BloonProperties properties; //Field offset: 0x4C
	[Range(0, 5)]
	public float speedMultiplier; //Field offset: 0x50
	public Mutator slowMutator; //Field offset: 0x58

	public GenerateArmourActionModel(string name, string actionId, string id, String[] tags, float amount, BloonProperties properties, float speedMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

