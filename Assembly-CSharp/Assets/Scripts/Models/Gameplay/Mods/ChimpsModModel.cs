namespace Assets.Scripts.Models.Gameplay.Mods;

public class ChimpsModModel : MutatorModModel
{

	public ChimpsModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool IsGameModeMod() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

