namespace NinjaKiwi.LiNK.DataModels;

public class UserModel
{
	[DataContract]
	private class UserResponse
	{
		[DataMember(Name = "user")]
		public UserModel user; //Field offset: 0x10

		public UserResponse() { }

	}

	public string nkapiID; //Field offset: 0x10
	public string displayName; //Field offset: 0x18
	public string safeName; //Field offset: 0x20
	public string email; //Field offset: 0x28
	public int age; //Field offset: 0x30
	public int clan; //Field offset: 0x34
	public string country; //Field offset: 0x38
	public string continent; //Field offset: 0x40
	public int avatar; //Field offset: 0x48
	public bool online; //Field offset: 0x4C
	public int onlineApp; //Field offset: 0x50
	public String[] providersAvailable; //Field offset: 0x58
	public int access; //Field offset: 0x60
	public string shortcode; //Field offset: 0x68
	public string xboxID; //Field offset: 0x70
	public string psID; //Field offset: 0x78

	public UserModel() { }

	public static UserModel Deserialise(string json) { }

}

