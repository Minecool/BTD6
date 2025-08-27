namespace Assets.Scripts.Data;

[CreateAssetMenu(menuName = "BTD6/Track Arrow Data")]
public class TrackArrowData : ScriptableObject
{
	public PrefabReference prefab; //Field offset: 0x18
	public float speed; //Field offset: 0x20
	public float firstCoveragePercent; //Field offset: 0x24
	public float secondCoveragePercent; //Field offset: 0x28
	public float enterAndExitBuffer; //Field offset: 0x2C
	public float rate; //Field offset: 0x30
	public float subRate; //Field offset: 0x34
	public int numOfArrows; //Field offset: 0x38
	public Color firstColorStart; //Field offset: 0x3C
	public Color firstColorEnd; //Field offset: 0x4C
	public Color secondColorStart; //Field offset: 0x5C
	public Color secondColorEnd; //Field offset: 0x6C

	public TrackArrowData() { }

	public TrackArrowModel Def() { }

}

