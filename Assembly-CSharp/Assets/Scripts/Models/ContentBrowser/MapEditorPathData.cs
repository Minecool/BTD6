namespace Assets.Scripts.Models.ContentBrowser;

public class MapEditorPathData : MapEditorSplineData, ICloneable<MapEditorPathData>
{
	private const int kHiddenPathTextureId = 70014; //Field offset: 0x0
	public int pathWidth; //Field offset: 0x28
	public Boolean[] pathEnabledSequence; //Field offset: 0x30

	public float EstimatePathLength
	{
		 get { } //Length: 11
	}

	[JsonIgnore]
	public virtual bool IsHidden
	{
		 get { } //Length: 11
	}

	public bool IsPathLengthValid
	{
		 get { } //Length: 189
	}

	public bool IsValid
	{
		 get { } //Length: 478
	}

	public MapEditorPathData() { }

	public override MapEditorPathData Clone() { }

	public bool Compare(MapEditorPathData com) { }

	public MapEditorPathDataModel Def(int categoryLayerId) { }

	public float get_EstimatePathLength() { }

	public virtual bool get_IsHidden() { }

	public bool get_IsPathLengthValid() { }

	public bool get_IsValid() { }

	[OnDeserialized]
	private void OnDeserializedMethod(StreamingContext context) { }

}

