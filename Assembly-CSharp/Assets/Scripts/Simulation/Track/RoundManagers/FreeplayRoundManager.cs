namespace Assets.Scripts.Simulation.Track.RoundManagers;

public class FreeplayRoundManager : RoundManager
{
	private GameModel model; //Field offset: 0x10
	private IList<FreeplayBloonGroupModel> freeplayGroups; //Field offset: 0x18
	private readonly SeededRandom seededRandom; //Field offset: 0x20
	private float budgetMultiplierThisRound; //Field offset: 0x28
	private int initialSeed; //Field offset: 0x2C
	private readonly List<BloonEmissionModel> bloonGroups; //Field offset: 0x30

	public FreeplayRoundManager(GameModel model) { }

	public virtual int GetMaxRound() { }

	public virtual BloonEmissionModel[] GetRoundEmissions(int roundArrayIndex) { }

	public void SetSeed(int seed) { }

}

