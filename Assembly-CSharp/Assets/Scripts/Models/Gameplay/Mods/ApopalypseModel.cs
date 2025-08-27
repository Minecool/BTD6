namespace Assets.Scripts.Models.Gameplay.Mods;

public class ApopalypseModel : MutatorModModel
{

	public ApopalypseModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

