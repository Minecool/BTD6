namespace Assets.Scripts.Data.Behaviors.Resources;

[CreateAssetMenu(fileName = "AssetPath", menuName = "BTD6/Behaviors/Resources/AssetPath")]
public class AssetPath : EntityBehavior<AssetPathModel>
{
	public PrefabReference sound; //Field offset: 0x28

	public virtual AssetPathModel Def
	{
		 get { } //Length: 105
	}

	public AssetPath() { }

	public virtual AssetPathModel get_Def() { }

}

