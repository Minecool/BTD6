namespace Assets.Scripts.Models.Towers.Mods;

public class CallToArmsModModel : MutatorModModel
{
	public float additionalTime; //Field offset: 0x30

	public CallToArmsModModel(string name, float additionalTime) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

