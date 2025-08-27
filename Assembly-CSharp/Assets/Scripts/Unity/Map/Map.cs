namespace Assets.Scripts.Unity.Map;

public class Map : MonoBehaviour
{
	public bool drawMapBorder; //Field offset: 0x20
	public float mapBorderThickness; //Field offset: 0x24
	public Color mapBorderColor; //Field offset: 0x28
	public Color mapBorderOutlineColor; //Field offset: 0x38
	public bool drawConsoleBorder; //Field offset: 0x48
	public float consoleBorderThickness; //Field offset: 0x4C
	public Color consoleBorderColor; //Field offset: 0x50
	public Color consoleBorderOutlineColor; //Field offset: 0x60
	public float overrideBossSpawnDistance; //Field offset: 0x70
	public float overrideTrackArrowDistance; //Field offset: 0x74
	public int overrideTrackArrowAmount; //Field offset: 0x78

	public Map() { }

	private void Start() { }

}

