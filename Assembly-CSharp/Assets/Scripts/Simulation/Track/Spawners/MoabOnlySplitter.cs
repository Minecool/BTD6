namespace Assets.Scripts.Simulation.Track.Spawners;

public class MoabOnlySplitter : Splitter
{
	private MoabOnlySplitterModel moModel; //Field offset: 0x30
	private Path[] bloonPaths; //Field offset: 0x38
	private Path[] moabPaths; //Field offset: 0x40
	private int nextBloonPathIndex; //Field offset: 0x48
	private int nextMoabPathIndex; //Field offset: 0x4C

	public MoabOnlySplitter(MoabOnlySplitterModel def) { }

	public virtual Path Rout(BloonModel bloonModel = null) { }

	public virtual Path SpawnRout(int emissionIndex, int roundNumber, BloonModel bloonModel) { }

	public virtual void UpdateActivePaths() { }

}

