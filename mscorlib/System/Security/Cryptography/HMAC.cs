namespace System.Security.Cryptography;

[ComVisible(True)]
public abstract class HMAC : KeyedHashAlgorithm
{
	private int blockSizeValue; //Field offset: 0x30
	internal string m_hashName; //Field offset: 0x38
	internal HashAlgorithm m_hash1; //Field offset: 0x40
	internal HashAlgorithm m_hash2; //Field offset: 0x48
	private Byte[] m_inner; //Field offset: 0x50
	private Byte[] m_outer; //Field offset: 0x58
	private bool m_hashing; //Field offset: 0x60

	protected int BlockSizeValue
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string HashName
	{
		 get { } //Length: 5
		 set { } //Length: 152
	}

	public virtual Byte[] Key
	{
		 get { } //Length: 119
		 set { } //Length: 127
	}

	protected HMAC() { }

	public static HMAC Create() { }

	public static HMAC Create(string algorithmName) { }

	protected virtual void Dispose(bool disposing) { }

	protected int get_BlockSizeValue() { }

	public string get_HashName() { }

	public virtual Byte[] get_Key() { }

	internal static HashAlgorithm GetHashAlgorithmWithFipsFallback(Func<HashAlgorithm> createStandardHashAlgorithmCallback, Func<HashAlgorithm> createFipsHashAlgorithmCallback) { }

	protected virtual void HashCore(Byte[] rgb, int ib, int cb) { }

	protected virtual Byte[] HashFinal() { }

	public virtual void Initialize() { }

	internal void InitializeKey(Byte[] key) { }

	protected void set_BlockSizeValue(int value) { }

	public void set_HashName(string value) { }

	public virtual void set_Key(Byte[] value) { }

	private void UpdateIOPadBuffers() { }

}

