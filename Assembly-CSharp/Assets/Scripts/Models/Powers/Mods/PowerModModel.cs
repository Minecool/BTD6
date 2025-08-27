namespace Assets.Scripts.Models.Powers.Mods;

public class PowerModModel : MutatorModModel
{
	public float costDecrease; //Field offset: 0x30

	public PowerModModel(string name, float costDecrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

