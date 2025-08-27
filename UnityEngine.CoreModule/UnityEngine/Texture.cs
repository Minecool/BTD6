namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
[UsedByNativeCode]
public class Texture : object
{
	public static readonly int GenerateAllMips; //Field offset: 0x0

	internal ColorSpace activeTextureColorSpace
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"}])]
		internal get { } //Length: 60
	}

	public int anisoLevel
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public override TextureDimension dimension
	{
		 get { } //Length: 51
		 set { } //Length: 62
	}

	public FilterMode filterMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public override GraphicsFormat graphicsFormat
	{
		 get { } //Length: 73
	}

	public override int height
	{
		 get { } //Length: 51
		 set { } //Length: 62
	}

	public override bool isReadable
	{
		 get { } //Length: 51
	}

	public float mipMapBias
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public int mipmapCount
	{
		[NativeName("GetMipmapCount")]
		 get { } //Length: 51
	}

	public Vector2 texelSize
	{
		[NativeName("GetTexelSize")]
		 get { } //Length: 68
	}

	public uint updateCount
	{
		 get { } //Length: 51
	}

	public override int width
	{
		 get { } //Length: 51
		 set { } //Length: 62
	}

	public TextureWrapMode wrapMode
	{
		[NativeName("GetWrapModeU")]
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public TextureWrapMode wrapModeU
	{
		 set { } //Length: 64
	}

	public TextureWrapMode wrapModeV
	{
		 set { } //Length: 64
	}

	public TextureWrapMode wrapModeW
	{
		 set { } //Length: 64
	}

	private static Texture() { }

	protected Texture() { }

	internal UnityException CreateNativeArrayLengthOverflowException() { }

	internal UnityException CreateNonReadableException(Texture t) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "Unity.UIElements"}])]
	internal ColorSpace get_activeTextureColorSpace() { }

	public int get_anisoLevel() { }

	public override TextureDimension get_dimension() { }

	public FilterMode get_filterMode() { }

	public override GraphicsFormat get_graphicsFormat() { }

	public override int get_height() { }

	public override bool get_isReadable() { }

	public float get_mipMapBias() { }

	[NativeName("GetMipmapCount")]
	public int get_mipmapCount() { }

	[NativeName("GetTexelSize")]
	public Vector2 get_texelSize() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

	public uint get_updateCount() { }

	public override int get_width() { }

	[NativeName("GetWrapModeU")]
	public TextureWrapMode get_wrapMode() { }

	private int GetDataHeight() { }

	private int GetDataWidth() { }

	private TextureDimension GetDimension() { }

	internal ulong GetPixelDataOffset(int mipLevel, int element = 0) { }

	internal ulong GetPixelDataSize(int mipLevel, int element = 0) { }

	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	[NativeMethod("GetActiveTextureColorSpace")]
	private int Internal_GetActiveTextureColorSpace() { }

	public void set_anisoLevel(int value) { }

	public override void set_dimension(TextureDimension value) { }

	public void set_filterMode(FilterMode value) { }

	public override void set_height(int value) { }

	public void set_mipMapBias(float value) { }

	public override void set_width(int value) { }

	public void set_wrapMode(TextureWrapMode value) { }

	public void set_wrapModeU(TextureWrapMode value) { }

	public void set_wrapModeV(TextureWrapMode value) { }

	public void set_wrapModeW(TextureWrapMode value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

}

