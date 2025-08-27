namespace Assets.Scripts.Simulation.Effects;

public class EffectLimiter : RootBehavior
{
	public int currentAmount; //Field offset: 0x58
	public int limit; //Field offset: 0x5C

	public EffectLimiter() { }

}

