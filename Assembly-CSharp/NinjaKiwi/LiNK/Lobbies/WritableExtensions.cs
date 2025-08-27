namespace NinjaKiwi.LiNK.Lobbies;

[Extension]
internal static class WritableExtensions
{
	private class ByteLayer : Layer<Byte>
	{

		public ByteLayer(Writable content, byte value) { }

		public virtual void WriteTo(BinaryWriter output) { }

	}

	private class IntLayer : Layer<Int32>
	{

		public IntLayer(Writable content, int value) { }

		public virtual void WriteTo(BinaryWriter output) { }

	}

	private abstract class Layer : Writable, Writable
	{
		protected readonly T Value; //Field offset: 0x0
		protected readonly Writable Content; //Field offset: 0x0

		protected Layer`1(Writable content, T value) { }

		public abstract void WriteTo(BinaryWriter output) { }

	}


	[Extension]
	public static Writable Wrap(Writable content, byte value) { }

	[Extension]
	public static Writable Wrap(Writable content, int value) { }

}

