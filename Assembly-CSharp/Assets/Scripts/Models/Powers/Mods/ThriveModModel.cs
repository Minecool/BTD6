namespace Assets.Scripts.Models.Powers.Mods;

public class ThriveModModel : MutatorModModel
{
	public float cashMultiplierIncrease; //Field offset: 0x30

	public ThriveModModel(string name, float cashMultiplierIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

