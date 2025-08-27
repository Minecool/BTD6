namespace Assets.Scripts.Models.Gameplay.Mods;

public class RoundSetModModel : MutatorModModel
{
	public string roundsetName; //Field offset: 0x30

	public RoundSetModModel(string name, string roundsetName) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

