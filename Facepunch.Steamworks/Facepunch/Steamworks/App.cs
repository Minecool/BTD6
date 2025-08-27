namespace Facepunch.Steamworks;

public class App : IDisposable
{
	internal sealed class DlcInstalledDelegate : MulticastDelegate
	{

		public DlcInstalledDelegate(object object, IntPtr method) { }

		public override void Invoke(uint appid) { }

	}

	internal Client client; //Field offset: 0x10
	[CompilerGenerated]
	private DlcInstalledDelegate OnDlcInstalled; //Field offset: 0x18

	internal App(Client c) { }

	public override void Dispose() { }

	private void DlcInstalled(DlcInstalled_t data) { }

}

