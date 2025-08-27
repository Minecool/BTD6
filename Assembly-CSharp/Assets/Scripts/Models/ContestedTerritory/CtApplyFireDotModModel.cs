namespace Assets.Scripts.Models.ContestedTerritory;

public class CtApplyFireDotModModel : MutatorModModel
{
	private readonly BloonProperties sharpProperty; //Field offset: 0x30
	private readonly BloonProperties fireProperty; //Field offset: 0x34
	private int damagePerTick; //Field offset: 0x38
	private float timeBetweenTicks; //Field offset: 0x3C
	private float totalDuration; //Field offset: 0x40

	public CtApplyFireDotModModel(string name, int damagePerTick, float timeBetweenTicks, float totalDuration) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

