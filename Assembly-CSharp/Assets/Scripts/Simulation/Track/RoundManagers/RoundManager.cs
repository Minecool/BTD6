namespace Assets.Scripts.Simulation.Track.RoundManagers;

public abstract class RoundManager
{

	protected RoundManager() { }

	public abstract int GetMaxRound() { }

	public abstract BloonEmissionModel[] GetRoundEmissions(int round) { }

}

