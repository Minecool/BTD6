namespace UnityEngine;

[NativeHeader("Runtime/Graphics/TrailRenderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public sealed class TrailRenderer : Renderer
{

	public LineAlignment alignment
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool autodestruct
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Gradient colorGradient
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool emitting
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Color endColor
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public float endWidth
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool generateLightingData
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float minVertexDistance
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public int numCapVertices
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int numCornerVertices
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[Obsolete("Use positionCount instead (UnityUpgradable) -> positionCount", False)]
	public int numPositions
	{
		 get { } //Length: 51
	}

	[NativeProperty("PositionsCount")]
	public int positionCount
	{
		 get { } //Length: 51
	}

	public float shadowBias
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Color startColor
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public float startWidth
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public LineTextureMode textureMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Vector2 textureScale
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public float time
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public AnimationCurve widthCurve
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float widthMultiplier
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public TrailRenderer() { }

	[FreeFunction(Name = "TrailRendererScripting::AddPosition", HasExplicitThis = True)]
	public void AddPosition(Vector3 position) { }

	private void AddPosition_Injected(ref Vector3 position) { }

	public void AddPositions(out NativeSlice<Vector3> positions) { }

	public void AddPositions(out NativeArray<Vector3> positions) { }

	[FreeFunction(Name = "TrailRendererScripting::AddPositions", HasExplicitThis = True)]
	public void AddPositions(Vector3[] positions) { }

	[FreeFunction(Name = "TrailRendererScripting::AddPositionsWithNativeContainer", HasExplicitThis = True)]
	private void AddPositionsWithNativeContainer(IntPtr positions, int length) { }

	public void BakeMesh(Mesh mesh, bool useTransform = false) { }

	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	public void Clear() { }

	public LineAlignment get_alignment() { }

	public bool get_autodestruct() { }

	public Gradient get_colorGradient() { }

	public bool get_emitting() { }

	public Color get_endColor() { }

	private void get_endColor_Injected(out Color ret) { }

	public float get_endWidth() { }

	public bool get_generateLightingData() { }

	public SpriteMaskInteraction get_maskInteraction() { }

	public float get_minVertexDistance() { }

	public int get_numCapVertices() { }

	public int get_numCornerVertices() { }

	public int get_numPositions() { }

	public int get_positionCount() { }

	public float get_shadowBias() { }

	public Color get_startColor() { }

	private void get_startColor_Injected(out Color ret) { }

	public float get_startWidth() { }

	public LineTextureMode get_textureMode() { }

	public Vector2 get_textureScale() { }

	private void get_textureScale_Injected(out Vector2 ret) { }

	public float get_time() { }

	public AnimationCurve get_widthCurve() { }

	public float get_widthMultiplier() { }

	private Gradient GetColorGradientCopy() { }

	public Vector3 GetPosition(int index) { }

	private void GetPosition_Injected(int index, out Vector3 ret) { }

	public int GetPositions(out NativeSlice<Vector3> positions) { }

	public int GetPositions(out NativeArray<Vector3> positions) { }

	[FreeFunction(Name = "TrailRendererScripting::GetPositions", HasExplicitThis = True)]
	public int GetPositions(out Vector3[] positions) { }

	[FreeFunction(Name = "TrailRendererScripting::GetPositionsWithNativeContainer", HasExplicitThis = True)]
	private int GetPositionsWithNativeContainer(IntPtr positions, int length) { }

	[FreeFunction(Name = "TrailRendererScripting::GetVisiblePositions", HasExplicitThis = True)]
	public int GetVisiblePositions(out Vector3[] positions) { }

	public int GetVisiblePositions(out NativeSlice<Vector3> positions) { }

	public int GetVisiblePositions(out NativeArray<Vector3> positions) { }

	[FreeFunction(Name = "TrailRendererScripting::GetVisiblePositionsWithNativeContainer", HasExplicitThis = True)]
	private int GetVisiblePositionsWithNativeContainer(IntPtr positions, int length) { }

	private AnimationCurve GetWidthCurveCopy() { }

	public void set_alignment(LineAlignment value) { }

	public void set_autodestruct(bool value) { }

	public void set_colorGradient(Gradient value) { }

	public void set_emitting(bool value) { }

	public void set_endColor(Color value) { }

	private void set_endColor_Injected(ref Color value) { }

	public void set_endWidth(float value) { }

	public void set_generateLightingData(bool value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	public void set_minVertexDistance(float value) { }

	public void set_numCapVertices(int value) { }

	public void set_numCornerVertices(int value) { }

	public void set_shadowBias(float value) { }

	public void set_startColor(Color value) { }

	private void set_startColor_Injected(ref Color value) { }

	public void set_startWidth(float value) { }

	public void set_textureMode(LineTextureMode value) { }

	public void set_textureScale(Vector2 value) { }

	private void set_textureScale_Injected(ref Vector2 value) { }

	public void set_time(float value) { }

	public void set_widthCurve(AnimationCurve value) { }

	public void set_widthMultiplier(float value) { }

	private void SetColorGradient(Gradient curve) { }

	public void SetPosition(int index, Vector3 position) { }

	private void SetPosition_Injected(int index, ref Vector3 position) { }

	[FreeFunction(Name = "TrailRendererScripting::SetPositions", HasExplicitThis = True)]
	public void SetPositions(Vector3[] positions) { }

	public void SetPositions(NativeArray<Vector3> positions) { }

	public void SetPositions(NativeSlice<Vector3> positions) { }

	[FreeFunction(Name = "TrailRendererScripting::SetPositionsWithNativeContainer", HasExplicitThis = True)]
	private void SetPositionsWithNativeContainer(IntPtr positions, int count) { }

	private void SetWidthCurve(AnimationCurve curve) { }

}

