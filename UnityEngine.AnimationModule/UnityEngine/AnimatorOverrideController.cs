namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
public class AnimatorOverrideController : RuntimeAnimatorController
{
	public sealed class OnOverrideControllerDirtyCallback : MulticastDelegate
	{

		public OnOverrideControllerDirtyCallback(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; //Field offset: 0x18

	[Obsolete("AnimatorOverrideController.clips property is deprecated. Use AnimatorOverrideController.GetOverrides and AnimatorOverrideController.ApplyOverrides instead.")]
	public AnimationClipPair[] clips
	{
		 get { } //Length: 459
		 set { } //Length: 220
	}

	public AnimationClip Item
	{
		 get { } //Length: 69
		 set { } //Length: 82
	}

	public AnimationClip Item
	{
		 get { } //Length: 69
		 set { } //Length: 85
	}

	public int overridesCount
	{
		[NativeMethod("GetOriginalClipsCount")]
		 get { } //Length: 51
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		[NativeMethod("GetAnimatorController")]
		 get { } //Length: 51
		[NativeMethod("SetAnimatorController")]
		 set { } //Length: 66
	}

	public AnimatorOverrideController() { }

	public AnimatorOverrideController(RuntimeAnimatorController controller) { }

	public void ApplyOverrides(IList<KeyValuePair`2<AnimationClip, AnimationClip>> overrides) { }

	public AnimationClipPair[] get_clips() { }

	public AnimationClip get_Item(string name) { }

	public AnimationClip get_Item(AnimationClip clip) { }

	[NativeMethod("GetOriginalClipsCount")]
	public int get_overridesCount() { }

	[NativeMethod("GetAnimatorController")]
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	private AnimationClip GetOriginalClip(int index) { }

	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	public void GetOverrides(List<KeyValuePair`2<AnimationClip, AnimationClip>> overrides) { }

	[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	[NativeMethod("GetClip")]
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[NativeMethod("SetClip")]
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void PerformOverrideClipListCleanup() { }

	private void SendNotification() { }

	public void set_clips(AnimationClipPair[] value) { }

	public void set_Item(AnimationClip clip, AnimationClip value) { }

	public void set_Item(string name, AnimationClip value) { }

	[NativeMethod("SetAnimatorController")]
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

}

