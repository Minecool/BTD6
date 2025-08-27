namespace Assets.Scripts.Models.ContestedTerritory;

public class CtRemoveBloonTypeFromTowerFilter : MutatorModModel
{
	private readonly BloonProperties bloonType; //Field offset: 0x30

	public CtRemoveBloonTypeFromTowerFilter(string name, BloonProperties bloonType) { }

	[CompilerGenerated]
	private bool <Mutate>b__2_0(string x) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

