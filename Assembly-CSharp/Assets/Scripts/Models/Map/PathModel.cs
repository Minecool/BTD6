namespace Assets.Scripts.Models.Map;

public class PathModel : Model
{
	public string pathId; //Field offset: 0x30
	public PointInfo[] points; //Field offset: 0x38
	public bool isActive; //Field offset: 0x40
	public bool isHidden; //Field offset: 0x41
	public SplitterModel entryModel; //Field offset: 0x48
	public SplitterModel exitModel; //Field offset: 0x50
	public Vector3 spawnPoint; //Field offset: 0x58
	public Vector3 leakPoint; //Field offset: 0x64
	public bool isCustomPath; //Field offset: 0x70
	public float customPathWidth; //Field offset: 0x74
	public bool hideTrackArrows; //Field offset: 0x78

	public PathModel(string name, PointInfo[] points, bool isActive, bool isHidden, Vector3 spawnPoint, Vector3 leakPoint, SplitterModel entryModel, SplitterModel exitModel, bool isCustomPath = false, float customPathWidth = 0, bool hideTrackArrows = false) { }

	public virtual Model Clone() { }

	private PointInfo[] ClonePointInfo() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

