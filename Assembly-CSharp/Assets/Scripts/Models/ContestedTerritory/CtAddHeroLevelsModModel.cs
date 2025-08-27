namespace Assets.Scripts.Models.ContestedTerritory;

public class CtAddHeroLevelsModModel : MutatorModModel
{
	private readonly int extraLevels; //Field offset: 0x30
	private readonly int levelsWithEmpoweredHeroes; //Field offset: 0x34

	public CtAddHeroLevelsModModel(string name, int extraLevels, int levelsWithEmpoweredHeroes) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

