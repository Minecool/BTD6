namespace Assets.Scripts.Models.Gameplay.Mods;

public class GlobalCostModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30

	public GlobalCostModModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

