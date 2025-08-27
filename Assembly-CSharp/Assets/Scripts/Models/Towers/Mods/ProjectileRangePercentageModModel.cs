namespace Assets.Scripts.Models.Towers.Mods;

public class ProjectileRangePercentageModModel : MutatorModModel
{
	public float percentIncrease; //Field offset: 0x30

	public ProjectileRangePercentageModModel(string name, float percentIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

