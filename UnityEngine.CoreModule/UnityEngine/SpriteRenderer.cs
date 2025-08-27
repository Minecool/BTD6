namespace UnityEngine;

[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class SpriteRenderer : Renderer
{
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; //Field offset: 0x18

	public float adaptiveModeThreshold
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Color color
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	public SpriteDrawMode drawMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public bool flipX
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool flipY
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	internal bool hasSpriteChangeEvents
	{
		internal get { } //Length: 118
		internal set { } //Length: 134
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	internal bool shouldSupportTiling
	{
		[NativeMethod("ShouldSupportTiling")]
		internal get { } //Length: 118
	}

	public Vector2 size
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public Sprite sprite
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public SpriteSortPoint spriteSortPoint
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public SpriteTileMode tileMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public SpriteRenderer() { }

	public float get_adaptiveModeThreshold() { }

	private static float get_adaptiveModeThreshold_Injected(IntPtr _unity_self) { }

	public Color get_color() { }

	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	public SpriteDrawMode get_drawMode() { }

	private static SpriteDrawMode get_drawMode_Injected(IntPtr _unity_self) { }

	public bool get_flipX() { }

	private static bool get_flipX_Injected(IntPtr _unity_self) { }

	public bool get_flipY() { }

	private static bool get_flipY_Injected(IntPtr _unity_self) { }

	internal bool get_hasSpriteChangeEvents() { }

	private static bool get_hasSpriteChangeEvents_Injected(IntPtr _unity_self) { }

	public SpriteMaskInteraction get_maskInteraction() { }

	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	[NativeMethod("ShouldSupportTiling")]
	internal bool get_shouldSupportTiling() { }

	private static bool get_shouldSupportTiling_Injected(IntPtr _unity_self) { }

	public Vector2 get_size() { }

	private static void get_size_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public Sprite get_sprite() { }

	private static IntPtr get_sprite_Injected(IntPtr _unity_self) { }

	public SpriteSortPoint get_spriteSortPoint() { }

	private static SpriteSortPoint get_spriteSortPoint_Injected(IntPtr _unity_self) { }

	public SpriteTileMode get_tileMode() { }

	private static SpriteTileMode get_tileMode_Injected(IntPtr _unity_self) { }

	internal MeshDataArray GetCurrentMeshData() { }

	private IntPtr GetCurrentMeshDataPtr() { }

	private static IntPtr GetCurrentMeshDataPtr_Injected(IntPtr _unity_self) { }

	internal void GetSecondaryTextureProperties(MaterialPropertyBlock mbp) { }

	private static void GetSecondaryTextureProperties_Injected(IntPtr _unity_self, IntPtr mbp) { }

	internal Bounds GetSpriteBounds() { }

	[NativeMethod(Name = "GetSpriteBounds")]
	internal Bounds Internal_GetSpriteBounds(SpriteDrawMode mode) { }

	private static void Internal_GetSpriteBounds_Injected(IntPtr _unity_self, SpriteDrawMode mode, out Bounds ret) { }

	[RequiredByNativeCode]
	private void InvokeSpriteChanged() { }

	public void RegisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback) { }

	public void set_adaptiveModeThreshold(float value) { }

	private static void set_adaptiveModeThreshold_Injected(IntPtr _unity_self, float value) { }

	public void set_color(Color value) { }

	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	public void set_drawMode(SpriteDrawMode value) { }

	private static void set_drawMode_Injected(IntPtr _unity_self, SpriteDrawMode value) { }

	public void set_flipX(bool value) { }

	private static void set_flipX_Injected(IntPtr _unity_self, bool value) { }

	public void set_flipY(bool value) { }

	private static void set_flipY_Injected(IntPtr _unity_self, bool value) { }

	internal void set_hasSpriteChangeEvents(bool value) { }

	private static void set_hasSpriteChangeEvents_Injected(IntPtr _unity_self, bool value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	public void set_size(Vector2 value) { }

	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_sprite(Sprite value) { }

	private static void set_sprite_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_spriteSortPoint(SpriteSortPoint value) { }

	private static void set_spriteSortPoint_Injected(IntPtr _unity_self, SpriteSortPoint value) { }

	public void set_tileMode(SpriteTileMode value) { }

	private static void set_tileMode_Injected(IntPtr _unity_self, SpriteTileMode value) { }

	public void UnregisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback) { }

}

