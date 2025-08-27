namespace UnityEngine;

[NativeHeader("Modules/Animation/AnimationState.h")]
[UsedByNativeCode]
public sealed class AnimationState : TrackedReference
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(AnimationState animationState) { }

	}


	public AnimationClip clip
	{
		 get { } //Length: 132
	}

	public float length
	{
		 get { } //Length: 81
	}

	public AnimationState() { }

	public AnimationClip get_clip() { }

	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	public float get_length() { }

	private static float get_length_Injected(IntPtr _unity_self) { }

}

