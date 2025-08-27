namespace Assets.Scripts.Models.Towers.Mods;

public class TowerExpireModModel : MutatorModModel
{
	public float aditionalTimeBonus; //Field offset: 0x30

	public TowerExpireModModel(string name, float aditionalTimeBonus) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

