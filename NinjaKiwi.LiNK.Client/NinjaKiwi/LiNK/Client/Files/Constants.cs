namespace NinjaKiwi.LiNK.Client.Files;

internal static class Constants
{
	public const int PBKDF2_ITERATIONS = 10; //Field offset: 0x0
	public const int PBKDF2_SALT_BITS = 192; //Field offset: 0x0
	public const int AES_KEY_BITS = 128; //Field offset: 0x0
	public const int AES_BLOCK_BITS = 128; //Field offset: 0x0
	public const CipherMode AES_MODE = 1; //Field offset: 0x0
	public const CompressionLevel ZLIB_LEVEL = 3; //Field offset: 0x0
	public const int ZLIB_BUFFER_BYTES = 2048; //Field offset: 0x0

	public static Aes CreateAes(string password, out Byte[] salt) { }

	public static Aes CreateAes(string password, Byte[] salt) { }

	private static Aes CreateAes(Rfc2898DeriveBytes pbkdf) { }

	public static Byte[] ReadSalt(BinaryReader binaryReader) { }

}

