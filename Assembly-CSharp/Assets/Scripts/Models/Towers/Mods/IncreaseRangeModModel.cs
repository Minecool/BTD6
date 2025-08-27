namespace Assets.Scripts.Models.Towers.Mods;

public class IncreaseRangeModModel : MutatorModModel
{
	public int additionalFrames; //Field offset: 0x30

	public IncreaseRangeModModel(string name, int additionalFrames) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

