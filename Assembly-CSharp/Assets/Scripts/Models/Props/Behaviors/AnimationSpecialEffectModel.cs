namespace Assets.Scripts.Models.Props.Behaviors;

[Implementation(typeof(AnimationSpecialEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AnimationSpecialEffectModel : PropBehaviorModel
{
	public int framesToWait; //Field offset: 0x30
	public bool isParticleEffect; //Field offset: 0x34

	public AnimationSpecialEffectModel(string name, int framesToWait, bool isParticleEffect) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

