namespace Assets.Scripts.Models.Towers;

public class RepositionTowerCIData
{
	public PrefabReference placementZoneAssetId; //Field offset: 0x10
	public float placementZoneAssetScale; //Field offset: 0x18
	public ObjectId towerId; //Field offset: 0x1C
	public string helperMsg; //Field offset: 0x20
	public float restrictPlacementRadius; //Field offset: 0x28

	public RepositionTowerCIData() { }

}

