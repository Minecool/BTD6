namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[UsedByNativeCode]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	private static readonly PlayableOutputHandle m_Null; //Field offset: 0x0
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public static PlayableOutputHandle Null
	{
		 get { } //Length: 96
	}

	private static PlayableOutputHandle() { }

	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	public virtual bool Equals(object p) { }

	public override bool Equals(PlayableOutputHandle other) { }

	public static PlayableOutputHandle get_Null() { }

	public virtual int GetHashCode() { }

	[FreeFunction("PlayableOutputHandleBindings::GetPlayableOutputType", HasExplicitThis = True, ThrowsException = True)]
	internal Type GetPlayableOutputType() { }

	private static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self) { }

	[FreeFunction("PlayableOutputHandleBindings::GetSourceOutputPort", HasExplicitThis = True, ThrowsException = True)]
	internal int GetSourceOutputPort() { }

	private static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self) { }

	[VisibleToOtherModules]
	internal bool IsPlayableOutputOfType() { }

	[VisibleToOtherModules]
	internal bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableOutputHandle _unity_self) { }

	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	[FreeFunction("PlayableOutputHandleBindings::SetSourcePlayable", HasExplicitThis = True, ThrowsException = True)]
	internal void SetSourcePlayable(PlayableHandle target, int port) { }

	private static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port) { }

}

