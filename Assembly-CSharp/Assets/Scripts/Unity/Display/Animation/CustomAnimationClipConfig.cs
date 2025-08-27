namespace Assets.Scripts.Unity.Display.Animation;

public class CustomAnimationClipConfig
{
	public AnimationClip animationClip; //Field offset: 0x10
	public int priority; //Field offset: 0x18
	public bool looping; //Field offset: 0x1C
	public InterruptBehaviour interruptibleBehaviour; //Field offset: 0x20

	public CustomAnimationClipConfig() { }

}

