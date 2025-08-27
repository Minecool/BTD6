namespace NinjaKiwi.LiNK.Client;

public class PlayerServiceConfiguration
{
	public int appID; //Field offset: 0x10
	public int skuID; //Field offset: 0x14
	public string skuSignature; //Field offset: 0x18
	public string playerSaveFileName; //Field offset: 0x20
	public int playSessionChecksPerBackup; //Field offset: 0x28
	public int autoBackupPeriodSeconds; //Field offset: 0x2C
	public int timeoutSeconds; //Field offset: 0x30
	public Environments environment; //Field offset: 0x34
	public bool copySessionIDToAPI; //Field offset: 0x38
	public JsonSerializerSettings jsonSettingsForLiNKHttp; //Field offset: 0x40
	public JsonSerializerSettings jsonSettingsForPlayerDataAndFileStorage; //Field offset: 0x48
	public PasswordGenerator passwordGeneratorForPlayerSaves; //Field offset: 0x50
	public int passwordVersionForPlayerSaves; //Field offset: 0x58
	public string playerDataRootPath; //Field offset: 0x60
	public Strategy storageStrategy; //Field offset: 0x68
	public IStorage identityStorageOverride; //Field offset: 0x70
	public IStorage dataStorageOverride; //Field offset: 0x78
	public bool ignoreUnreadableFiles; //Field offset: 0x80
	public string noLiNKIDOverride; //Field offset: 0x88
	public string rawHashForV2ProviderConfirmations; //Field offset: 0x90
	public int dataMigrationSaveCountThreshold; //Field offset: 0x98
	public int dataMigrationSupportEarliestVersion; //Field offset: 0x9C
	public HttpRequestFactory customHttpRequestFactory; //Field offset: 0xA0
	public Func<Task`1<String>> getSessionTicket; //Field offset: 0xA8

	public PlayerServiceConfiguration() { }

}

