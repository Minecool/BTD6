namespace System.Runtime.Serialization;

[AttributeUsage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute
{
	private string name; //Field offset: 0x10
	private bool isNameSetExplicitly; //Field offset: 0x18
	private int order; //Field offset: 0x1C
	private bool isRequired; //Field offset: 0x20
	private bool emitDefaultValue; //Field offset: 0x21

	public bool EmitDefaultValue
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool IsRequired
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 9
	}

	public int Order
	{
		 get { } //Length: 4
	}

	public DataMemberAttribute() { }

	public bool get_EmitDefaultValue() { }

	public bool get_IsRequired() { }

	public string get_Name() { }

	public int get_Order() { }

	public void set_EmitDefaultValue(bool value) { }

	public void set_IsRequired(bool value) { }

	public void set_Name(string value) { }

}

