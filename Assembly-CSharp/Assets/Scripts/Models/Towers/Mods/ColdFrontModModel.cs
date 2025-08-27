namespace Assets.Scripts.Models.Towers.Mods;

public class ColdFrontModModel : MutatorModModel
{
	[ExtendedDrawer]
	public FreezeModel freeze; //Field offset: 0x30

	public ColdFrontModModel(string name, FreezeModel freeze) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

