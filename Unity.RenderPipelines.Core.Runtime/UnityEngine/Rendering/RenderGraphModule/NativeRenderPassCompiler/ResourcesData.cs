namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DefaultMember("Item")]
internal class ResourcesData
{
	public NativeList<ResourceUnversionedData>[] unversionedData; //Field offset: 0x10
	public NativeList<ResourceVersionedData>[] versionedData; //Field offset: 0x18
	public NativeList<ResourceReaderData>[] readerData; //Field offset: 0x20
	public int MaxVersions; //Field offset: 0x28
	public int MaxReaders; //Field offset: 0x2C
	public DynamicArray<Name>[] resourceNames; //Field offset: 0x30

	public ResourceVersionedData Item
	{
		 get { } //Length: 277
	}

	public ResourcesData() { }

	private void AllocateAndResizeNativeListIfNeeded(ref NativeList<T>& nativeList, int size, NativeArrayOptions options) { }

	public void Clear() { }

	public void Dispose() { }

	public ResourceVersionedData get_Item(ResourceHandle h) { }

	public int Index(ResourceHandle h) { }

	public int IndexReader(ResourceHandle h, int readerID) { }

	public void Initialize(RenderGraphResourceRegistry resources) { }

}

