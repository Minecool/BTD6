namespace Facepunch.Steamworks;

public class MicroTransactions : IDisposable
{
	internal sealed class AuthorizationResponse : MulticastDelegate
	{

		public AuthorizationResponse(object object, IntPtr method) { }

		public override void Invoke(bool authorized, int appId, ulong orderId) { }

	}

	internal Client client; //Field offset: 0x10
	[CompilerGenerated]
	private AuthorizationResponse OnAuthorizationResponse; //Field offset: 0x18

	public event AuthorizationResponse OnAuthorizationResponse
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	internal MicroTransactions(Client c) { }

	[CompilerGenerated]
	public void add_OnAuthorizationResponse(AuthorizationResponse value) { }

	public override void Dispose() { }

	private void onMicroTxnAuthorizationResponse(MicroTxnAuthorizationResponse_t arg1) { }

	[CompilerGenerated]
	public void remove_OnAuthorizationResponse(AuthorizationResponse value) { }

}

