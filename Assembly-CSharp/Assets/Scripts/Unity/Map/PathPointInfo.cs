namespace Assets.Scripts.Unity.Map;

public class PathPointInfo : MonoBehaviour
{
	public string id; //Field offset: 0x20
	public float bloonScale; //Field offset: 0x28
	public float moabScale; //Field offset: 0x2C
	public bool bloonsInvulnerable; //Field offset: 0x30
	public bool moabsInvulnerable; //Field offset: 0x31
	public float bloonSpeedMultiplier; //Field offset: 0x34

	public PathPointInfo() { }

}

