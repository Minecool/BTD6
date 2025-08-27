namespace Assets.Scripts.Models.Effects;

public class AssetPathModel : Model
{
	public PrefabReference assetPath; //Field offset: 0x30

	public AssetPathModel(string id, PrefabReference assetPath) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

