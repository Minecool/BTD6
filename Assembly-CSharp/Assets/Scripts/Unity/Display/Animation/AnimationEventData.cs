namespace Assets.Scripts.Unity.Display.Animation;

public class AnimationEventData
{
	public float time; //Field offset: 0x10
	public string functionName; //Field offset: 0x18

	public AnimationEventData(AnimationEvent e) { }

	public AnimationEvent getEvent(float timescale) { }

}

