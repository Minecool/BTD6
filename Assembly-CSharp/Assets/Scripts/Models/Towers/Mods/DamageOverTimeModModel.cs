namespace Assets.Scripts.Models.Towers.Mods;

public class DamageOverTimeModModel : MutatorModModel
{
	public float timeReductionAmount; //Field offset: 0x30
	public int damageIncreaseAmount; //Field offset: 0x34

	public DamageOverTimeModModel(string name, float timeReductionAmount, int damageIncreaseAmount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

