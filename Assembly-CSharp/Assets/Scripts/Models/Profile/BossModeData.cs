namespace Assets.Scripts.Models.Profile;

public class BossModeData
{
	public int highestCompletedRound; //Field offset: 0x10
	public bool newBestRound; //Field offset: 0x14
	public int tierBeaten; //Field offset: 0x18
	public bool hasCompleted; //Field offset: 0x1C
	public bool seenCompletion; //Field offset: 0x1D

	public BossModeData() { }

}

