namespace Assets.Scripts.Simulation.Track.Spawners;

public class AlternateRoundMultiPathSplitter : Splitter
{
	protected AlternateRoundMultiPathSplitterModel model; //Field offset: 0x30
	private List<List`1<Path>> roundPaths; //Field offset: 0x38
	private List<List`1<Path>> activeRoundPaths; //Field offset: 0x40

	public AlternateRoundMultiPathSplitter(AlternateRoundMultiPathSplitterModel def) { }

	public virtual int GetNumberOfUniqueRounds() { }

	public virtual void Init(PathManager pathManager) { }

	public virtual Path[] PossibleRoutsForRound(int forRound) { }

	public virtual Path SpawnRout(int emissionIndex, int roundNumber, BloonModel bloonModel) { }

	public virtual void UpdateActivePaths() { }

}

