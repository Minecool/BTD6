namespace Assets.Scripts.Models.Towers.Mods;

public class ActivateAttackModModel : MutatorModModel
{
	public float additionalTime; //Field offset: 0x30

	public ActivateAttackModModel(string name, float additionalTime) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

