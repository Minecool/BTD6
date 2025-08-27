namespace Assets.Scripts.Models.Bloons.Mod;

public class BloonLosesPropertiesModModel : MutatorModModel
{
	public BloonProperties propertiesToRemove; //Field offset: 0x30

	public BloonLosesPropertiesModModel(string name, BloonProperties propertiesToRemove) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(BloonModel model, BloonModel unmodded, string target = "") { }

}

