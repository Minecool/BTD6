namespace UnityEngine;

[DefaultMember("Item")]
[HelpURL("AnimatorOverrideController")]
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
		 get { } //Length: 683
		 set { } //Length: 416
	}

	public AnimationClip Item
	{
		 get { } //Length: 13
		 set { } //Length: 8
	}

	public AnimationClip Item
	{
		 get { } //Length: 210
		 set { } //Length: 230
	}

	public int overridesCount
	{
		[NativeMethod("GetOriginalClipsCount")]
		 get { } //Length: 118
	}

	public RuntimeAnimatorController runtimeAnimatorController
	{
		[NativeMethod("GetAnimatorController")]
		 get { } //Length: 144
		[NativeMethod("SetAnimatorController")]
		 set { } //Length: 177
	}

	public AnimatorOverrideController() { }

	public AnimatorOverrideController(RuntimeAnimatorController controller) { }

	public void ApplyOverrides(IList<KeyValuePair`2<AnimationClip, AnimationClip>> overrides) { }

	public AnimationClipPair[] get_clips() { }

	public AnimationClip get_Item(string name) { }

	public AnimationClip get_Item(AnimationClip clip) { }

	[NativeMethod("GetOriginalClipsCount")]
	public int get_overridesCount() { }

	private static int get_overridesCount_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetAnimatorController")]
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	private static IntPtr get_runtimeAnimatorController_Injected(IntPtr _unity_self) { }

	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	private static IntPtr GetClip_Injected(IntPtr _unity_self, IntPtr originalClip, bool returnEffectiveClip) { }

	private AnimationClip GetOriginalClip(int index) { }

	private static IntPtr GetOriginalClip_Injected(IntPtr _unity_self, int index) { }

	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	private static IntPtr GetOverrideClip_Injected(IntPtr _unity_self, IntPtr originalClip) { }

	public void GetOverrides(List<KeyValuePair`2<AnimationClip, AnimationClip>> overrides) { }

	[FreeFunction("AnimationBindings::CreateAnimatorOverrideController")]
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	private static void Internal_Create_Injected(AnimatorOverrideController self, IntPtr controller) { }

	[NativeMethod("GetClip")]
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	private static IntPtr Internal_GetClipByName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, bool returnEffectiveClip) { }

	[NativeMethod("SetClip")]
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	private static void Internal_SetClipByName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, IntPtr clip) { }

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

	[NativeConditional("UNITY_EDITOR")]
	internal void PerformOverrideClipListCleanup() { }

	private static void PerformOverrideClipListCleanup_Injected(IntPtr _unity_self) { }

	private void SendNotification() { }

	private static void SendNotification_Injected(IntPtr _unity_self) { }

	public void set_clips(AnimationClipPair[] value) { }

	public void set_Item(AnimationClip clip, AnimationClip value) { }

	public void set_Item(string name, AnimationClip value) { }

	[NativeMethod("SetAnimatorController")]
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	private static void set_runtimeAnimatorController_Injected(IntPtr _unity_self, IntPtr value) { }

	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	private static void SetClip_Injected(IntPtr _unity_self, IntPtr originalClip, IntPtr overrideClip, bool notify) { }

}

