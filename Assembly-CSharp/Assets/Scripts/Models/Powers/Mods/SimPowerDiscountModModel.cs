namespace Assets.Scripts.Models.Powers.Mods;

public class SimPowerDiscountModModel : MutatorModModel
{
	public string power; //Field offset: 0x30
	public float multiplier; //Field offset: 0x38
	public float subtraction; //Field offset: 0x3C
	public int charges; //Field offset: 0x40

	public SimPowerDiscountModModel(string name, string power, float multiplier, float subtraction, int charges) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

