namespace Assets.Scripts.Unity.Map;

public class Path : MonoBehaviour
{
	public bool isActive; //Field offset: 0x20
	public bool isHidden; //Field offset: 0x21
	public bool hideTrackArrows; //Field offset: 0x22
	public Splitter entrySplitter; //Field offset: 0x28
	public Splitter exitSplitter; //Field offset: 0x30
	private PathModel def; //Field offset: 0x38

	public PathModel Def
	{
		 get { } //Length: 1566
	}

	public Path() { }

	public PathModel get_Def() { }

	public void ReverseAllPoints() { }

}

