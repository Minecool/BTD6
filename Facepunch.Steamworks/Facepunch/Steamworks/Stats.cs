namespace Facepunch.Steamworks;

public class Stats : IDisposable
{
	internal Client client; //Field offset: 0x10

	internal Stats(Client c) { }

	public override void Dispose() { }

	public bool Set(string name, int value, bool store = true) { }

	public bool StoreStats() { }

	public void UpdateStats() { }

}

