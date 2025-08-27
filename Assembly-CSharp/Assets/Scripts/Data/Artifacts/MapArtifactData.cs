namespace Assets.Scripts.Data.Artifacts;

[CreateAssetMenu(menuName = "BTD6/Map Artifact Data")]
public class MapArtifactData : ArtifactDataBase
{
	[ExtendedDrawer]
	public MapArtifactModel mapArtifactModel; //Field offset: 0x18

	public MapArtifactData() { }

	public virtual Model ArtifactModel() { }

}

