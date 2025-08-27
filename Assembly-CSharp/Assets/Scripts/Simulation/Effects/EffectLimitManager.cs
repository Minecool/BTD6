namespace Assets.Scripts.Simulation.Effects;

public class EffectLimitManager : RootBehavior
{
	private Dictionary<PrefabReference, EffectLimiter> effectLimitersById; //Field offset: 0x58

	public EffectLimitManager() { }

	public void AddEffect(PrefabReference displayId) { }

	public bool CanPlayEffect(PrefabReference displayId) { }

	private EffectLimiter GetOrAddLimiter(PrefabReference displayId) { }

	public void Reset() { }

	public void SetLimit(PrefabReference displayId, int limit) { }

}

