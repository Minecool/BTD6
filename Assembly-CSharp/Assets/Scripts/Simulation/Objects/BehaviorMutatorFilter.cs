namespace Assets.Scripts.Simulation.Objects;

public struct BehaviorMutatorFilter
{
	public float effectScale; //Field offset: 0x0
	public bool modifyEffectScale; //Field offset: 0x4
	public float durationScale; //Field offset: 0x8
	public bool modifyDurationScale; //Field offset: 0xC
	public bool preventMutation; //Field offset: 0xD

	public BehaviorMutatorFilter(float effectScale, bool modifyEffectScale, float durationScale, bool modifyDurationScale, bool preventMutation) { }

}

