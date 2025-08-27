namespace Assets.Scripts.Models.GenericBehaviors;

public class AnimationChange
{
	public AnimationClipReference original; //Field offset: 0x10
	public AnimationClipReference swapToo; //Field offset: 0x18

	public AnimationChange(AnimationClipReference original, AnimationClipReference swapToo) { }

	public bool Compare(AnimationChange to) { }

}

