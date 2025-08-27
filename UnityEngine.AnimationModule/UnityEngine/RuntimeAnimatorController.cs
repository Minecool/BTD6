namespace UnityEngine;

[ExcludeFromObjectFactory]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[UsedByNativeCode]
public class RuntimeAnimatorController : object
{

	public AnimationClip[] animationClips
	{
		 get { } //Length: 51
	}

	protected RuntimeAnimatorController() { }

	public AnimationClip[] get_animationClips() { }

}

