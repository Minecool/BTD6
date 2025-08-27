namespace Assets.Scripts.Models.Towers.Mods;

public class RecurringRangsModModel : MutatorModModel
{
	public string id; //Field offset: 0x30
	public Vector3[] newPath; //Field offset: 0x38
	public Vector3[] newEasePath; //Field offset: 0x40
	public int path1TierMin; //Field offset: 0x48
	public int path1TierMax; //Field offset: 0x4C
	public int path2TierMin; //Field offset: 0x50
	public int path2TierMax; //Field offset: 0x54
	public int path3TierMin; //Field offset: 0x58
	public int path3TierMax; //Field offset: 0x5C

	public RecurringRangsModModel(string id, string name, Vector3[] newPath, Vector3[] newEasePath, int path1TierMin, int path1TierMax, int path2TierMin, int path2TierMax, int path3TierMin, int path3TierMax) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

