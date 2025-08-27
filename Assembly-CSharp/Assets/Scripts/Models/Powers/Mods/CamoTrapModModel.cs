namespace Assets.Scripts.Models.Powers.Mods;

public class CamoTrapModModel : MutatorModModel
{
	public float pierceIncrease; //Field offset: 0x30

	public CamoTrapModModel(string name, float pierceIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

