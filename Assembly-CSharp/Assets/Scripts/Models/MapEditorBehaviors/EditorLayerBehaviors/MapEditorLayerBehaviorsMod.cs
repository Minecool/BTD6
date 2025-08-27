namespace Assets.Scripts.Models.MapEditorBehaviors.EditorLayerBehaviors;

public class MapEditorLayerBehaviorsMod
{
	internal class CustomJsonConverter : JsonConverter
	{

		public virtual bool CanWrite
		{
			 get { } //Length: 3
		}

		public CustomJsonConverter`1() { }

		public virtual bool CanConvert(Type t) { }

		public virtual bool get_CanWrite() { }

		public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	}

	[SerializeReference]
	public MapEditorLayerBehavior[] layerBehaviors; //Field offset: 0x10

	public MapEditorLayerBehaviorsMod(MapEditorLayerBehavior[] layerBehaviors = null) { }

	public MapEditorLayerBehaviorsMod Clone() { }

	public bool IsEqual(MapEditorLayerBehaviorsMod other) { }

}

