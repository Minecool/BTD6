namespace Assets.Scripts.Models.Towers.Mods;

public class SetHeroLevelOnPlaceModModel : MutatorModModel
{
	public int level; //Field offset: 0x30

	public SetHeroLevelOnPlaceModModel(string name, int level) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

