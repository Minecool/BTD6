namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(FreezeImmunityRemoval), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FreezeImmunityRemovalModel : BloonBehaviorModel
{
	public string mutators; //Field offset: 0x30
	public String[] mutatorsList; //Field offset: 0x38
	public DamageModel damageModel; //Field offset: 0x40

	public FreezeImmunityRemovalModel() { }

	public FreezeImmunityRemovalModel(string name, DamageModel damageModel, string mutators) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

