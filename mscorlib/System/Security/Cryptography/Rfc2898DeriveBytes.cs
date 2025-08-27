namespace System.Security.Cryptography;

public class Rfc2898DeriveBytes : DeriveBytes
{
	private const int MinimumSaltSize = 8; //Field offset: 0x0
	private readonly Byte[] _password; //Field offset: 0x10
	private Byte[] _salt; //Field offset: 0x18
	private uint _iterations; //Field offset: 0x20
	private HMAC _hmac; //Field offset: 0x28
	private int _blockSize; //Field offset: 0x30
	private Byte[] _buffer; //Field offset: 0x38
	private uint _block; //Field offset: 0x40
	private int _startIndex; //Field offset: 0x44
	private int _endIndex; //Field offset: 0x48
	[CompilerGenerated]
	private readonly HashAlgorithmName <HashAlgorithm>k__BackingField; //Field offset: 0x50

	public HashAlgorithmName HashAlgorithm
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int IterationCount
	{
		 get { } //Length: 4
		 set { } //Length: 132
	}

	public Byte[] Salt
	{
		 get { } //Length: 11
		 set { } //Length: 281
	}

	public Rfc2898DeriveBytes(Byte[] password, Byte[] salt, int iterations) { }

	public Rfc2898DeriveBytes(Byte[] password, Byte[] salt, int iterations, HashAlgorithmName hashAlgorithm) { }

	public Rfc2898DeriveBytes(string password, Byte[] salt) { }

	public Rfc2898DeriveBytes(string password, Byte[] salt, int iterations) { }

	public Rfc2898DeriveBytes(string password, Byte[] salt, int iterations, HashAlgorithmName hashAlgorithm) { }

	public Rfc2898DeriveBytes(string password, int saltSize) { }

	public Rfc2898DeriveBytes(string password, int saltSize, int iterations) { }

	public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm) { }

	public Byte[] CryptDeriveKey(string algname, string alghashname, int keySize, Byte[] rgbIV) { }

	protected virtual void Dispose(bool disposing) { }

	private Byte[] Func() { }

	[CompilerGenerated]
	public HashAlgorithmName get_HashAlgorithm() { }

	public int get_IterationCount() { }

	public Byte[] get_Salt() { }

	public virtual Byte[] GetBytes(int cb) { }

	private void Initialize() { }

	private HMAC OpenHmac() { }

	public virtual void Reset() { }

	public void set_IterationCount(int value) { }

	public void set_Salt(Byte[] value) { }

}

