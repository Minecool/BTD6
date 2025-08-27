namespace Assets.Scripts.Models.Towers.Mods;

public class BloonHealthModModel : MutatorModModel
{
	public float percentageHealthReduced; //Field offset: 0x30

	public BloonHealthModModel(string name, float percentageHealthReduced) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(BloonModel model, BloonModel unmodded, string target = "") { }

}

