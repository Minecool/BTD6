namespace Assets.Scripts.Models.Powers.Mods;

public class DartTimeModModel : MutatorModModel
{
	public float durationIncrease; //Field offset: 0x30

	public DartTimeModModel(string name, float durationIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

