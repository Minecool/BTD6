namespace Assets.Scripts.Models.Gameplay.Mods;

public class DisableContinueModModel : MutatorModModel
{

	public DisableContinueModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

