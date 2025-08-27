namespace UnityEngine.Experimental.Rendering;

public class XRPass
{
	private readonly List<XRView> m_Views; //Field offset: 0x10
	private readonly XROcclusionMesh m_OcclusionMesh; //Field offset: 0x18
	[CompilerGenerated]
	private bool <copyDepth>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <multipassId>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <cullingPassId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private RenderTargetIdentifier <renderTarget>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private RenderTextureDescriptor <renderTargetDesc>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private ScriptableCullingParameters <cullingParams>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private IntPtr <foveatedRenderingInfo>k__BackingField; //Field offset: 0x6C0
	[CompilerGenerated]
	private float <occlusionMeshScale>k__BackingField; //Field offset: 0x6C8

	public private bool copyDepth
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private ScriptableCullingParameters cullingParams
	{
		[CompilerGenerated]
		 get { } //Length: 36
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private int cullingPassId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool enabled
	{
		 get { } //Length: 64
	}

	public private IntPtr foveatedRenderingInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool hasValidOcclusionMesh
	{
		 get { } //Length: 205
	}

	public ColorGamut hdrDisplayOutputColorGamut
	{
		 get { } //Length: 161
	}

	public HDRDisplayInformation hdrDisplayOutputInformation
	{
		 get { } //Length: 623
	}

	public bool isHDRDisplayOutputActive
	{
		 get { } //Length: 161
	}

	public private int multipassId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float occlusionMeshScale
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private RenderTargetIdentifier renderTarget
	{
		[CompilerGenerated]
		 get { } //Length: 29
		[CompilerGenerated]
		private set { } //Length: 26
	}

	public private RenderTextureDescriptor renderTargetDesc
	{
		[CompilerGenerated]
		 get { } //Length: 36
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public bool singlePassEnabled
	{
		 get { } //Length: 64
	}

	public bool supportsFoveatedRendering
	{
		 get { } //Length: 215
	}

	public int viewCount
	{
		 get { } //Length: 60
	}

	public XRPass() { }

	internal void AddView(XRView xrView) { }

	public Vector4 ApplyXRViewCenterOffset(Vector2 center) { }

	internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams) { }

	internal void AssignView(int viewId, XRView xrView) { }

	public static XRPass CreateDefault(XRPassCreateInfo createInfo) { }

	[CompilerGenerated]
	public bool get_copyDepth() { }

	[CompilerGenerated]
	public ScriptableCullingParameters get_cullingParams() { }

	[CompilerGenerated]
	public int get_cullingPassId() { }

	public bool get_enabled() { }

	[CompilerGenerated]
	public IntPtr get_foveatedRenderingInfo() { }

	public bool get_hasValidOcclusionMesh() { }

	public ColorGamut get_hdrDisplayOutputColorGamut() { }

	public HDRDisplayInformation get_hdrDisplayOutputInformation() { }

	public bool get_isHDRDisplayOutputActive() { }

	[CompilerGenerated]
	public int get_multipassId() { }

	[CompilerGenerated]
	public float get_occlusionMeshScale() { }

	[CompilerGenerated]
	public RenderTargetIdentifier get_renderTarget() { }

	[CompilerGenerated]
	public RenderTextureDescriptor get_renderTargetDesc() { }

	public bool get_singlePassEnabled() { }

	public bool get_supportsFoveatedRendering() { }

	public int get_viewCount() { }

	public Mesh GetOcclusionMesh(int viewIndex = 0) { }

	public Matrix4x4 GetProjMatrix(int viewIndex = 0) { }

	public int GetTextureArraySlice(int viewIndex = 0) { }

	public Matrix4x4 GetViewMatrix(int viewIndex = 0) { }

	public Rect GetViewport(int viewIndex = 0) { }

	public void InitBase(XRPassCreateInfo createInfo) { }

	public override void Release() { }

	public void RenderOcclusionMesh(CommandBuffer cmd, bool renderIntoTexture = false) { }

	[CompilerGenerated]
	private void set_copyDepth(bool value) { }

	[CompilerGenerated]
	private void set_cullingParams(ScriptableCullingParameters value) { }

	[CompilerGenerated]
	private void set_cullingPassId(int value) { }

	[CompilerGenerated]
	private void set_foveatedRenderingInfo(IntPtr value) { }

	[CompilerGenerated]
	private void set_multipassId(int value) { }

	[CompilerGenerated]
	private void set_occlusionMeshScale(float value) { }

	[CompilerGenerated]
	private void set_renderTarget(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	private void set_renderTargetDesc(RenderTextureDescriptor value) { }

	public void StartSinglePass(CommandBuffer cmd) { }

	public void StopSinglePass(CommandBuffer cmd) { }

	internal void UpdateCombinedOcclusionMesh() { }

}

