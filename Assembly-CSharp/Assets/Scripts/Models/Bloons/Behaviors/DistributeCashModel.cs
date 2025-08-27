namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DistributeCash), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DistributeCashModel : BloonBehaviorModel
{
	public float cash; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public float additive; //Field offset: 0x38
	public float additionalCash; //Field offset: 0x3C
	public bool giveNoCash; //Field offset: 0x40

	public DistributeCashModel() { }

	public DistributeCashModel(string name, float cash, float additionalCash = 0, float multiplier = 1, float additive = 0, bool giveNoCash = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

