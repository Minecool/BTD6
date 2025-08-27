namespace Assets.Scripts.Models.Towers.Mods;

public class ProjectileRadiusModModel : MutatorModModel
{
	public float additiveAmount; //Field offset: 0x30
	public float multiplierAmount; //Field offset: 0x34

	public ProjectileRadiusModModel(string name, float additiveAmount, float multiplierAmount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

