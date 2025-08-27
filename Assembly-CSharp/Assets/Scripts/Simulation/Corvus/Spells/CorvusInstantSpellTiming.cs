namespace Assets.Scripts.Simulation.Corvus.Spells;

public class CorvusInstantSpellTiming : CorvusSpellTiming<CorvusInstantSpell>
{
	private int totalFramesActive; //Field offset: 0x20
	private int framesActive; //Field offset: 0x24

	public float ActivePercent
	{
		 get { } //Length: 65
	}

	public int FramesRemainingActive
	{
		 get { } //Length: 7
	}

	public CorvusInstantSpellTiming(CorvusInstantSpell spell, Action<CorvusInstantSpell> expireSpellAction) { }

	public CorvusInstantSpellTiming(CorvusInstantSpell spell, Action<CorvusInstantSpell> expireSpellAction, int totalFramesActive) { }

	public virtual void FromSaveString(string data) { }

	public float get_ActivePercent() { }

	public int get_FramesRemainingActive() { }

	public virtual void ProcessFrame() { }

	public virtual string ToSaveString() { }

}

