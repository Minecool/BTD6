namespace Assets.Scripts.Models.Towers.Mods;

public class ProjectileTrackTargetModModel : MutatorModModel
{
	public float multiplierTurnRate; //Field offset: 0x30

	public ProjectileTrackTargetModModel(string name, float multiplierTurnRate) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

