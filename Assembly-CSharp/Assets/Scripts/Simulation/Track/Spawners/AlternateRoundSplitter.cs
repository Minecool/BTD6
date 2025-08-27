namespace Assets.Scripts.Simulation.Track.Spawners;

public class AlternateRoundSplitter : Splitter
{

	public AlternateRoundSplitter(AlternateRoundSplitterModel def) { }

	public Path GetCurrentActivePath(int forRoundIndex) { }

	public virtual int GetNumberOfUniqueRounds() { }

	public virtual Path[] PossibleRoutsForRound(int forRound) { }

	public virtual Path SpawnRout(int emissionIndex, int roundNumber, BloonModel bloonModel) { }

}

