namespace Assets.Scripts.Models.Map;

public struct PointInfo
{
	public string id; //Field offset: 0x0
	public Vector3 point; //Field offset: 0x8
	public float rotation; //Field offset: 0x14
	public float distance; //Field offset: 0x18
	public float bloonScale; //Field offset: 0x1C
	public float moabScale; //Field offset: 0x20
	public bool bloonsInvulnerable; //Field offset: 0x24
	public bool moabsInvulnerable; //Field offset: 0x25
	public float bloonSpeedMultiplier; //Field offset: 0x28

	public static bool HasExtraSettings(PointInfo p) { }

}

