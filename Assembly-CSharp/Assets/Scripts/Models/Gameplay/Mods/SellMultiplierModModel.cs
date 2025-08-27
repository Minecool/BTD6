namespace Assets.Scripts.Models.Gameplay.Mods;

public class SellMultiplierModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30
	public float addition; //Field offset: 0x34

	public SellMultiplierModModel(string name, float multiplier, float addition) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

