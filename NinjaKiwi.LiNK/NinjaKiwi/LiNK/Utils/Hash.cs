namespace NinjaKiwi.LiNK.Utils;

[Extension]
public static class Hash
{

	[Extension]
	private static Byte[] GetBytes(string input) { }

	[Extension]
	private static string HexHash(HashAlgorithm hashAlgorithm, Byte[] input) { }

	public static string HexHmacSha1(Byte[] key, Byte[] input) { }

	public static string HexHmacSha1(string key, string input) { }

	public static string HexMD5(Byte[] input) { }

	public static string HexMD5(string input) { }

	[Extension]
	public static string ToHexString(Byte[] hashBytes) { }

}

