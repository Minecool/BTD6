namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableHandle : IEquatable<PlayableHandle>
{
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableHandle Null
	{
		 get { } //Length: 96
	}

	private static PlayableHandle() { }

	internal bool CheckInputBounds(int inputIndex, bool acceptAny) { }

	internal bool CheckInputBounds(int inputIndex) { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	internal void Destroy() { }

	public virtual bool Equals(object p) { }

	public override bool Equals(PlayableHandle other) { }

	public static PlayableHandle get_Null() { }

	[FreeFunction("PlayableHandleBindings::GetGraph", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal PlayableGraph GetGraph() { }

	private static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret) { }

	public virtual int GetHashCode() { }

	[FreeFunction("PlayableHandleBindings::GetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal int GetInputCount() { }

	private static int GetInputCount_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal Type GetPlayableType() { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::GetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal double GetTime() { }

	private static double GetTime_Injected(ref PlayableHandle _unity_self) { }

	[VisibleToOtherModules]
	internal bool IsPlayableOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	[FreeFunction("PlayableHandleBindings::Pause", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void Pause() { }

	private static void Pause_Injected(ref PlayableHandle _unity_self) { }

	[FreeFunction("PlayableHandleBindings::SetInputCount", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetInputCount(int value) { }

	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) { }

	internal bool SetInputWeight(int inputIndex, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetInputWeightFromIndex", HasExplicitThis = True, ThrowsException = True)]
	private void SetInputWeightFromIndex(int index, float weight) { }

	private static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight) { }

	[FreeFunction("PlayableHandleBindings::SetSpeed", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetSpeed(double value) { }

	private static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value) { }

	[FreeFunction("PlayableHandleBindings::SetTime", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	internal void SetTime(double value) { }

	private static void SetTime_Injected(ref PlayableHandle _unity_self, double value) { }

}

