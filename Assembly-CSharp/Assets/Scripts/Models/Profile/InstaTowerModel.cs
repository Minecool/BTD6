namespace Assets.Scripts.Models.Profile;

public class InstaTowerModel
{
	internal class CustomJsonConverter : JsonConverter
	{

		public CustomJsonConverter() { }

		public virtual bool CanConvert(Type t) { }

		public virtual object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	}

	public Int32[] tiers; //Field offset: 0x10
	public KonFuze_NoShuffle quantity; //Field offset: 0x18
	public bool isNew; //Field offset: 0x20

	[JsonIgnore]
	public int Quantity
	{
		 get { } //Length: 118
		 set { } //Length: 169
	}

	public InstaTowerModel() { }

	private static InstaTowerModel FromInt32(int value) { }

	public int get_Quantity() { }

	public int GetHighestTier() { }

	public void set_Quantity(int value) { }

	public bool TiersEqual(Int32[] tiersComp) { }

	private static int ToInt32(InstaTowerModel info) { }

}

