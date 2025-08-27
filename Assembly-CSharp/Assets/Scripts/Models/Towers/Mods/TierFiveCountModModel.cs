namespace Assets.Scripts.Models.Towers.Mods;

public class TierFiveCountModModel : MutatorModModel
{
	public string towerBaseId; //Field offset: 0x30
	public int path; //Field offset: 0x38
	public int tier; //Field offset: 0x3C
	public int maxCountAdditive; //Field offset: 0x40

	public TierFiveCountModModel(string name, string towerBaseId, int path, int tier, int maxCountAdditive) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

