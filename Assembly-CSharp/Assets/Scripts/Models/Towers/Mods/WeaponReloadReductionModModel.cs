namespace Assets.Scripts.Models.Towers.Mods;

public class WeaponReloadReductionModModel : MutatorModModel
{
	public float reductionAmount; //Field offset: 0x30

	public WeaponReloadReductionModModel(string name, float reductionAmount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

