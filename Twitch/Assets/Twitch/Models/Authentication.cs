namespace Assets.Twitch.Models;

public class Authentication
{
	public string userId; //Field offset: 0x10
	public string userName; //Field offset: 0x18
	public DateTime expirationDate; //Field offset: 0x20
	public String[] scopes; //Field offset: 0x28
	public string token; //Field offset: 0x30
	public BroadcasterType broadcasterType; //Field offset: 0x38

	[JsonIgnore]
	public bool CanCreatePoll
	{
		 get { } //Length: 18
	}

	[JsonIgnore]
	public bool IsAffiliate
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public bool IsPartner
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public bool IsValid
	{
		 get { } //Length: 170
	}

	[JsonConstructor]
	public Authentication(string login, String[] scopes, string user_id, int expires_in, int broadcasterType = 0) { }

	public bool get_CanCreatePoll() { }

	public bool get_IsAffiliate() { }

	public bool get_IsPartner() { }

	public bool get_IsValid() { }

}

