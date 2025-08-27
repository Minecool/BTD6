namespace Assets.Scripts.Simulation.Corvus.Spells;

public class CorvusContinuousSpellTiming : CorvusSpellTiming<CorvusContinuousSpell>
{
	private int framesBetweenManaDrains; //Field offset: 0x20
	private int numberOfFramesToNextManaDrain; //Field offset: 0x24

	public CorvusContinuousSpellTiming(CorvusContinuousSpell spell, Action<CorvusContinuousSpell> consumeManaAction) { }

	public virtual void FromSaveString(string data) { }

	public virtual void ProcessFrame() { }

	public virtual string ToSaveString() { }

}

