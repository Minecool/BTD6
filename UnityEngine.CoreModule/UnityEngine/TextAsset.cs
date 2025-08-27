namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : object
{
	public enum CreateOptions
	{
		None = 0,
		CreateNativeObject = 1,
	}

	private static class EncodingUtility
	{
		internal static readonly KeyValuePair<Byte[], Encoding>[] encodingLookup; //Field offset: 0x0
		internal static readonly Encoding targetEncoding; //Field offset: 0x8

		private static EncodingUtility() { }

	}


	public Byte[] bytes
	{
		 get { } //Length: 51
	}

	public long dataSize
	{
		 get { } //Length: 51
	}

	public string text
	{
		 get { } //Length: 129
	}

	public TextAsset() { }

	public TextAsset(string text) { }

	internal TextAsset(CreateOptions options, string text) { }

	internal static string DecodeString(Byte[] bytes) { }

	public Byte[] get_bytes() { }

	public long get_dataSize() { }

	public string get_text() { }

	public NativeArray<T> GetData() { }

	private IntPtr GetDataPtr() { }

	private long GetDataSize() { }

	internal string GetPreview(int maxChars) { }

	private Byte[] GetPreviewBytes(int maxByteCount) { }

	private static void Internal_CreateInstance(TextAsset self, string text) { }

	public virtual string ToString() { }

}

