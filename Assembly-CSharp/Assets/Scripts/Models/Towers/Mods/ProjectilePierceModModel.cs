namespace Assets.Scripts.Models.Towers.Mods;

public class ProjectilePierceModModel : MutatorModModel
{
	public float amount; //Field offset: 0x30
	public int minTier; //Field offset: 0x34

	public ProjectilePierceModModel(string name, float amount, int minTier = 0) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

