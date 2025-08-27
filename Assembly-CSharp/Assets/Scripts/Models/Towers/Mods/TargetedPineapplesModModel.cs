namespace Assets.Scripts.Models.Towers.Mods;

public class TargetedPineapplesModModel : MutatorModModel
{
	public CheckAirUnitOverTrackModel checkAirUnitOverTrackScript; //Field offset: 0x30

	public TargetedPineapplesModModel(string name, CheckAirUnitOverTrackModel checkAirUnitOverTrackScript) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

