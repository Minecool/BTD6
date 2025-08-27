namespace Assets.Scripts.Simulation.Corvus.Spells;

public class CorvusCooldownSpellTiming : CorvusSpellTiming<CorvusInstantSpell>
{
	private int totalFramesCooldown; //Field offset: 0x20
	private int framesCooldown; //Field offset: 0x24

	public float CooldownPercent
	{
		 get { } //Length: 65
	}

	public CorvusCooldownSpellTiming(CorvusInstantSpell spell, Action<CorvusInstantSpell> endSpellCooldownAction) { }

	public virtual void FromSaveString(string data) { }

	public float get_CooldownPercent() { }

	public virtual void ProcessFrame() { }

	public virtual string ToSaveString() { }

}

