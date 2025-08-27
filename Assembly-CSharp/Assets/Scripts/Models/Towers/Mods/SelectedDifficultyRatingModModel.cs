namespace Assets.Scripts.Models.Towers.Mods;

public class SelectedDifficultyRatingModModel : MutatorModModel
{
	public float addition; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34

	public SelectedDifficultyRatingModModel(string name, float addition, float multiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

