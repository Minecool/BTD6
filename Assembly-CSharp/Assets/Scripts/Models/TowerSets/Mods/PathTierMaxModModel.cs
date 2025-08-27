namespace Assets.Scripts.Models.TowerSets.Mods;

public class PathTierMaxModModel : MutatorModModel
{
	public int path; //Field offset: 0x30
	public int tier; //Field offset: 0x34

	public PathTierMaxModModel(string name, int path, int tier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerDetailsModel model, TowerDetailsModel unmodded, GameModel gameModel, string target = "") { }

}

