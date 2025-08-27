namespace Assets.Scripts.Unity.Map;

public class ScrollTexture : ScrollTextureBase
{
	private static readonly int _ScrollX; //Field offset: 0x0
	private static readonly int _ScrollY; //Field offset: 0x4
	private static readonly int _FlipX; //Field offset: 0x8
	private static readonly int _FlipY; //Field offset: 0xC
	[SerializeField]
	private float rate; //Field offset: 0x28
	[SerializeField]
	private float min; //Field offset: 0x2C
	[SerializeField]
	private float max; //Field offset: 0x30
	[SerializeField]
	private bool horizontal; //Field offset: 0x34
	[SerializeField]
	private bool flipUVX; //Field offset: 0x35
	[SerializeField]
	private bool flipUVY; //Field offset: 0x36
	private Material material; //Field offset: 0x38
	private float currentScroll; //Field offset: 0x40
	private float finalRate; //Field offset: 0x44

	protected virtual float BaseRate
	{
		 get { } //Length: 6
	}

	private static ScrollTexture() { }

	public ScrollTexture() { }

	private void Awake() { }

	public virtual void FlipX(bool val) { }

	public virtual void FlipY(bool val) { }

	protected virtual float get_BaseRate() { }

	protected virtual void OnRateUpdated(float _rate) { }

	private void Start() { }

	private void Update() { }

}

