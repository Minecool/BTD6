namespace Assets.Scripts.Models.Powers.Mods;

public class SuperMonkeyStormModModel : MutatorModModel
{
	public float damageIncrease; //Field offset: 0x30

	public SuperMonkeyStormModModel(string name, float damageIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

