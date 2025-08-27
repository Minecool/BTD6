namespace Assets.Scripts.Models.Towers.Mods;

public class CeramicShockModModel : MutatorModModel
{
	public SlowForBloonModel slowModelToUse; //Field offset: 0x30

	public CeramicShockModModel(string name, SlowForBloonModel slowModelToUse) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

