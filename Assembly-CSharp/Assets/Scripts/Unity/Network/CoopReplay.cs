namespace Assets.Scripts.Unity.Network;

public class CoopReplay : Replay
{
	public byte ownPlayerNumber; //Field offset: 0x28
	public byte numPlayers; //Field offset: 0x29
	public Dictionary<Int32, DesyncCheck> desyncChecks; //Field offset: 0x30
	private List<CoopPlayerInfo> otherPlayersList; //Field offset: 0x38
	private List<CoopPlayerInfo> allPlayersList; //Field offset: 0x40

	public IEnumerable<CoopPlayerInfo> allPlayers
	{
		 get { } //Length: 5
		 set { } //Length: 74
	}

	public IEnumerable<CoopPlayerInfo> otherPlayers
	{
		 get { } //Length: 5
		 set { } //Length: 74
	}

	public CoopReplay(int randomSeed, byte ownPlayerNumber, byte numPlayers, IEnumerable<CoopPlayerInfo> otherPlayers, IEnumerable<CoopPlayerInfo> allPlayers) { }

	public IEnumerable<CoopPlayerInfo> get_allPlayers() { }

	public IEnumerable<CoopPlayerInfo> get_otherPlayers() { }

	public virtual string Serialize() { }

	public void set_allPlayers(IEnumerable<CoopPlayerInfo> value) { }

	public void set_otherPlayers(IEnumerable<CoopPlayerInfo> value) { }

}

