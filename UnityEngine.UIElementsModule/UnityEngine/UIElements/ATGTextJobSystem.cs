namespace UnityEngine.UIElements;

internal class ATGTextJobSystem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ManagedJobData <.cctor>b__21_0() { }

		internal void <.cctor>b__21_1(ManagedJobData inst) { }

	}

	private struct GenerateTextJobData : IJobParallelFor
	{
		public GCHandle managedJobDataHandle; //Field offset: 0x0

		public override void Execute(int index) { }

	}

	private class ManagedJobData
	{
		public TextElement textElement; //Field offset: 0x10
		public MeshGenerationNode node; //Field offset: 0x18
		public NativeTextInfo textInfo; //Field offset: 0x20
		public bool success; //Field offset: 0x28

		public ManagedJobData() { }

		public void Release() { }

	}

	private static ObjectPool<ManagedJobData> s_JobDataPool; //Field offset: 0x0
	private static readonly ProfilerMarker k_GenerateTextMarker; //Field offset: 0x8
	private static readonly ProfilerMarker k_ATGTextJobMarker; //Field offset: 0x10
	private static readonly bool k_IsMultiThreaded; //Field offset: 0x18
	private GCHandle textJobDatasHandle; //Field offset: 0x10
	private List<ManagedJobData> textJobDatas; //Field offset: 0x18
	private bool hasPendingTextWork; //Field offset: 0x20
	internal MeshGenerationCallback m_GenerateTextJobifiedCallback; //Field offset: 0x28
	internal MeshGenerationCallback m_AddDrawEntriesCallback; //Field offset: 0x30
	private List<Texture2D> atlases; //Field offset: 0x38
	private List<Single> sdfScalesArray; //Field offset: 0x40
	private List<NativeSlice`1<Vertex>> verticesArray; //Field offset: 0x48
	private List<NativeSlice`1<UInt16>> indicesArray; //Field offset: 0x50
	private List<GlyphRenderMode> renderModes; //Field offset: 0x58

	private static ATGTextJobSystem() { }

	public ATGTextJobSystem() { }

	private void AddDrawEntries(MeshGenerationContext mgc, object _) { }

	private static void ConvertMeshInfoToUIRVertex(ATGMeshInfo[] meshInfos, TempMeshAllocator alloc, TextElement visualElement, ref List<Texture2D>& atlases, ref List<NativeSlice`1<Vertex>>& verticesArray, ref List<NativeSlice`1<UInt16>>& indicesArray, ref List<GlyphRenderMode>& renderModes, ref List<Single>& sdfScales) { }

	public void GenerateText(MeshGenerationContext mgc, TextElement textElement) { }

	private void GenerateTextJobified(MeshGenerationContext mgc, object _) { }

}

