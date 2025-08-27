namespace Assets.Scripts.Models.Towers.Mods;

public class AlternateArcModModel : MutatorModModel
{
	public int increase; //Field offset: 0x30
	public int shotCount; //Field offset: 0x34

	public AlternateArcModModel(string name, int increase, int shotCount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

