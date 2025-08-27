namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
[NativeType("Modules/Animation/AnimationClip.h")]
public sealed class AnimationClip : Motion
{

	public bool empty
	{
		[NativeMethod("IsEmpty")]
		 get { } //Length: 51
	}

	public AnimationEvent[] events
	{
		 get { } //Length: 130
		 set { } //Length: 66
	}

	[NativeProperty("SampleRate", False, TargetType::Function (0))]
	public float frameRate
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool hasGenericRootTransform
	{
		[NativeMethod("HasGenericRootTransform")]
		 get { } //Length: 51
	}

	public bool hasMotionCurves
	{
		[NativeMethod("HasMotionCurves")]
		 get { } //Length: 51
	}

	public bool hasMotionFloatCurves
	{
		[NativeMethod("HasMotionFloatCurves")]
		 get { } //Length: 51
	}

	public bool hasRootCurves
	{
		[NativeMethod("HasRootCurves")]
		 get { } //Length: 51
	}

	internal bool hasRootMotion
	{
		[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
		internal get { } //Length: 51
	}

	public bool humanMotion
	{
		[NativeMethod("IsHumanMotion")]
		 get { } //Length: 51
	}

	public bool legacy
	{
		[NativeMethod("IsLegacy")]
		 get { } //Length: 51
		[NativeMethod("SetLegacy")]
		 set { } //Length: 66
	}

	[NativeProperty("Length", False, TargetType::Function (0))]
	public float length
	{
		 get { } //Length: 51
	}

	[NativeProperty("Bounds", False, TargetType::Function (0))]
	public Bounds localBounds
	{
		 get { } //Length: 81
		 set { } //Length: 66
	}

	[NativeProperty("StartTime", False, TargetType::Function (0))]
	internal float startTime
	{
		internal get { } //Length: 51
	}

	[NativeProperty("StopTime", False, TargetType::Function (0))]
	internal float stopTime
	{
		internal get { } //Length: 51
	}

	[NativeProperty("WrapMode", False, TargetType::Function (0))]
	public WrapMode wrapMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public AnimationClip() { }

	public void AddEvent(AnimationEvent evt) { }

	[FreeFunction(Name = "AnimationClipBindings::AddEventInternal", HasExplicitThis = True)]
	private void AddEventInternal(object evt) { }

	public void ClearCurves() { }

	public void EnsureQuaternionContinuity() { }

	[NativeMethod("IsEmpty")]
	public bool get_empty() { }

	public AnimationEvent[] get_events() { }

	public float get_frameRate() { }

	[NativeMethod("HasGenericRootTransform")]
	public bool get_hasGenericRootTransform() { }

	[NativeMethod("HasMotionCurves")]
	public bool get_hasMotionCurves() { }

	[NativeMethod("HasMotionFloatCurves")]
	public bool get_hasMotionFloatCurves() { }

	[NativeMethod("HasRootCurves")]
	public bool get_hasRootCurves() { }

	[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = True)]
	internal bool get_hasRootMotion() { }

	[NativeMethod("IsHumanMotion")]
	public bool get_humanMotion() { }

	[NativeMethod("IsLegacy")]
	public bool get_legacy() { }

	public float get_length() { }

	public Bounds get_localBounds() { }

	private void get_localBounds_Injected(out Bounds ret) { }

	internal float get_startTime() { }

	internal float get_stopTime() { }

	public WrapMode get_wrapMode() { }

	[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = True)]
	private Array GetEventsInternal() { }

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	[FreeFunction]
	[NativeHeader("Modules/Animation/AnimationUtility.h")]
	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

	public void SampleAnimation(GameObject go, float time) { }

	public void set_events(AnimationEvent[] value) { }

	public void set_frameRate(float value) { }

	[NativeMethod("SetLegacy")]
	public void set_legacy(bool value) { }

	public void set_localBounds(Bounds value) { }

	private void set_localBounds_Injected(ref Bounds value) { }

	public void set_wrapMode(WrapMode value) { }

	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = True)]
	public void SetCurve(string relativePath, Type type, string propertyName, AnimationCurve curve) { }

	[FreeFunction(Name = "AnimationClipBindings::SetEventsInternal", HasExplicitThis = True, ThrowsException = True)]
	private void SetEventsInternal(Array value) { }

}

