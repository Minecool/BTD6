namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal abstract class RenderGraphResourcePool : IRenderGraphResourcePool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<Type> <>9; //Field offset: 0x0
		public static Comparison<ResourceLogInfo<Type>> <>9__17_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <LogResources>b__17_0(ResourceLogInfo<Type> a, ResourceLogInfo<Type> b) { }

	}

	private struct ResourceLogInfo
	{
		public string name; //Field offset: 0x0
		public long size; //Field offset: 0x0

	}

	protected static int s_CurrentFrameIndex; //Field offset: 0x0
	private const int kStaleResourceLifetime = 10; //Field offset: 0x0
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"resource", "frameIndex"}])]
	protected Dictionary<Int32, SortedList`2<Int32, ValueTuple`2<Type, Int32>>> m_ResourcePool; //Field offset: 0x0
	protected List<Int32> m_RemoveList; //Field offset: 0x0
	private List<ValueTuple`2<Int32, Type>> m_FrameAllocatedResources; //Field offset: 0x0

	protected RenderGraphResourcePool`1() { }

	public virtual void CheckFrameAllocation(bool onException, int frameIndex) { }

	public virtual void Cleanup() { }

	protected abstract string GetResourceName(Type res) { }

	protected abstract long GetResourceSize(Type res) { }

	protected abstract string GetResourceTypeName() { }

	protected abstract int GetSortIndex(Type res) { }

	public virtual void LogResources(RenderGraphLogger logger) { }

	public void RegisterFrameAllocation(int hash, Type value) { }

	protected abstract void ReleaseInternalResource(Type res) { }

	public void ReleaseResource(int hash, Type resource, int currentFrameIndex) { }

	protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex) { }

	public bool TryGetResource(int hashCode, out Type resource) { }

	public void UnregisterFrameAllocation(int hash, Type value) { }

}

