namespace Assets.Scripts.Data.Artifacts;

[CreateAssetMenu(menuName = "BTD6/Item Artifact Data")]
public class ItemArtifactData : ArtifactDataBase
{
	[ExtendedDrawer]
	public ItemArtifactModel itemArtifactModel; //Field offset: 0x18

	public ItemArtifactData() { }

	public virtual Model ArtifactModel() { }

}

