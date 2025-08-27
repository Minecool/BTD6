namespace Assets.Scripts.Simulation.Track.Spawners;

public class BloonTagOnlySplitter : Splitter
{
	private BloonTagOnlySplitterModel moModel; //Field offset: 0x30
	private Path[] nonTagPaths; //Field offset: 0x38
	private Path[] tagPaths; //Field offset: 0x40
	private int nextNonTagPathIndex; //Field offset: 0x48
	private int nextTagPathIndex; //Field offset: 0x4C
	private String[] tagsForPaths; //Field offset: 0x50

	public BloonTagOnlySplitter(BloonTagOnlySplitterModel def) { }

	public virtual Path Rout(BloonModel bloonModel = null) { }

	public virtual Path SpawnRout(int emissionIndex, int roundNumber, BloonModel bloonModel) { }

	public virtual void UpdateActivePaths() { }

}

