namespace Assets.Scripts.Simulation.Track;

public class GoldenBloonManager
{
	private List<Int32> spawnOnRounds; //Field offset: 0x10
	private int victoryRound; //Field offset: 0x18
	public int goldenBloonsPopped; //Field offset: 0x1C
	private readonly Int32[] mmValuesPerDiff; //Field offset: 0x20
	private Simulation sim; //Field offset: 0x28

	public GoldenBloonManager() { }

	private void BloonDegrade(Bloon bloon, DamageResult damageResult) { }

	private void BloonDestroyed(RootObject obj) { }

	private void BloonLeaked(Bloon bloon) { }

	public void BloonSpawned(Bloon bloon) { }

	public int GetMMReward(int bloonSpawnRound) { }

	private string GoldenBloonIdForIndex(int index) { }

	public void Init(int victoryRound, Simulation sim) { }

	public void OnRoundStart(int spawnedRound, RoundData roundData) { }

	private void SetBloonHealth(Bloon bloon) { }

}

