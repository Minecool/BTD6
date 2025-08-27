namespace Assets.Scripts.Unity.Display.Animation;

public class AnimationClipData
{
	public string name; //Field offset: 0x10
	public AnimatedPropertyData[] properties; //Field offset: 0x18
	public AnimationEventData[] events; //Field offset: 0x20

	public float length
	{
		 get { } //Length: 147
	}

	public AnimationClipData() { }

	public float get_length() { }

}

