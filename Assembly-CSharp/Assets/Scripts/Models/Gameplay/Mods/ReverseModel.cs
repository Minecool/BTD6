namespace Assets.Scripts.Models.Gameplay.Mods;

public class ReverseModel : MutatorModModel
{

	public ReverseModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

