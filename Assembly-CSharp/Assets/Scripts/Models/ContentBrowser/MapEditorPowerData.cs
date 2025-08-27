namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorPowerData : ICloneable<MapEditorPowerData>
{
	public string id; //Field offset: 0x10
	public PositionalData positionalData; //Field offset: 0x18

	public MapEditorPowerData() { }

	[CompilerGenerated]
	private bool <Def>b__4_0(PowerModel x) { }

	public override MapEditorPowerData Clone() { }

	public bool Compare(MapEditorPowerData com) { }

	public MapEditorPowerDataModel Def() { }

}

