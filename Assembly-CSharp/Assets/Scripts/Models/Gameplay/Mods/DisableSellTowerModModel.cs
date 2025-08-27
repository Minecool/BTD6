namespace Assets.Scripts.Models.Gameplay.Mods;

public class DisableSellTowerModModel : MutatorModModel
{

	public DisableSellTowerModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

