namespace NinjaKiwi.LiNK;

[DataContract]
[Obfuscation(Feature = "-rename", Exclude = False)]
public class Identity
{
	[DataMember(Name = "LiNKID")]
	public readonly string liNKID; //Field offset: 0x10
	[DataMember(Name = "SessionID")]
	public readonly string sessionID; //Field offset: 0x18
	[DataMember(Name = "DisplayName")]
	public readonly string displayName; //Field offset: 0x20
	[DataMember(Name = "SafeName")]
	public readonly string safeName; //Field offset: 0x28
	[DataMember(Name = "ShortCode")]
	public readonly string shortCode; //Field offset: 0x30
	[DataMember(Name = "Email")]
	public readonly string email; //Field offset: 0x38
	[DataMember(Name = "Age")]
	public readonly int age; //Field offset: 0x40
	[DataMember(Name = "Clan")]
	public readonly int clan; //Field offset: 0x44
	[DataMember(Name = "Country")]
	public readonly string country; //Field offset: 0x48
	[DataMember(Name = "Continent")]
	public readonly string continent; //Field offset: 0x50
	[DataMember(Name = "Avatar")]
	public readonly int avatar; //Field offset: 0x58
	[DataMember(Name = "Online")]
	public readonly bool online; //Field offset: 0x5C
	[DataMember(Name = "OnlineApp")]
	public readonly int onlineApp; //Field offset: 0x60
	[DataMember(Name = "ProvidersAvailable")]
	public readonly String[] providersAvailable; //Field offset: 0x68

	[JsonConstructor]
	public Identity(string liNKID, string sessionID, string displayName, string safeName, string shortCode, string email, int age, int clan, string country, string continent, int avatar, bool online, int onlineApp, String[] providersAvailable) { }

	public static Identity CreateNew(LoginResponseModel loginResponse) { }

	public static Identity CreateNew(UserModel user, string sessionID) { }

	public static Identity CreateNew(LiNKAccount liNKAccount) { }

	public bool Equals(Identity otherIdentity) { }

	private static bool ProviderArraysAreEqual(String[] a1, String[] a2) { }

}

