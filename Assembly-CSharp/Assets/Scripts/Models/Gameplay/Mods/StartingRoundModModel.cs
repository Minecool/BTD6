namespace Assets.Scripts.Models.Gameplay.Mods;

public class StartingRoundModModel : MutatorModModel
{
	public int round; //Field offset: 0x30

	public StartingRoundModModel(string name, int round) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

