namespace Assets.Scripts.Models.ContestedTerritory;

public class CtRestoreLivesPerRoundModModel : MutatorModModel
{
	public float livesRestored; //Field offset: 0x30
	public float maxLivesAboveStartingLives; //Field offset: 0x34

	public CtRestoreLivesPerRoundModModel(string name, float livesRestored, float maxLivesAboveStartingLives) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

