namespace Assets.Scripts.Models.Towers.Mods;

public class WeaponReloadPercentageModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30

	public WeaponReloadPercentageModModel(string name, float multiplier) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

