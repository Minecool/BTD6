namespace Assets.Scripts.Models.Towers.Mods;

public class DamageTypeModModel : MutatorModModel
{
	public BloonProperties canHitbloonProperties; //Field offset: 0x30

	public DamageTypeModModel(string name, BloonProperties canHitbloonProperties) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

