namespace Assets.Scripts.Models.Powers.Mods;

public class BananaFarmerModModel : MutatorModModel
{
	public float rangeMultiplier; //Field offset: 0x30

	public BananaFarmerModModel(string name, float rangeMultiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

