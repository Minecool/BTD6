namespace UnityEngine.Playables;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[UsedByNativeCode]
public struct PlayableGraph
{
	internal IntPtr m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x8

	public bool Connect(U source, int sourceOutputPort, V destination, int destinationInputPort) { }

	[FreeFunction("PlayableGraphBindings::ConnectInternal", HasExplicitThis = True, ThrowsException = True)]
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, in PlayableHandle source, int sourceOutputPort, in PlayableHandle destination, int destinationInputPort) { }

	public static PlayableGraph Create() { }

	public static PlayableGraph Create(string name) { }

	private static void Create_Injected(ref ManagedSpanWrapper name, out PlayableGraph ret) { }

	[FreeFunction("PlayableGraphBindings::Destroy", HasExplicitThis = True, ThrowsException = True)]
	public void Destroy() { }

	public void DestroyPlayable(U playable) { }

	[FreeFunction("PlayableGraphBindings::DestroyPlayableInternal", HasExplicitThis = True, ThrowsException = True)]
	private void DestroyPlayableInternal(PlayableHandle playable) { }

	private static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, in PlayableHandle playable) { }

	public bool IsValid() { }

	[FreeFunction("PlayableGraphBindings::Play", HasExplicitThis = True, ThrowsException = True)]
	public void Play() { }

	[FreeFunction("PlayableGraphBindings::SetTimeUpdateMode", HasExplicitThis = True, ThrowsException = True)]
	public void SetTimeUpdateMode(DirectorUpdateMode value) { }

}

