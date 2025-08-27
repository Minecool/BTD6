namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
public sealed class Cubemap : Texture
{

	public int desiredMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public TextureFormat format
	{
		[NativeName("GetTextureFormat")]
		 get { } //Length: 51
	}

	internal bool isPreProcessed
	{
		internal get { } //Length: 51
	}

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	internal bool loadAllMips
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
		internal get { } //Length: 51
		[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
		internal set { } //Length: 66
	}

	public int loadedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public int loadingMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public int requestedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
		 set { } //Length: 64
	}

	public bool streamingMipmaps
	{
		 get { } //Length: 51
	}

	public int streamingMipmapsPriority
	{
		 get { } //Length: 51
	}

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	public Cubemap(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	public Cubemap(int width, TextureFormat format, int mipCount) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public void Apply() { }

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "CubemapScripting::Apply", HasExplicitThis = True)]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	public void ClearRequestedMipmapLevel() { }

	public static Cubemap CreateExternalTexture(int width, TextureFormat format, bool mipmap, IntPtr nativeTex) { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
	public int get_desiredMipmapLevel() { }

	[NativeName("GetTextureFormat")]
	public TextureFormat get_format() { }

	internal bool get_isPreProcessed() { }

	public virtual bool get_isReadable() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
	internal bool get_loadAllMips() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
	public int get_loadedMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
	public int get_loadingMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
	public int get_requestedMipmapLevel() { }

	public bool get_streamingMipmaps() { }

	public int get_streamingMipmapsPriority() { }

	public Color GetPixel(CubemapFace face, int x, int y, int mip) { }

	[ExcludeFromDocs]
	public Color GetPixel(CubemapFace face, int x, int y) { }

	public NativeArray<T> GetPixelData(int mipLevel, CubemapFace face) { }

	[NativeName("GetPixel")]
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret) { }

	public Color[] GetPixels(CubemapFace face) { }

	[FreeFunction(Name = "CubemapScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(CubemapFace face, int miplevel) { }

	private IntPtr GetWritableImageData(int frame) { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction("CubemapScripting::Create")]
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	public bool IsRequestedMipmapLevelLoaded() { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
	internal void set_loadAllMips(bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	public void set_requestedMipmapLevel(int value) { }

	[ExcludeFromDocs]
	public void SetPixel(CubemapFace face, int x, int y, Color color) { }

	public void SetPixel(CubemapFace face, int x, int y, Color color, int mip) { }

	public void SetPixelData(T[] data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	public void SetPixelData(NativeArray<T> data, int mipLevel, CubemapFace face, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "CubemapScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "CubemapScripting::SetPixelDataArray", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	public void SetPixels(Color[] colors, CubemapFace face) { }

	[FreeFunction(Name = "CubemapScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	public void SetPixels(Color[] colors, CubemapFace face, int miplevel) { }

	[NativeName("FixupEdges")]
	public void SmoothEdges(int smoothRegionWidthInPixels) { }

	public void SmoothEdges() { }

	[FreeFunction("CubemapScripting::UpdateExternalTexture", HasExplicitThis = True)]
	public void UpdateExternalTexture(IntPtr nativeTexture) { }

	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	internal bool ValidateFormat(TextureFormat format, int width) { }

	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

