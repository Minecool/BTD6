namespace Assets.Scripts.Models.Powers.Mods;

public class MoabMineModModel : MutatorModModel
{
	public float damageIncrease; //Field offset: 0x30
	public float damageBossIncrease; //Field offset: 0x34

	public MoabMineModModel(string name, float damageIncrease, float damageBossIncrease) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

}

