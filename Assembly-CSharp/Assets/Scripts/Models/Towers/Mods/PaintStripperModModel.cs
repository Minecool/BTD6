namespace Assets.Scripts.Models.Towers.Mods;

public class PaintStripperModModel : MutatorModModel
{
	public string removeTagsFromExcludeList; //Field offset: 0x30

	public PaintStripperModModel(string name, string removeTagsFromExcludeList) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

