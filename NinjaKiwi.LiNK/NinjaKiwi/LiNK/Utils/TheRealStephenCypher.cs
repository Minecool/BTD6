namespace NinjaKiwi.LiNK.Utils;

[Obfuscation(Feature = "-ctrl flow", Exclude = False)]
internal static class TheRealStephenCypher
{
	private const string LABEL = "DGDATA"; //Field offset: 0x0
	private static readonly Byte[] LABEL_DATA; //Field offset: 0x0
	private const int LABEL_LENGTH = 6; //Field offset: 0x0
	private const int CRC_LENGTH = 8; //Field offset: 0x0
	private const int HEADER_LENGTH = 14; //Field offset: 0x0
	private const uint CRC_KEY = 3988292384; //Field offset: 0x0
	private const int CRC_KEY_INT = -306674912; //Field offset: 0x0

	private static TheRealStephenCypher() { }

	public static bool CanDecrypt(Byte[] possiblyEncrypted) { }

	public static bool CanDecrypt(string possiblyEncrypted) { }

	private static void Check(string header, string content) { }

	public static string Decrypt(string encrypted, bool checkCrc = true) { }

	public static string Decrypt(Byte[] bytes, bool checkCrc = true) { }

	public static Byte[] Encrypt(string plaintext) { }

	public static Byte[] Encrypt(Byte[] plaintext) { }

	private static string GetHexCrc(Byte[] bytes) { }

}

