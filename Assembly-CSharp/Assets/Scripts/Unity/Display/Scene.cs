namespace Assets.Scripts.Unity.Display;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class Scene
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public float categoryScale; //Field offset: 0x10
		public Scene <>4__this; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_1
	{
		public ThrowawayEffect effect; //Field offset: 0x10
		public Vector3 position; //Field offset: 0x30
		public <>c__DisplayClass34_0 CS$<>8__locals1; //Field offset: 0x40

		public <>c__DisplayClass34_1() { }

		internal void <PresentThrowawayEffects>b__0(UnityDisplayNode graphic) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public IDisplayNode node; //Field offset: 0x10
		public PrefabReference objId; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal void <create_load_complete_delegate>b__0(UnityDisplayNode graphic) { }

	}

	private struct Vertex
	{
		public Vector3 pos; //Field offset: 0x0
		public Vector2 uv; //Field offset: 0xC

	}

	private const int minimumVerts = 650; //Field offset: 0x0
	private const int coopMinimumVerts = 128; //Field offset: 0x0
	public Factory factory; //Field offset: 0x10
	public EffectAreaLimiter limiter; //Field offset: 0x18
	private GameObject coopAreaRangeObject; //Field offset: 0x20
	private readonly GameObject projectors; //Field offset: 0x28
	private readonly VertexAttributeDescriptor[] meshLayout; //Field offset: 0x30
	private readonly Mesh rangeMesh; //Field offset: 0x38
	private readonly Mesh coopAreaRangeMesh; //Field offset: 0x40
	private readonly Mesh coopAreaRangeMeshYours; //Field offset: 0x48
	public LineRenderer[] coopAreaLineRenderers; //Field offset: 0x50
	private AccessibilitySettings accessibilitySettings; //Field offset: 0x58
	private bool active; //Field offset: 0x60
	private NativeArray<Vertex> rangeMeshVerts; //Field offset: 0x68
	private NativeArray<UInt16> rangeMeshIndices; //Field offset: 0x78
	public readonly List<Mesh> uiMeshes; //Field offset: 0x88
	private NativeArray<Vertex> coopVerticies; //Field offset: 0x90
	private NativeArray<UInt16> coopIndices; //Field offset: 0xA0
	public readonly List<Mesh> coopUiMeshes; //Field offset: 0xB0
	private NativeArray<Vertex> coopYourVerticies; //Field offset: 0xB8
	private NativeArray<UInt16> coopYourIndices; //Field offset: 0xC8
	public readonly List<Mesh> coopUiMeshesYours; //Field offset: 0xD8
	private TextureReference activeRangeTexture; //Field offset: 0xE0
	private TextureReference activeRangeOutline; //Field offset: 0xE8
	private AsyncOperationHandle<Texture> textureHandle; //Field offset: 0xF0
	private AsyncOperationHandle<Texture> outlineHandle; //Field offset: 0x108

	public Scene() { }

	[CompilerGenerated]
	private void <UpdateRangeCircle>b__43_0(AsyncOperationHandle<Texture> h) { }

	[CompilerGenerated]
	private void <UpdateRangeCircle>b__43_1(AsyncOperationHandle<Texture> h) { }

	public void CancelFadeInCoopArea() { }

	private static Action<UnityDisplayNode> create_load_complete_delegate(IDisplayNode node, PrefabReference objId) { }

	public void Dispose() { }

	private void ExecuteAudioTasks(List<AudioTask> audioTasks) { }

	public void FadeInCoopArea() { }

	public void Init(AccessibilitySettings accessibilitySettings) { }

	private static void PresentMesh(Mesh mesh, ref int vertIndex, ref int triIndex, NativeArray<Vertex> verts, NativeArray<UInt16> indices) { }

	private static void PresentMeshs(Mesh finalMesh, List<Mesh> simMeshes, ref NativeArray<Vertex>& verts, ref NativeArray<UInt16>& indices, VertexAttributeDescriptor[] layout) { }

	private void PresentModels(LockList<DisplayBehavior> behaviors) { }

	private void PresentText(LockList<TextDisplayBehavior> behaviors) { }

	private void PresentThrowawayEffects(List<ThrowawayEffect> effects) { }

	public void Quit() { }

	private static NativeArray<T> ResizeNativeArray(NativeArray<T> oldArray, int size) { }

	public void SetShaderColor(Color color) { }

	public void Update() { }

	private void UpdateRangeCircle() { }

}

