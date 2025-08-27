//Type is in global namespace

public class DanceFloor : MonoBehaviour
{
	public int uvAnimationTileX; //Field offset: 0x20
	public int uvAnimationTileY; //Field offset: 0x24
	private float framesPerSecond; //Field offset: 0x28
	private int currentTimeInt; //Field offset: 0x2C
	private int randomNumX; //Field offset: 0x30
	private int randomNumY; //Field offset: 0x34
	private Vector2 offset; //Field offset: 0x38
	private Renderer _myRenderer; //Field offset: 0x40

	public DanceFloor() { }

	private void Start() { }

	private void Update() { }

}

