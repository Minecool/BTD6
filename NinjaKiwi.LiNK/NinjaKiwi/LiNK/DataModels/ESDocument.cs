namespace NinjaKiwi.LiNK.DataModels;

public class ESDocument
{
	public string ID; //Field offset: 0x10
	public long CreatedAt; //Field offset: 0x18
	public JObject Document; //Field offset: 0x20

	public ESDocument() { }

	public string GetDataURL(int appID, Environments environment, string index) { }

}

