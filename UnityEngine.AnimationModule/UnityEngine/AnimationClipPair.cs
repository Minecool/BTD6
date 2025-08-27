namespace UnityEngine;

[Obsolete("This class is not used anymore. See AnimatorOverrideController.GetOverrides() and AnimatorOverrideController.ApplyOverrides()")]
public class AnimationClipPair
{
	public AnimationClip originalClip; //Field offset: 0x10
	public AnimationClip overrideClip; //Field offset: 0x18

	public AnimationClipPair() { }

}

