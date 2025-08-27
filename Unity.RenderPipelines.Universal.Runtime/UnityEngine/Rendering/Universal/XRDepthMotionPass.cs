namespace UnityEngine.Rendering.Universal;

public class XRDepthMotionPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public XRDepthMotionPass <>4__this; //Field offset: 0x10
		public PassData passData; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Render>b__0(PassData data, RasterGraphContext context) { }

	}

	private class PassData
	{
		internal RendererListHandle objMotionRendererList; //Field offset: 0x10
		internal Matrix4x4[] previousViewProjectionStereo; //Field offset: 0x20
		internal Matrix4x4[] viewProjectionStereo; //Field offset: 0x28
		internal Material xrMotionVector; //Field offset: 0x30

		public PassData() { }

	}

	private static readonly ShaderTagId k_MotionOnlyShaderTagId; //Field offset: 0x0
	private const int k_XRViewCount = 2; //Field offset: 0x0
	private static readonly int k_SpaceWarpNDCModifier; //Field offset: 0x4
	private PassData m_PassData; //Field offset: 0xB8
	private RTHandle m_XRMotionVectorColor; //Field offset: 0xC0
	private TextureHandle xrMotionVectorColor; //Field offset: 0xC8
	private RTHandle m_XRMotionVectorDepth; //Field offset: 0xD8
	private TextureHandle xrMotionVectorDepth; //Field offset: 0xE0
	private bool m_XRSpaceWarpRightHandedNDC; //Field offset: 0xF0
	private Matrix4x4[] m_ViewProjection; //Field offset: 0xF8
	private Matrix4x4[] m_PreviousViewProjection; //Field offset: 0x100
	private int m_LastFrameIndex; //Field offset: 0x108
	private Material m_XRMotionVectorMaterial; //Field offset: 0x110

	private static XRDepthMotionPass() { }

	public XRDepthMotionPass(RenderPassEvent evt, Shader xrMotionVector) { }

	public void Dispose() { }

	private static DrawingSettings GetObjectMotionDrawingSettings(Camera camera) { }

	private void ImportXRMotionColorAndDepth(RenderGraph renderGraph, UniversalCameraData cameraData) { }

	private void InitObjectMotionRendererLists(ref PassData passData, ref CullingResults cullResults, RenderGraph renderGraph, Camera camera) { }

	private void InitPassData(ref PassData passData, UniversalCameraData cameraData) { }

	internal void Render(RenderGraph renderGraph, ContextContainer frameData) { }

	private void ResetMotionData() { }

	public void Update(ref UniversalCameraData cameraData) { }

}

