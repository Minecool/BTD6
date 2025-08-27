namespace NinjaKiwi.GUTS.Models.Endpoints;

public class DailyStoreGetResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private DailyStoreInfo <DailyStoreInfo>k__BackingField; //Field offset: 0x18

	public DailyStoreInfo DailyStoreInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 19
	}

	public DailyStoreGetResponse() { }

	[CompilerGenerated]
	public DailyStoreInfo get_DailyStoreInfo() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_DailyStoreInfo(DailyStoreInfo value) { }

}

