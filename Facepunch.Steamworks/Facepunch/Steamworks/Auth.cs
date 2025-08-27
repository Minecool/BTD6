namespace Facepunch.Steamworks;

public class Auth
{
	internal class Ticket : IDisposable
	{
		internal Client client; //Field offset: 0x10
		public Byte[] Data; //Field offset: 0x18
		public uint Handle; //Field offset: 0x20

		public Ticket() { }

		public void Cancel() { }

		public override void Dispose() { }

	}

	internal Client client; //Field offset: 0x10

	public Auth() { }

	public Ticket GetAuthSessionTicket() { }

}

