//Type is in global namespace

public class UniWebViewNativeResultPayload
{
	public const string ExtraFailingURLKey = "failingURL"; //Field offset: 0x0
	public string identifier; //Field offset: 0x10
	public string resultCode; //Field offset: 0x18
	public string data; //Field offset: 0x20
	public string extra; //Field offset: 0x28

	public Dictionary<String, Object> Extra
	{
		 get { } //Length: 160
	}

	public UniWebViewNativeResultPayload() { }

	public Dictionary<String, Object> get_Extra() { }

}

