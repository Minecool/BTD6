namespace Assets.Scripts.Unity.MapProps.Behaviors;

public class AnimationSpecialEffect : PropBehavior
{
	public int framesToWait; //Field offset: 0x90
	public string expFramesToWait; //Field offset: 0x98
	public bool isParticleEffect; //Field offset: 0xA0
	public string expIsParticleEffect; //Field offset: 0xA8

	public virtual PropBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public AnimationSpecialEffect() { }

	public virtual PropBehaviorModel get_Def() { }

}

