namespace Assets.Scripts.Models.Gameplay.Mods;

public class ImpoppableModel : MutatorModModel
{

	public ImpoppableModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool IsGameModeMod() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

