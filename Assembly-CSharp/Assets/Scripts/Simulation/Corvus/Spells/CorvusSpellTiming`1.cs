namespace Assets.Scripts.Simulation.Corvus.Spells;

public abstract class CorvusSpellTiming
{
	protected const string partsSeparator = "#"; //Field offset: 0x0
	private readonly T spell; //Field offset: 0x0
	private readonly Action<T> triggerAction; //Field offset: 0x0

	public CorvusSpellTiming`1(T spell, Action<T> triggerAction) { }

	public abstract void FromSaveString(string data) { }

	public void PerformAction() { }

	public abstract void ProcessFrame() { }

	public abstract string ToSaveString() { }

}

