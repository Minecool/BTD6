namespace Assets.Scripts.Models.Bloons.Mod;

public class RegrowRegenRateModModel : MutatorModModel
{
	public float regrowRegenRateMultiplier; //Field offset: 0x30

	public RegrowRegenRateModModel(string name, float regrowRegenRateMultiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(BloonModel model, BloonModel unmodded, string target = "") { }

}

