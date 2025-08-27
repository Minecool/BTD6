namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimationState.h")]
[UsedByNativeCode]
public sealed class AnimationState : TrackedReference
{

	public AnimationClip clip
	{
		 get { } //Length: 51
	}

	public float length
	{
		 get { } //Length: 51
	}

	public AnimationState() { }

	public AnimationClip get_clip() { }

	public float get_length() { }

}

