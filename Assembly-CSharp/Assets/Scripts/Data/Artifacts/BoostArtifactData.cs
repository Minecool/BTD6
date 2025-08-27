namespace Assets.Scripts.Data.Artifacts;

[CreateAssetMenu(menuName = "BTD6/Boost Artifact Data")]
public class BoostArtifactData : ArtifactDataBase
{
	[ExtendedDrawer]
	public BoostArtifactModel boostArtifactModel; //Field offset: 0x18

	public BoostArtifactData() { }

	public virtual Model ArtifactModel() { }

}

