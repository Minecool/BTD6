namespace Assets.Scripts.Models.Towers.Mods;

public class KnockbackModModel : MutatorModModel
{
	public float percentMultiplierAdded; //Field offset: 0x30

	public KnockbackModModel(string name, float percentMultiplierAdded) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

