namespace Assets.Scripts.Models.Bloons.Mod;

public class MortarBurnyStuffAffectBlackModModel : MutatorModModel
{

	public MortarBurnyStuffAffectBlackModModel(string name) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

