namespace Assets.Scripts.Models.Towers.Mods;

public class EatBloonModModel : MutatorModModel
{
	public float additionalTrapAmount; //Field offset: 0x30

	public EatBloonModModel(string name, float additionalTrapAmount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

