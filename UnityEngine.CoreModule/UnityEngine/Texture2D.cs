namespace UnityEngine;

[ExcludeFromPreset]
[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[UsedByNativeCode]
public sealed class Texture2D : Texture
{
	internal const int streamingMipmapsPriorityMin = -128; //Field offset: 0x0
	internal const int streamingMipmapsPriorityMax = 127; //Field offset: 0x0

	public int activeMipmapLimit
	{
		[NativeName("GetMipmapLimit")]
		 get { } //Length: 51
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D blackTexture
	{
		 get { } //Length: 42
	}

	public int calculatedMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 51
	}

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

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D grayTexture
	{
		 get { } //Length: 42
	}

	public bool ignoreMipmapLimit
	{
		[NativeName("IgnoreMipmapLimit")]
		 get { } //Length: 51
		[NativeName("SetIgnoreMipmapLimitAndReload")]
		 set { } //Length: 66
	}

	internal bool isPreProcessed
	{
		internal get { } //Length: 51
	}

	public virtual bool isReadable
	{
		 get { } //Length: 51
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D linearGrayTexture
	{
		 get { } //Length: 42
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

	public int minimumMipmapLevel
	{
		[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
		 set { } //Length: 64
	}

	public string mipmapLimitGroup
	{
		[NativeName("GetMipmapLimitGroupName")]
		 get { } //Length: 51
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D normalTexture
	{
		 get { } //Length: 42
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D redTexture
	{
		 get { } //Length: 42
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

	[NativeConditional("ENABLE_VIRTUALTEXTURING && UNITY_EDITOR")]
	[NativeName("VTOnly")]
	public bool vtOnly
	{
		 get { } //Length: 51
	}

	[StaticAccessor("builtintex", StaticAccessorType::DoubleColon (2))]
	public static Texture2D whiteTexture
	{
		 get { } //Length: 42
	}

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, DefaultFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, string mipmapLimitGroupName, TextureCreationFlags flags) { }

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	[ExcludeFromDocs]
	public Texture2D(int width, int height, GraphicsFormat format, int mipCount, TextureCreationFlags flags) { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	public void Apply(bool updateMipmaps) { }

	[ExcludeFromDocs]
	public void Apply() { }

	[NativeName("Apply")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearMinimumMipmapLevel", HasExplicitThis = True)]
	public void ClearMinimumMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().ClearRequestedMipmapLevel", HasExplicitThis = True)]
	public void ClearRequestedMipmapLevel() { }

	public void Compress(bool highQuality) { }

	public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex) { }

	public static bool GenerateAtlas(Vector2[] sizes, int padding, int atlasSize, List<Rect> results) { }

	[FreeFunction("Texture2DScripting::GenerateAtlas")]
	private static void GenerateAtlasImpl(Vector2[] sizes, int padding, int atlasSize, out Rect[] rect) { }

	[NativeName("GetMipmapLimit")]
	public int get_activeMipmapLimit() { }

	public static Texture2D get_blackTexture() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetCalculatedMipmapLevel", HasExplicitThis = True)]
	public int get_calculatedMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetDesiredMipmapLevel", HasExplicitThis = True)]
	public int get_desiredMipmapLevel() { }

	[NativeName("GetTextureFormat")]
	public TextureFormat get_format() { }

	public static Texture2D get_grayTexture() { }

	[NativeName("IgnoreMipmapLimit")]
	public bool get_ignoreMipmapLimit() { }

	internal bool get_isPreProcessed() { }

	public virtual bool get_isReadable() { }

	public static Texture2D get_linearGrayTexture() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadAllMips", HasExplicitThis = True)]
	internal bool get_loadAllMips() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadedMipmapLevel", HasExplicitThis = True)]
	public int get_loadedMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetLoadingMipmapLevel", HasExplicitThis = True)]
	public int get_loadingMipmapLevel() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetMinimumMipmapLevel", HasExplicitThis = True)]
	public int get_minimumMipmapLevel() { }

	[NativeName("GetMipmapLimitGroupName")]
	public string get_mipmapLimitGroup() { }

	public static Texture2D get_normalTexture() { }

	public static Texture2D get_redTexture() { }

	[FreeFunction(Name = "GetTextureStreamingManager().GetRequestedMipmapLevel", HasExplicitThis = True)]
	public int get_requestedMipmapLevel() { }

	public bool get_streamingMipmaps() { }

	public int get_streamingMipmapsPriority() { }

	public bool get_vtOnly() { }

	public static Texture2D get_whiteTexture() { }

	public Color GetPixel(int x, int y, int mipLevel) { }

	[ExcludeFromDocs]
	public Color GetPixel(int x, int y) { }

	public Color GetPixelBilinear(float u, float v, int mipLevel) { }

	[ExcludeFromDocs]
	public Color GetPixelBilinear(float u, float v) { }

	[NativeName("GetPixelBilinear")]
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret) { }

	public NativeArray<T> GetPixelData(int mipLevel) { }

	[NativeName("GetPixel")]
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret) { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	public Color[] GetPixels(int miplevel) { }

	[ExcludeFromDocs]
	public Color[] GetPixels() { }

	[ExcludeFromDocs]
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	public Color32[] GetPixels32(int miplevel) { }

	[ExcludeFromDocs]
	public Color32[] GetPixels32() { }

	private ulong GetRawImageDataSize() { }

	[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = True, ThrowsException = True)]
	public Byte[] GetRawTextureData() { }

	public NativeArray<T> GetRawTextureData() { }

	private IntPtr GetWritableImageData(int frame) { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[FreeFunction("Texture2DScripting::Create")]
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	[FreeFunction(Name = "GetTextureStreamingManager().IsRequestedMipmapLevelLoaded", HasExplicitThis = True)]
	public bool IsRequestedMipmapLevelLoaded() { }

	public void LoadRawTextureData(IntPtr data, int size) { }

	public void LoadRawTextureData(Byte[] data) { }

	public void LoadRawTextureData(NativeArray<T> data) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	private bool LoadRawTextureDataImpl(IntPtr data, ulong size) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	private bool LoadRawTextureDataImplArray(Byte[] data) { }

	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize) { }

	public Rect[] PackTextures(Texture2D[] textures, int padding) { }

	[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = True)]
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	public void ReadPixels(Rect source, int destX, int destY) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = True)]
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	public bool Reinitialize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	public bool Reinitialize(int width, int height) { }

	[NativeName("Reinitialize")]
	private bool ReinitializeImpl(int width, int height) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithFormat", HasExplicitThis = True)]
	private bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", False)]
	public bool Resize(int width, int height, TextureFormat format, bool hasMipMap) { }

	[Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", False)]
	public bool Resize(int width, int height) { }

	[Obsolete("Texture2D.Resize(int, int, GraphicsFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, GraphicsFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, [*] System.Boolean)", False)]
	public bool Resize(int width, int height, GraphicsFormat format, bool hasMipMap) { }

	[NativeName("SetIgnoreMipmapLimitAndReload")]
	public void set_ignoreMipmapLimit(bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetLoadAllMips", HasExplicitThis = True)]
	internal void set_loadAllMips(bool value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetMinimumMipmapLevel", HasExplicitThis = True)]
	public void set_minimumMipmapLevel(int value) { }

	[FreeFunction(Name = "GetTextureStreamingManager().SetRequestedMipmapLevel", HasExplicitThis = True)]
	public void set_requestedMipmapLevel(int value) { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunction("Texture2DScripting::SetBlockOfPixels32", HasExplicitThis = True, ThrowsException = True)]
	private void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixel(int x, int y, Color color) { }

	public void SetPixel(int x, int y, Color color, int mipLevel) { }

	public void SetPixelData(NativeArray<T> data, int mipLevel, int sourceDataStartIndex = 0) { }

	public void SetPixelData(T[] data, int mipLevel, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixelData", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImpl(IntPtr data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixelDataArray", HasExplicitThis = True, ThrowsException = True)]
	private bool SetPixelDataImplArray(Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex = 0) { }

	[NativeName("SetPixel")]
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	public void SetPixels(Color[] colors, int miplevel) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels32(Color32[] colors) { }

	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	public void SetPixels32(int x, int y, int blockWidth, int blockHeight, Color32[] colors) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = True)]
	public void UpdateExternalTexture(IntPtr nativeTex) { }

	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

}

