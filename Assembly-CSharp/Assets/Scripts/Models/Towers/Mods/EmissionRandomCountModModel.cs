namespace Assets.Scripts.Models.Towers.Mods;

public class EmissionRandomCountModModel : MutatorModModel
{
	public int additionalCount; //Field offset: 0x30

	public EmissionRandomCountModModel(string name, int additionalCount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

