namespace Assets.Scripts.Models.ContentBrowser;

public class CustomMapModel : IEquatable<CustomMapModel>
{
	public int baseMapTextureId; //Field offset: 0x10
	public List<MapEditorPathData> PathData; //Field offset: 0x18
	public List<MapEditorAreaData> AreaData; //Field offset: 0x20
	public List<MapEditorTowerData> TowerData; //Field offset: 0x28
	public List<MapEditorPowerData> PowerData; //Field offset: 0x30
	public List<MapEditorPropData> PropData; //Field offset: 0x38
	public List<MapEditorStampData> StampData; //Field offset: 0x40
	public string musicTrack; //Field offset: 0x48
	public MapEditorLayerBehaviorsMod MapEditorLayerBehaviors; //Field offset: 0x50
	public MapEditorSettingsData MapEditorSettingsData; //Field offset: 0x58

	public CustomMapModel() { }

	public CustomMapModel Clone() { }

	public override bool Equals(CustomMapModel com) { }

	public CustomMapValidationResult GetValidationResults() { }

	public bool IsDefaultData() { }

}

