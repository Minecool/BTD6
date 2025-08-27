namespace Assets.Scripts.Simulation.Input;

public class PowerDiscount
{
	public string id; //Field offset: 0x10
	public String[] powers; //Field offset: 0x18
	public int charges; //Field offset: 0x20
	public float multiplier; //Field offset: 0x24
	public float subtraction; //Field offset: 0x28

	public PowerDiscount() { }

	public void PowerCostTransform(PowerModel power, ref float outMultiplier, ref float outDirectValueChange, bool useCharge) { }

}

