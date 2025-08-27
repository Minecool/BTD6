namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(2)]
internal interface IGoogleLastKnownProductService
{

	public string LastKnownOldProductId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string LastKnownProductId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Nullable<GooglePlayProrationMode> LastKnownProrationMode
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string get_LastKnownOldProductId() { }

	public string get_LastKnownProductId() { }

	public Nullable<GooglePlayProrationMode> get_LastKnownProrationMode() { }

	public void set_LastKnownOldProductId(string value) { }

	public void set_LastKnownProductId(string value) { }

	public void set_LastKnownProrationMode(Nullable<GooglePlayProrationMode> value) { }

}

