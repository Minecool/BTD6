namespace Assets.Scripts.Models.ContestedTerritory;

public class CtIncreasedProjectilePierceModModel : MutatorModModel
{
	private readonly float extraPierce; //Field offset: 0x30

	public CtIncreasedProjectilePierceModModel(string name, float extraPierce) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

