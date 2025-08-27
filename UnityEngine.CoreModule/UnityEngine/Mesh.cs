namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : object
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr; //Field offset: 0x0

	}

	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[StaticAccessor("MeshDataArrayBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshDataArray : IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr* m_Ptrs; //Field offset: 0x0
		internal int m_Length; //Field offset: 0x8

		public int Length
		{
			 get { } //Length: 4
		}

		internal MeshDataArray(Mesh mesh, bool checkReadWrite = true) { }

		internal MeshDataArray(Mesh[] meshes, int meshesCount, bool checkReadWrite = true) { }

		internal MeshDataArray(int meshesCount) { }

		private static void AcquireReadOnlyMeshData(Mesh mesh, IntPtr* datas) { }

		private static void AcquireReadOnlyMeshDatas(Mesh[] meshes, IntPtr* datas, int count) { }

		internal void ApplyToMeshAndDispose(Mesh mesh, MeshUpdateFlags flags) { }

		internal void ApplyToMeshesAndDispose(Mesh[] meshes, MeshUpdateFlags flags) { }

		[NativeThrows]
		private static void ApplyToMeshesImpl(Mesh[] meshes, IntPtr* datas, int count, MeshUpdateFlags flags) { }

		[NativeThrows]
		private static void ApplyToMeshImpl(Mesh mesh, IntPtr data, MeshUpdateFlags flags) { }

		private static void CreateNewMeshDatas(IntPtr* datas, int count) { }

		public override void Dispose() { }

		public int get_Length() { }

		private static void ReleaseMeshDatas(IntPtr* datas, int count) { }

	}


	public int bindposeCount
	{
		 get { } //Length: 51
	}

	[NativeName("BindPosesFromScript")]
	public Matrix4x4[] bindposes
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int blendShapeCount
	{
		[NativeMethod(Name = "GetBlendShapeChannelCount")]
		 get { } //Length: 51
	}

	public BoneWeight[] boneWeights
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Bounds bounds
	{
		 get { } //Length: 81
		 set { } //Length: 66
	}

	internal bool canAccess
	{
		[NativeMethod("CanAccessFromScript")]
		internal get { } //Length: 51
	}

	public Color[] colors
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Color32[] colors32
	{
		 get { } //Length: 80
		 set { } //Length: 105
	}

	public Target indexBufferTarget
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public IndexFormat indexFormat
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool isReadable
	{
		[NativeMethod("GetIsReadable")]
		 get { } //Length: 51
	}

	public Vector3[] normals
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public SkinWeights skinWeightBufferLayout
	{
		 get { } //Length: 51
	}

	public int subMeshCount
	{
		[NativeMethod(Name = "GetSubMeshCount")]
		 get { } //Length: 51
		[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
		 set { } //Length: 64
	}

	public Vector4[] tangents
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Int32[] triangles
	{
		 get { } //Length: 156
		 set { } //Length: 234
	}

	public Vector2[] uv
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Vector2[] uv2
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Vector2[] uv3
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Vector2[] uv4
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Vector2[] uv5
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Vector2[] uv6
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Vector2[] uv7
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public Vector2[] uv8
	{
		 get { } //Length: 62
		 set { } //Length: 86
	}

	public int vertexAttributeCount
	{
		 get { } //Length: 51
	}

	public int vertexBufferCount
	{
		[FreeFunction(Name = "MeshScripting::GetVertexBufferCount", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public Target vertexBufferTarget
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int vertexCount
	{
		[NativeMethod("GetVertexCount")]
		 get { } //Length: 51
	}

	public Vector3[] vertices
	{
		 get { } //Length: 59
		 set { } //Length: 83
	}

	[RequiredByNativeCode]
	public Mesh() { }

	public static MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes) { }

	public static MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes) { }

	public static MeshDataArray AcquireReadOnlyMeshData(Mesh mesh) { }

	[FreeFunction(Name = "AddBlendShapeFrameFromScript", HasExplicitThis = True, ThrowsException = True)]
	public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	public static MeshDataArray AllocateWritableMeshData(int meshCount) { }

	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh mesh, MeshUpdateFlags flags = 0) { }

	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh[] meshes, MeshUpdateFlags flags = 0) { }

	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, List<Mesh> meshes, MeshUpdateFlags flags = 0) { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	public void Clear(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	public void Clear() { }

	[FreeFunction(Name = "MeshScripting::ClearBlendShapes", HasExplicitThis = True)]
	public void ClearBlendShapes() { }

	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	[FreeFunction("MeshScripting::MeshFromInstanceId")]
	internal static Mesh FromInstanceID(int id) { }

	public int get_bindposeCount() { }

	public Matrix4x4[] get_bindposes() { }

	[NativeMethod(Name = "GetBlendShapeChannelCount")]
	public int get_blendShapeCount() { }

	public BoneWeight[] get_boneWeights() { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	[NativeMethod("CanAccessFromScript")]
	internal bool get_canAccess() { }

	public Color[] get_colors() { }

	public Color32[] get_colors32() { }

	public Target get_indexBufferTarget() { }

	public IndexFormat get_indexFormat() { }

	[NativeMethod("GetIsReadable")]
	public bool get_isReadable() { }

	public Vector3[] get_normals() { }

	public SkinWeights get_skinWeightBufferLayout() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	public int get_subMeshCount() { }

	public Vector4[] get_tangents() { }

	public Int32[] get_triangles() { }

	public Vector2[] get_uv() { }

	public Vector2[] get_uv2() { }

	public Vector2[] get_uv3() { }

	public Vector2[] get_uv4() { }

	public Vector2[] get_uv5() { }

	public Vector2[] get_uv6() { }

	public Vector2[] get_uv7() { }

	public Vector2[] get_uv8() { }

	public int get_vertexAttributeCount() { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferCount", HasExplicitThis = True)]
	public int get_vertexBufferCount() { }

	public Target get_vertexBufferTarget() { }

	[NativeMethod("GetVertexCount")]
	public int get_vertexCount() { }

	public Vector3[] get_vertices() { }

	public NativeArray<BoneWeight1> GetAllBoneWeights() { }

	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArray", HasExplicitThis = True)]
	private IntPtr GetAllBoneWeightsArray() { }

	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArraySize", HasExplicitThis = True)]
	private int GetAllBoneWeightsArraySize() { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	public uint GetBaseVertex(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetBaseVertex", HasExplicitThis = True)]
	private uint GetBaseVertexImpl(int submesh) { }

	public void GetBindposes(List<Matrix4x4> bindposes) { }

	public NativeArray<Matrix4x4> GetBindposes() { }

	[FreeFunction(Name = "MeshScripting::GetBindposesArray", HasExplicitThis = True)]
	private IntPtr GetBindposesArray() { }

	[FreeFunction(Name = "MeshScripting::ExtractBindPosesIntoArray", HasExplicitThis = True)]
	private void GetBindposesNonAllocImpl(out Matrix4x4[] values) { }

	public GraphicsBuffer GetBlendShapeBuffer() { }

	public GraphicsBuffer GetBlendShapeBuffer(BlendShapeBufferLayout layout) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetBlendShapeBufferImpl(int layout) { }

	public BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameCount", HasExplicitThis = True, ThrowsException = True)]
	public int GetBlendShapeFrameCount(int shapeIndex) { }

	[FreeFunction(Name = "GetBlendShapeFrameVerticesFromScript", HasExplicitThis = True, ThrowsException = True)]
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameWeight", HasExplicitThis = True, ThrowsException = True)]
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeIndex", HasExplicitThis = True, ThrowsException = True)]
	public int GetBlendShapeIndex(string blendShapeName) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeName", HasExplicitThis = True, ThrowsException = True)]
	public string GetBlendShapeName(int shapeIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeOffset", HasExplicitThis = True)]
	private BlendShape GetBlendShapeOffsetInternal(int index) { }

	private void GetBlendShapeOffsetInternal_Injected(int index, out BlendShape ret) { }

	public NativeArray<Byte> GetBonesPerVertex() { }

	[FreeFunction(Name = "MeshScripting::GetBonesPerVertexArray", HasExplicitThis = True)]
	private IntPtr GetBonesPerVertexArray() { }

	public GraphicsBuffer GetBoneWeightBuffer(SkinWeights layout) { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeightBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex) { }

	[NativeMethod("GetBoneWeightBufferDimension")]
	private int GetBoneWeightBufferLayoutInternal() { }

	public void GetBoneWeights(List<BoneWeight> boneWeights) { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = True)]
	private BoneWeight[] GetBoneWeightsImpl() { }

	[FreeFunction(Name = "MeshScripting::ExtractBoneWeightsIntoArray", HasExplicitThis = True)]
	private void GetBoneWeightsNonAllocImpl(out BoneWeight[] values) { }

	public void GetColors(List<Color32> colors) { }

	public void GetColors(List<Color> colors) { }

	public GraphicsBuffer GetIndexBuffer() { }

	[FreeFunction(Name = "MeshScripting::GetIndexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetIndexBufferImpl() { }

	public uint GetIndexCount(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	private uint GetIndexCountImpl(int submesh) { }

	public uint GetIndexStart(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexStart", HasExplicitThis = True)]
	private uint GetIndexStartImpl(int submesh) { }

	[ExcludeFromDocs]
	public void GetIndices(List<Int32> indices, int submesh) { }

	public void GetIndices(List<Int32> indices, int submesh, bool applyBaseVertex) { }

	public void GetIndices(List<UInt16> indices, int submesh, bool applyBaseVertex = true) { }

	[ExcludeFromDocs]
	public Int32[] GetIndices(int submesh) { }

	public Int32[] GetIndices(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	private Int32[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray", HasExplicitThis = True)]
	private void GetIndicesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray16", HasExplicitThis = True)]
	private void GetIndicesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	[FreeFunction(Name = "MeshScripting::GetNativeIndexBufferPtr", HasExplicitThis = True)]
	public IntPtr GetNativeIndexBufferPtr() { }

	[FreeFunction(Name = "MeshScripting::GetNativeVertexBufferPtr", HasExplicitThis = True)]
	[NativeThrows]
	public IntPtr GetNativeVertexBufferPtr(int index) { }

	public void GetNormals(List<Vector3> normals) { }

	[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	public SubMeshDescriptor GetSubMesh(int index) { }

	private void GetSubMesh_Injected(int index, out SubMeshDescriptor ret) { }

	public void GetTangents(List<Vector4> tangents) { }

	public MeshTopology GetTopology(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	private MeshTopology GetTopologyImpl(int submesh) { }

	internal uint GetTotalIndexCount() { }

	public void GetTriangles(List<Int32> triangles, int submesh) { }

	public Int32[] GetTriangles(int submesh) { }

	public void GetTriangles(List<UInt16> triangles, int submesh, bool applyBaseVertex = true) { }

	public Int32[] GetTriangles(int submesh, bool applyBaseVertex) { }

	public void GetTriangles(List<Int32> triangles, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetTrianglesCount", HasExplicitThis = True)]
	private uint GetTrianglesCountImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	private Int32[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray", HasExplicitThis = True)]
	private void GetTrianglesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray16", HasExplicitThis = True)]
	private void GetTrianglesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex) { }

	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	[NativeMethod("GetMeshMetric")]
	public float GetUVDistributionMetric(int uvSetIndex) { }

	public void GetUVs(int channel, List<Vector4> uvs) { }

	public void GetUVs(int channel, List<Vector3> uvs) { }

	public void GetUVs(int channel, List<Vector2> uvs) { }

	private void GetUVsImpl(int uvIndex, List<T> uvs, int dim) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributeByIndex", HasExplicitThis = True, ThrowsException = True)]
	public VertexAttributeDescriptor GetVertexAttribute(int index) { }

	private void GetVertexAttribute_Injected(int index, out VertexAttributeDescriptor ret) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesCount", HasExplicitThis = True)]
	private int GetVertexAttributeCountImpl() { }

	[FreeFunction(Name = "MeshScripting::GetChannelDimension", HasExplicitThis = True)]
	public int GetVertexAttributeDimension(VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelFormat", HasExplicitThis = True)]
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelOffset", HasExplicitThis = True)]
	public int GetVertexAttributeOffset(VertexAttribute attr) { }

	public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { }

	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesAlloc", HasExplicitThis = True)]
	private Array GetVertexAttributesAlloc() { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesArray", HasExplicitThis = True)]
	private int GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesList", HasExplicitThis = True)]
	private int GetVertexAttributesList(List<VertexAttributeDescriptor> attributes) { }

	[FreeFunction(Name = "MeshScripting::GetChannelStream", HasExplicitThis = True)]
	public int GetVertexAttributeStream(VertexAttribute attr) { }

	public GraphicsBuffer GetVertexBuffer(int index) { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetVertexBufferImpl(int index) { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferStride", HasExplicitThis = True)]
	public int GetVertexBufferStride(int stream) { }

	public void GetVertices(List<Vector3> vertices) { }

	[NativeMethod("HasBoneWeights")]
	private bool HasBoneWeights() { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create(Mesh mono) { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = True)]
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = True)]
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	public void MarkDynamic() { }

	[NativeMethod("MarkDynamic")]
	private void MarkDynamicImpl() { }

	[NativeMethod("MarkModified")]
	public void MarkModified() { }

	public void Optimize() { }

	[NativeMethod("Optimize")]
	private void OptimizeImpl() { }

	public void OptimizeIndexBuffers() { }

	[NativeMethod("OptimizeIndexBuffers")]
	private void OptimizeIndexBuffersImpl() { }

	public void OptimizeReorderVertexBuffer() { }

	[NativeMethod("OptimizeReorderVertexBuffer")]
	private void OptimizeReorderVertexBufferImpl() { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	private void PrintErrorCantAccessIndices() { }

	public void RecalculateBounds(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateBounds() { }

	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	public void RecalculateNormals(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateNormals() { }

	[NativeMethod("RecalculateNormals")]
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	public void RecalculateTangents(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateTangents() { }

	[NativeMethod("RecalculateTangents")]
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	public void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold = 1E-09) { }

	[NativeMethod("RecalculateMeshMetric")]
	private void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold) { }

	public void RecalculateUVDistributionMetrics(float uvAreaThreshold = 1E-09) { }

	[NativeMethod("RecalculateMeshMetrics")]
	private void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold) { }

	public void set_bindposes(Matrix4x4[] value) { }

	public void set_boneWeights(BoneWeight[] value) { }

	public void set_bounds(Bounds value) { }

	private void set_bounds_Injected(ref Bounds value) { }

	public void set_colors(Color[] value) { }

	public void set_colors32(Color32[] value) { }

	public void set_indexBufferTarget(Target value) { }

	public void set_indexFormat(IndexFormat value) { }

	public void set_normals(Vector3[] value) { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	public void set_subMeshCount(int value) { }

	public void set_tangents(Vector4[] value) { }

	public void set_triangles(Int32[] value) { }

	public void set_uv(Vector2[] value) { }

	public void set_uv2(Vector2[] value) { }

	public void set_uv3(Vector2[] value) { }

	public void set_uv4(Vector2[] value) { }

	public void set_uv5(Vector2[] value) { }

	public void set_uv6(Vector2[] value) { }

	public void set_uv7(Vector2[] value) { }

	public void set_uv8(Vector2[] value) { }

	public void set_vertexBufferTarget(Target value) { }

	public void set_vertices(Vector3[] value) { }

	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, MeshUpdateFlags flags = 0) { }

	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }

	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	public void SetBoneWeights(NativeArray<Byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	public void SetColors(Color[] inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(List<Color> inColors) { }

	[ExcludeFromDocs]
	public void SetColors(List<Color> inColors, int start, int length) { }

	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(Color[] inColors) { }

	[ExcludeFromDocs]
	public void SetColors(Color[] inColors, int start, int length) { }

	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocs]
	public void SetColors(NativeArray<T> inColors, int start, int length) { }

	public void SetColors(NativeArray<T> inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(Color32[] inColors, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetColors(Color32[] inColors, int start, int length) { }

	public void SetColors(Color32[] inColors) { }

	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(NativeArray<T> inColors) { }

	[ExcludeFromDocs]
	public void SetColors(List<Color32> inColors, int start, int length) { }

	public void SetIndexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	public void SetIndexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = True, ThrowsException = True)]
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	public void SetIndices(Int32[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<UInt16> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<UInt16> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetIndices(List<Int32> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh) { }

	public void SetIndices(UInt16[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	public void SetIndices(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private void SetListForChannel(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "SetMeshComponentFromNativeArrayFromScript", HasExplicitThis = True)]
	private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetNormals(NativeArray<T> inNormals, int start, int length) { }

	public void SetNormals(Vector3[] inNormals, int start, int length, MeshUpdateFlags flags) { }

	public void SetNormals(List<Vector3> inNormals) { }

	[ExcludeFromDocs]
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	public void SetNormals(NativeArray<T> inNormals, int start, int length, MeshUpdateFlags flags) { }

	public void SetNormals(NativeArray<T> inNormals) { }

	[ExcludeFromDocs]
	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	public void SetNormals(Vector3[] inNormals) { }

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	private void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(List<SubMeshDescriptor> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(List<SubMeshDescriptor> desc, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(NativeArray<T> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(NativeArray<T> desc, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(SubMeshDescriptor[] desc, MeshUpdateFlags flags = 0) { }

	public void SetTangents(NativeArray<T> inTangents, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetTangents(NativeArray<T> inTangents, int start, int length) { }

	public void SetTangents(NativeArray<T> inTangents) { }

	public void SetTangents(Vector4[] inTangents, int start, int length, MeshUpdateFlags flags) { }

	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	public void SetTangents(Vector4[] inTangents) { }

	[ExcludeFromDocs]
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	public void SetTriangles(List<UInt16> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(List<UInt16> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(UInt16[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh) { }

	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(UInt16[] triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds) { }

	[ExcludeFromDocs]
	public void SetTriangles(Int32[] triangles, int submesh) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	public void SetUVs(int channel, Vector3[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector2> uvs) { }

	public void SetUVs(int channel, List<Vector3> uvs) { }

	public void SetUVs(int channel, NativeArray<T> uvs) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, NativeArray<T> uvs, int start, int length) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	public void SetUVs(int channel, Vector2[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	public void SetUVs(int channel, NativeArray<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	public void SetUVs(int channel, Vector4[] uvs) { }

	public void SetUVs(int channel, Vector3[] uvs) { }

	public void SetUVs(int channel, Vector2[] uvs) { }

	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	public void SetVertexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferParams(int vertexCount, NativeArray<VertexAttributeDescriptor> attributes) { }

	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromPtr", HasExplicitThis = True, ThrowsException = True)]
	private void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount) { }

	public void SetVertices(List<Vector3> inVertices) { }

	[ExcludeFromDocs]
	public void SetVertices(NativeArray<T> inVertices, int start, int length) { }

	public void SetVertices(NativeArray<T> inVertices) { }

	public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	public void SetVertices(Vector3[] inVertices) { }

	[ExcludeFromDocs]
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	public void SetVertices(NativeArray<T> inVertices, int start, int length, MeshUpdateFlags flags) { }

	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	public void UploadMeshData(bool markNoLongerReadable) { }

	[NativeMethod("UploadMeshData")]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

}

