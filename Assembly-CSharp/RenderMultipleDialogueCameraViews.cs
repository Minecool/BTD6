//Type is in global namespace

public class RenderMultipleDialogueCameraViews : MonoBehaviour
{
	[CompilerGenerated]
	private Camera <PreviewCamera>k__BackingField; //Field offset: 0x20
	public GameObject assets; //Field offset: 0x28
	public RendererToUI rtui1; //Field offset: 0x30
	public RendererToUI rtui2; //Field offset: 0x38
	private RenderTexture rt1; //Field offset: 0x40
	private RenderTexture rt2; //Field offset: 0x48
	public GameObject left; //Field offset: 0x50
	public GameObject right; //Field offset: 0x58
	public int renderTextureWidth; //Field offset: 0x60
	public int renderTextureHeight; //Field offset: 0x64
	public int renderTextureDepth; //Field offset: 0x68
	public float cameraFov; //Field offset: 0x6C

	public private Camera PreviewCamera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public RenderMultipleDialogueCameraViews() { }

	public void AttachViewLeft(GameObject view) { }

	public void AttachViewRight(GameObject view) { }

	[CompilerGenerated]
	public Camera get_PreviewCamera() { }

	public void Initialise(Camera previewCamera) { }

	public void Release() { }

	[CompilerGenerated]
	private void set_PreviewCamera(Camera value) { }

	private void Update() { }

}

