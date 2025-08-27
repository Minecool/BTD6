namespace Assets.Scripts.Unity.Display;

[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
[Il2CppSetOption(Option::NullChecks (1), False)]
public class Factory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Factory <>4__this; //Field offset: 0x10
		public PrefabReference objectId; //Field offset: 0x18
		public Action<UnityDisplayNode> onComplete; //Field offset: 0x20

		public <>c__DisplayClass21_0() { }

		internal void <CreateAsync>b__0(UnityDisplayNode prototype) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public DisplayCategory displayCatergory; //Field offset: 0x10
		public Factory <>4__this; //Field offset: 0x18
		public PrefabReference objectId; //Field offset: 0x20
		public Action<UnityDisplayNode> onComplete; //Field offset: 0x28

		public <>c__DisplayClass22_0() { }

		internal void <FindAndSetupPrototypeAsync>b__0(AsyncOperationHandle<GameObject> h) { }

		internal void <FindAndSetupPrototypeAsync>b__1(AsyncOperationHandle<GameObject> h) { }

	}

	private struct PooledNode
	{
		public UnityDisplayNode node; //Field offset: 0x0
		public int entryTime; //Field offset: 0x8

	}

	private const bool kDecayEnabled = True; //Field offset: 0x0
	private const int kDecayInterval = 60; //Field offset: 0x0
	private const int kDecayAtAge = 600; //Field offset: 0x0
	private static Vector3 kOffscreenPosition; //Field offset: 0x0
	private static int asyncLoadIdGen; //Field offset: 0xC
	private readonly List<UnityDisplayNode> active; //Field offset: 0x10
	private readonly Dictionary<PrefabReference, List`1<PooledNode>> pool; //Field offset: 0x18
	private readonly Dictionary<PrefabReference, Int32> limits; //Field offset: 0x20
	private readonly Dictionary<PrefabReference, Int32> counts; //Field offset: 0x28
	private readonly Dictionary<PrefabReference, AsyncOperationHandle`1<GameObject>> prototypeHandles; //Field offset: 0x30
	private int timeAtLastDecay; //Field offset: 0x38

	private Transform DisplayRoot
	{
		private get { } //Length: 81
	}

	private Transform PrototypeRoot
	{
		private get { } //Length: 81
	}

	private static Factory() { }

	public Factory() { }

	public void CreateAsync(PrefabReference objectId, DisplayCategory displayCatergory, Action<UnityDisplayNode> onComplete) { }

	private void DecayPools(int elapsedTime) { }

	public void DestroyAllActive() { }

	private void FindAndSetupPrototypeAsync(PrefabReference objectId, DisplayCategory displayCatergory, Action<UnityDisplayNode> onComplete) { }

	public void Flush() { }

	private Transform get_DisplayRoot() { }

	private Transform get_PrototypeRoot() { }

	public bool IsLoadingAnyPrototypes() { }

	private void ProtoFlush() { }

	public void Tidy(int elapsedTime) { }

	private void UnusedFlush() { }

}

