namespace Assets.Scripts.Simulation.Track;

public class Splitter
{
	protected SplitterModel def; //Field offset: 0x10
	protected Path[] paths; //Field offset: 0x18
	protected Path[] activePaths; //Field offset: 0x20
	protected int nextPathIndex; //Field offset: 0x28

	public override float MaxDistUntilLeak
	{
		 get { } //Length: 237
	}

	public override float MaxDistUntilSpawn
	{
		 get { } //Length: 248
	}

	public override Path[] Paths
	{
		 get { } //Length: 5
	}

	public override SplitterModel SplitterModel
	{
		 get { } //Length: 5
	}

	public Splitter(SplitterModel def) { }

	public override float get_MaxDistUntilLeak() { }

	public override float get_MaxDistUntilSpawn() { }

	public override Path[] get_Paths() { }

	public override SplitterModel get_SplitterModel() { }

	public override int GetNumberOfUniqueRounds() { }

	public override void Init(PathManager pathManager) { }

	public void InsertNewPaths(String[] pathIds) { }

	public override Path[] PossibleRoutsForRound(int forRound) { }

	public void Reset() { }

	public override Path Rout(BloonModel bloonModel = null) { }

	public Path RoutToDestPath(Path destPath) { }

	public override Path SpawnRout(int emissionIndex, int roundNumber, BloonModel bloonModel) { }

	public override void UpdateActivePaths() { }

}

