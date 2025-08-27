namespace Assets.Scripts.Unity.Network;

public static class MessageEncoders
{
	internal interface IMessageEncoder
	{

	}

	internal class MessageEncoder : IMessageEncoder
	{
		protected Action<BinaryWriter, T> encode; //Field offset: 0x0
		protected Func<BinaryReader, T> decode; //Field offset: 0x0

		public MessageEncoder`1(Action<BinaryWriter, T> encode, Func<BinaryReader, T> decode) { }

		public T Decode(BinaryReader br) { }

		public void Encode(BinaryWriter bw, T o) { }

	}

	public static readonly Dictionary<MessageCode, IMessageEncoder> encoders; //Field offset: 0x0
	private const int kBufferSize = 2048; //Field offset: 0x0

	private static MessageEncoders() { }

	private static MessageEncoder<T> BinaryEncoder(Action<BinaryWriter, T> encode, Func<BinaryReader, T> decode) { }

	private static MessageEncoder<T> CompressedJsonEncoder() { }

	public static T DecodeEmpty(BinaryReader reader) { }

	public static T DecompressAndDecodeJson(BinaryReader reader) { }

	private static MessageEncoder<T> EmptyEncoder() { }

	public static void EncodeAndCompressJson(BinaryWriter writer, T obj) { }

	public static void EncodeEmpty(BinaryWriter writer, T obj) { }

}

