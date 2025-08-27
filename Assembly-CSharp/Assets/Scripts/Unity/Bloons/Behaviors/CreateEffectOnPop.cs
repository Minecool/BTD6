namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class CreateEffectOnPop : BloonBehavior
{
	public Effect effect; //Field offset: 0x88
	public Effect expEffect; //Field offset: 0x90
	public bool ignoreSameFrameDegrade; //Field offset: 0x98
	public string expIgnoreSameFrameDegrade; //Field offset: 0xA0

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 241
	}

	public CreateEffectOnPop() { }

	public virtual BloonBehaviorModel get_Def() { }

}

