namespace Assets.Scripts.Models.Towers.Props;

[Implementation(typeof(PropAssetChange), False, True, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PropAssetChangeModel : TowerBehaviorModel
{
	public KeyValuePair<String, Vector3>[] offsets; //Field offset: 0x30
	public Model[] behaviors; //Field offset: 0x38

	public PropAssetChangeModel(string name, KeyValuePair<String, Vector3>[] offsets, Model[] behaviors) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

