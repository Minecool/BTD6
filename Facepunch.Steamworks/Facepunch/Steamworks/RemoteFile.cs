namespace Facepunch.Steamworks;

public class RemoteFile
{
	internal readonly RemoteStorage remoteStorage; //Field offset: 0x10
	private readonly bool _isUgc; //Field offset: 0x18
	private string _fileName; //Field offset: 0x20
	private int _sizeInBytes; //Field offset: 0x28
	private long _timestamp; //Field offset: 0x30
	private UGCHandle_t _handle; //Field offset: 0x38
	private ulong _ownerId; //Field offset: 0x40
	private bool _isDownloading; //Field offset: 0x48
	private Byte[] _downloadedData; //Field offset: 0x50
	[CompilerGenerated]
	private bool <Exists>k__BackingField; //Field offset: 0x58

}

