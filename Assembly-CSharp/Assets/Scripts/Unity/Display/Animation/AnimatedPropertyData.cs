namespace Assets.Scripts.Unity.Display.Animation;

public class AnimatedPropertyData
{
	public AnimationCurve curve; //Field offset: 0x10
	public string path; //Field offset: 0x18
	public string propertyName; //Field offset: 0x20

	public float length
	{
		 get { } //Length: 37
	}

	public AnimatedPropertyData() { }

	public float get_length() { }

}

