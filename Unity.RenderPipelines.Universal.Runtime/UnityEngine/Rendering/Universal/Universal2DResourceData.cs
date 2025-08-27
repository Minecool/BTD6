namespace UnityEngine.Rendering.Universal;

internal class Universal2DResourceData : UniversalResourceDataBase
{
	private TextureHandle[][] _lightTextures; //Field offset: 0x18
	private TextureHandle[] _cameraNormalsTexture; //Field offset: 0x20
	private TextureHandle[][] _shadowTextures; //Field offset: 0x28
	private TextureHandle _shadowDepth; //Field offset: 0x30
	private TextureHandle _upscaleTexture; //Field offset: 0x40
	private TextureHandle _cameraSortingLayerTexture; //Field offset: 0x50

	internal TextureHandle cameraSortingLayerTexture
	{
		internal get { } //Length: 41
		internal set { } //Length: 121
	}

	internal TextureHandle[][] lightTextures
	{
		internal get { } //Length: 12
		internal set { } //Length: 15
	}

	internal TextureHandle[] normalsTexture
	{
		internal get { } //Length: 12
		internal set { } //Length: 15
	}

	internal TextureHandle shadowDepth
	{
		internal get { } //Length: 41
		internal set { } //Length: 121
	}

	internal TextureHandle[][] shadowTextures
	{
		internal get { } //Length: 12
		internal set { } //Length: 15
	}

	internal TextureHandle upscaleTexture
	{
		internal get { } //Length: 41
		internal set { } //Length: 121
	}

	public Universal2DResourceData() { }

	private TextureHandle[][] CheckAndGetTextureHandle(ref TextureHandle[][] handle) { }

	private void CheckAndSetTextureHandle(ref TextureHandle[][] handle, TextureHandle[][] newHandle) { }

	internal TextureHandle get_cameraSortingLayerTexture() { }

	internal TextureHandle[][] get_lightTextures() { }

	internal TextureHandle[] get_normalsTexture() { }

	internal TextureHandle get_shadowDepth() { }

	internal TextureHandle[][] get_shadowTextures() { }

	internal TextureHandle get_upscaleTexture() { }

	public virtual void Reset() { }

	internal void set_cameraSortingLayerTexture(TextureHandle value) { }

	internal void set_lightTextures(TextureHandle[][] value) { }

	internal void set_normalsTexture(TextureHandle[] value) { }

	internal void set_shadowDepth(TextureHandle value) { }

	internal void set_shadowTextures(TextureHandle[][] value) { }

	internal void set_upscaleTexture(TextureHandle value) { }

}

