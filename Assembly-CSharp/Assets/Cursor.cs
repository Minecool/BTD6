namespace Assets;

public class Cursor : MonoBehaviour
{
	internal class CursorSprites
	{
		public Texture2D textureUp; //Field offset: 0x10
		public Texture2D textureDown; //Field offset: 0x18
		public Vector2 hotspot; //Field offset: 0x20

		public CursorSprites() { }

	}

	public static Cursor instance; //Field offset: 0x0
	public CursorSprites hardware; //Field offset: 0x20
	public CursorSprites softwareLarge; //Field offset: 0x28
	public CursorSprites softwareXLarge; //Field offset: 0x30
	public CursorSprites hardwareLarge; //Field offset: 0x38
	public CursorSprites hardwareXLarge; //Field offset: 0x40
	private bool showingCursorDown; //Field offset: 0x48
	private CursorSprites activeConfig; //Field offset: 0x50
	private CursorMode cursorMode; //Field offset: 0x58

	public CursorConfig Config
	{
		 get { } //Length: 50
		 set { } //Length: 204
	}

	public Cursor() { }

	public CursorConfig get_Config() { }

	private bool GetCursorDown() { }

	public void set_Config(CursorConfig value) { }

	public void Start() { }

	private void Update() { }

	private void UpdateSprites(CursorConfig value) { }

}

