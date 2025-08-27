namespace Assets.Scripts.Models.MapEditorBehaviors;

public class CustomMapDataModel
{
	public MapEditorPropDataModel[] propDataModel; //Field offset: 0x10
	public MapEditorTowerDataModel[] towersDataModel; //Field offset: 0x18
	public MapEditorPowerDataModel[] powersDataModel; //Field offset: 0x20
	public MapEditorPathDataModel[] pathDataModel; //Field offset: 0x28
	public MapEditorAreaDataModel[] areaDataModel; //Field offset: 0x30
	public MapEditorStampDataModel[] stampDataModel; //Field offset: 0x38
	public MapEditorLayerBehaviorModel[] layerBehaviors; //Field offset: 0x40

	public CustomMapDataModel() { }

	public CustomMapDataModel(MapEditorPropDataModel[] propDataModel, MapEditorTowerDataModel[] towersDataModel, MapEditorPowerDataModel[] powersDataModel, MapEditorPathDataModel[] pathDataModel, MapEditorAreaDataModel[] areaDataModel, MapEditorStampDataModel[] stampDataModel, MapEditorLayerBehaviorModel[] layerBehaviors) { }

	public void AddChild(GameModel gameModel) { }

	public CustomMapDataModel Clone() { }

}

