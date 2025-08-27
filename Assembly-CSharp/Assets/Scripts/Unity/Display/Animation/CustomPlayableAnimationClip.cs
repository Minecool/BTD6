namespace Assets.Scripts.Unity.Display.Animation;

public class CustomPlayableAnimationClip
{
	public float duration; //Field offset: 0x10
	public int priority; //Field offset: 0x14
	public bool looping; //Field offset: 0x18
	public InterruptBehaviour interruptibleBehaviour; //Field offset: 0x1C
	public AnimationClip animationClip; //Field offset: 0x20
	public AnimationClipPlayable playableClip; //Field offset: 0x28
	public int blendMixerPort; //Field offset: 0x38
	public Dictionary<Int32, Single> blends; //Field offset: 0x40
	public bool isUpgradeAnimation; //Field offset: 0x48

	public float Length
	{
		 get { } //Length: 29
	}

	public string Name
	{
		 get { } //Length: 29
	}

	public float NormalizedTime
	{
		 get { } //Length: 121
	}

	public CustomPlayableAnimationClip() { }

	public void AddBlend(int to, float time) { }

	public float get_Length() { }

	public string get_Name() { }

	public float get_NormalizedTime() { }

	public float GetBlendTimeTo(int to) { }

}

