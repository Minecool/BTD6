namespace Assets.Scripts.Models.Powers.Mods;

public class RoadSpikesPierceModModel : MutatorModModel
{
	public float addition; //Field offset: 0x30

	public RoadSpikesPierceModModel(string name, float addition) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

