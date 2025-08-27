namespace Assets.Scripts.Unity.Map;

public class AnimatorRandomStartFrame : AnimatorBehaviors
{
	public float randomLowerLimit; //Field offset: 0x20
	public float randomUpperLimit; //Field offset: 0x24
	public bool alwaysChooseRandomFrame; //Field offset: 0x28

	public AnimatorRandomStartFrame() { }

	public virtual void run() { }

}

