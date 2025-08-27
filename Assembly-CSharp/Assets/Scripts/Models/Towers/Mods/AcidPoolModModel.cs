namespace Assets.Scripts.Models.Towers.Mods;

public class AcidPoolModModel : MutatorModModel
{
	public float additionalTime; //Field offset: 0x30

	public AcidPoolModModel(string name, float additionalTime) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

