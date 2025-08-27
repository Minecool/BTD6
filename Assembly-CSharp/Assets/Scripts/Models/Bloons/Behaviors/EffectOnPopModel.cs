namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(EffectOnPop), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EffectOnPopModel : BloonBehaviorModel
{
	public EffectModel effect; //Field offset: 0x30

	public EffectOnPopModel() { }

	public EffectOnPopModel(string name, EffectModel effect) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

