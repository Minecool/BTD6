namespace Assets.Scripts.Models.ContestedTerritory;

public class CtAddLayersAndDurationToFreezeModModel : MutatorModModel
{
	private readonly int extraLayers; //Field offset: 0x30
	private readonly float extraDuration; //Field offset: 0x34

	public CtAddLayersAndDurationToFreezeModModel(string name, int extraLayers, float extraDuration) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

