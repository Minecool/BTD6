namespace Assets.Scripts.Models.Towers.Mods;

public class WeaponReloadPercentageOnTargetPrioModModel : MutatorModModel
{
	public float multiplier; //Field offset: 0x30
	public string targetType; //Field offset: 0x38

	public WeaponReloadPercentageOnTargetPrioModModel(string name, float multiplier, string targetType) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

