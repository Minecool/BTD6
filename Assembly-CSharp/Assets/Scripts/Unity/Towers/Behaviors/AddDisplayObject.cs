namespace Assets.Scripts.Unity.Towers.Behaviors;

public class AddDisplayObject : CascadingItemProxy
{
	public AddDisplayObject parent; //Field offset: 0x88
	public DisplayCategory category; //Field offset: 0x90
	public string expCategory; //Field offset: 0x98
	public float scale; //Field offset: 0xA0
	public string expScale; //Field offset: 0xA8
	public float offsetX; //Field offset: 0xB0
	public string expOffsetX; //Field offset: 0xB8
	public float offsetY; //Field offset: 0xC0
	public string expOffsetY; //Field offset: 0xC8
	public float offsetZ; //Field offset: 0xD0
	public string expOffsetZ; //Field offset: 0xD8
	public bool ignoreRotation; //Field offset: 0xE0
	public string expIgnoreRotation; //Field offset: 0xE8
	public GameObject display; //Field offset: 0xF0
	public GameObject expDisplay; //Field offset: 0xF8

	public virtual Model Model
	{
		 get { } //Length: 331
	}

	public AddDisplayObject() { }

	public virtual Model get_Model() { }

}

