namespace Assets.Scripts.Models.Towers.Mods;

public class TowerSellModModel : MutatorModModel
{
	public float mutltiplier; //Field offset: 0x30
	public float additional; //Field offset: 0x34
	public int charges; //Field offset: 0x38

	public TowerSellModModel(string name, float mutltiplier, float additional, int charges) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

