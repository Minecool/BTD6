namespace NinjaKiwi.LiNK.Transfer;

internal class Authority
{
	private static readonly RandomNumberGenerator rng; //Field offset: 0x0
	private static readonly Byte[] nonceBuffer; //Field offset: 0x8
	public readonly string noLiNKID; //Field offset: 0x10
	public readonly int appID; //Field offset: 0x18
	public readonly int skuID; //Field offset: 0x1C
	public readonly string skuSignature; //Field offset: 0x20
	public Session session; //Field offset: 0x28

	private static Authority() { }

	public Authority(Session session, string noLiNKID, int appID, int skuID, string skuSignature) { }

	public Payload Authorise(string data) { }

	private static string Generate64BitNonce() { }

	public bool Validate(Response response) { }

}

