namespace Newtonsoft.Json.Linq;

[DefaultMember("Item")]
[Nullable(0)]
[NullableContext(1)]
public class JConstructor : JContainer
{
	[Nullable(2)]
	private string _name; //Field offset: 0x58
	private readonly List<JToken> _values; //Field offset: 0x60

	protected virtual IList<JToken> ChildrenTokens
	{
		 get { } //Length: 5
	}

	[Nullable(2)]
	public virtual JToken Item
	{
		 get { } //Length: 301
	}

	[Nullable(2)]
	public string Name
	{
		[NullableContext(2)]
		 get { } //Length: 5
	}

	public virtual JTokenType Type
	{
		 get { } //Length: 6
	}

	internal JConstructor(JConstructor other, JsonCloneSettings settings) { }

	public JConstructor(string name) { }

	internal virtual JToken CloneToken(JsonCloneSettings settings = null) { }

	protected virtual IList<JToken> get_ChildrenTokens() { }

	public virtual JToken get_Item(object key) { }

	[NullableContext(2)]
	public string get_Name() { }

	public virtual JTokenType get_Type() { }

	[NullableContext(2)]
	internal virtual int IndexOfItem(JToken item) { }

	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }

	public virtual void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

}

