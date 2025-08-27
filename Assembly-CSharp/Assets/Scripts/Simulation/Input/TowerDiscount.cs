namespace Assets.Scripts.Simulation.Input;

public class TowerDiscount
{
	public string id; //Field offset: 0x10
	public String[] towers; //Field offset: 0x18
	public int charges; //Field offset: 0x20
	public float multiplier; //Field offset: 0x24
	public float subtraction; //Field offset: 0x28

	public TowerDiscount() { }

	public void TowerCostTransform(TowerModel tower, ref float outMultiplier, ref float outDirectValueChange, bool useCharge) { }

}

