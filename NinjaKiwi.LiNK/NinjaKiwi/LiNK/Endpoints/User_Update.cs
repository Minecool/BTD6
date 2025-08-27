namespace NinjaKiwi.LiNK.Endpoints;

public class User_Update : Endpoint<UserModel>
{

	internal User_Update(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(Nullable<Int32> age = null, Nullable<Int32> avatar = null, string gender = null, string displayName = null, string continent = null, string country = null) { }

	protected virtual UserModel Receive(string json) { }

}

