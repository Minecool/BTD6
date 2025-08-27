namespace UnityEngine;

[NativeClass("UI::Canvas")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/UIStructs.h")]
[RequireComponent(typeof(RectTransform))]
public sealed class Canvas : Behaviour
{
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		public WillRenderCanvases(object object, IntPtr method) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externBeginRenderOverlays>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32, Int32> <externRenderOverlaysBefore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Int32> <externEndRenderOverlays>k__BackingField; //Field offset: 0x20

	public static event WillRenderCanvases preWillRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	public static event WillRenderCanvases willRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 184
		[CompilerGenerated]
		 remove { } //Length: 184
	}

	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int cachedSortingLayerValue
	{
		 get { } //Length: 51
	}

	internal static Action<Int32> externBeginRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 55
		[CompilerGenerated]
		internal set { } //Length: 61
	}

	internal static Action<Int32> externEndRenderOverlays
	{
		[CompilerGenerated]
		internal get { } //Length: 55
		[CompilerGenerated]
		internal set { } //Length: 61
	}

	internal static Action<Int32, Int32> externRenderOverlaysBefore
	{
		[CompilerGenerated]
		internal get { } //Length: 55
		[CompilerGenerated]
		internal set { } //Length: 61
	}

	public bool isRootCanvas
	{
		 get { } //Length: 51
	}

	[NativeProperty("SortingBucketNormalizedSize", False, TargetType::Function (0))]
	public float normalizedSortingGridSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool overridePixelPerfect
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool overrideSorting
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool pixelPerfect
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Rect pixelRect
	{
		 get { } //Length: 75
	}

	public float planeDistance
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Vector2 renderingDisplaySize
	{
		 get { } //Length: 68
	}

	public RenderMode renderMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int renderOrder
	{
		 get { } //Length: 51
	}

	public Canvas rootCanvas
	{
		 get { } //Length: 51
	}

	public float scaleFactor
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty("SortingBucketNormalizedSize", False, TargetType::Function (0))]
	[Obsolete("Setting normalizedSize via a int is not supported. Please use normalizedSortingGridSize", False)]
	public int sortingGridNormalizedSize
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int sortingLayerID
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string sortingLayerName
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int sortingOrder
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int targetDisplay
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public StandaloneRenderResize updateRectTransformForStandalone
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool vertexColorAlwaysGammaSpace
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("Camera", False, TargetType::Function (0))]
	public Camera worldCamera
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Canvas() { }

	[CompilerGenerated]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	private static void EndRenderExtraOverlays(int displayIndex) { }

	public static void ForceUpdateCanvases() { }

	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	public int get_cachedSortingLayerValue() { }

	[CompilerGenerated]
	internal static Action<Int32> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	internal static Action<Int32> get_externEndRenderOverlays() { }

	[CompilerGenerated]
	internal static Action<Int32, Int32> get_externRenderOverlaysBefore() { }

	public bool get_isRootCanvas() { }

	public float get_normalizedSortingGridSize() { }

	public bool get_overridePixelPerfect() { }

	public bool get_overrideSorting() { }

	public bool get_pixelPerfect() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	public float get_planeDistance() { }

	public float get_referencePixelsPerUnit() { }

	public Vector2 get_renderingDisplaySize() { }

	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }

	public RenderMode get_renderMode() { }

	public int get_renderOrder() { }

	public Canvas get_rootCanvas() { }

	public float get_scaleFactor() { }

	public int get_sortingGridNormalizedSize() { }

	public int get_sortingLayerID() { }

	public string get_sortingLayerName() { }

	public int get_sortingOrder() { }

	public int get_targetDisplay() { }

	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	public bool get_vertexColorAlwaysGammaSpace() { }

	public Camera get_worldCamera() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	[Obsolete("Shared default material now used for text and general UI elements, call Canvas.GetDefaultCanvasMaterial()", False)]
	public static Material GetDefaultCanvasTextMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	public static Material GetETC1SupportedCanvasMaterial() { }

	[CompilerGenerated]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	private static void SendWillRenderCanvases() { }

	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	[CompilerGenerated]
	internal static void set_externBeginRenderOverlays(Action<Int32> value) { }

	[CompilerGenerated]
	internal static void set_externEndRenderOverlays(Action<Int32> value) { }

	[CompilerGenerated]
	internal static void set_externRenderOverlaysBefore(Action<Int32, Int32> value) { }

	public void set_normalizedSortingGridSize(float value) { }

	public void set_overridePixelPerfect(bool value) { }

	public void set_overrideSorting(bool value) { }

	public void set_pixelPerfect(bool value) { }

	public void set_planeDistance(float value) { }

	public void set_referencePixelsPerUnit(float value) { }

	public void set_renderMode(RenderMode value) { }

	public void set_scaleFactor(float value) { }

	public void set_sortingGridNormalizedSize(int value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	public void set_targetDisplay(int value) { }

	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	public void set_worldCamera(Camera value) { }

	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

}

