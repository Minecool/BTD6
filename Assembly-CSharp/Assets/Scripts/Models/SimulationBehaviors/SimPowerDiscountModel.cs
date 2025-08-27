namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(SimPowerDiscount), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SimPowerDiscountModel : SimulationBehaviorModel
{
	public String[] powers; //Field offset: 0x30
	public float multiplier; //Field offset: 0x38
	public float subtraction; //Field offset: 0x3C
	public int charges; //Field offset: 0x40

	public SimPowerDiscountModel(string name, String[] powers, float multiplier, float subtraction, int charges) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

