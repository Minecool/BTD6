namespace Assets.Scripts.Models.Bloons.Behaviors.Actions;

[Implementation(typeof(GenerateShieldAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GenerateShieldActionModel : BloonBehaviorActionModel
{
	public string id; //Field offset: 0x38
	public float amount; //Field offset: 0x40

	public GenerateShieldActionModel(string name, string actionId, string id, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

