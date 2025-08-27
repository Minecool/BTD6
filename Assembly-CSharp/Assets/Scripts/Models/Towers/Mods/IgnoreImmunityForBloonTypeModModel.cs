namespace Assets.Scripts.Models.Towers.Mods;

public class IgnoreImmunityForBloonTypeModModel : MutatorModModel
{
	public BloonProperties bloonProperties; //Field offset: 0x30

	public IgnoreImmunityForBloonTypeModModel(string name, BloonProperties bloonProperties) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

