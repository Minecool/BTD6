namespace Assets.Scripts.Unity.Bridge;

public class Peer
{
	public byte playerNumber; //Field offset: 0x10
	public int lastKnownStep; //Field offset: 0x14
	public int stepSignoff; //Field offset: 0x18
	public int updatedAt; //Field offset: 0x1C
	public CoopPlayerInfo coopPlayerInfo; //Field offset: 0x20
	public bool isRejoining; //Field offset: 0x28
	public bool autoPlay; //Field offset: 0x29
	public bool quit; //Field offset: 0x2A
	public bool isOutOfSync; //Field offset: 0x2B
	public DateTime rejoinWaitStart; //Field offset: 0x30

	[JsonIgnore]
	public bool IsIngame
	{
		 get { } //Length: 45
	}

	public Peer(CoopPlayerInfo coopPlayerInfo) { }

	public bool get_IsIngame() { }

}

