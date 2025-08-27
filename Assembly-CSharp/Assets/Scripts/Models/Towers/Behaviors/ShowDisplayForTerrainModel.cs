namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ShowDisplayForTerrain), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ShowDisplayForTerrainModel : TowerBehaviorModel
{
	public AreaType areaType; //Field offset: 0x30
	public string displayAssetName; //Field offset: 0x38
	public float scaleOn; //Field offset: 0x40
	public float scaleOff; //Field offset: 0x44

	public ShowDisplayForTerrainModel(string name, AreaType areaType, string displayAssetName, float scaleOn, float scaleOff) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

