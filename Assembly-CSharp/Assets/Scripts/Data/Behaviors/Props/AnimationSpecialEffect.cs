namespace Assets.Scripts.Data.Behaviors.Props;

[CreateAssetMenu(fileName = "AnimationSpecialEffect", menuName = "BTD6/Behaviors/Props/AnimationSpecialEffect")]
public class AnimationSpecialEffect : PropBehavior
{
	public int framesToWait; //Field offset: 0x30
	public bool isParticleEffect; //Field offset: 0x34

	public virtual PropBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public AnimationSpecialEffect() { }

	public virtual PropBehaviorModel get_Def() { }

}

