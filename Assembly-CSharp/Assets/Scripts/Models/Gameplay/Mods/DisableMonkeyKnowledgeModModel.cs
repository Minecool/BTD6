namespace Assets.Scripts.Models.Gameplay.Mods;

public class DisableMonkeyKnowledgeModModel : MutatorModModel
{

	public DisableMonkeyKnowledgeModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

