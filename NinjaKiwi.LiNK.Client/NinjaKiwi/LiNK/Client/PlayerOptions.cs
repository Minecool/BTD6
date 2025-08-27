namespace NinjaKiwi.LiNK.Client;

public class PlayerOptions
{
	public static readonly JsonSerializerSettings defaultJsonSettingsForPlayerDataAndFileStorage; //Field offset: 0x0
	public string playerDataFileName; //Field offset: 0x10
	public int playSessionChecksPerBackup; //Field offset: 0x18
	public TimeSpan autoBackupPeriod; //Field offset: 0x20
	public JsonSerializerSettings jsonSettingsForPlayerDataAndFileStorage; //Field offset: 0x28
	public PasswordGenerator passwordGeneratorForPlayerSaves; //Field offset: 0x30
	public string playerDataRootPath; //Field offset: 0x38
	public Strategy storageStrategy; //Field offset: 0x40
	public IStorage identityStorageOverride; //Field offset: 0x48
	public IStorage dataStorageOverride; //Field offset: 0x50
	public bool ignoreUnreadableFiles; //Field offset: 0x58
	public int dataMigrationSaveCountThreshold; //Field offset: 0x5C
	public int dataMigrationSupportEarliestVersion; //Field offset: 0x60

	internal bool IsPlaySessionEnabled
	{
		internal get { } //Length: 8
	}

	private static PlayerOptions() { }

	public PlayerOptions() { }

	internal bool get_IsPlaySessionEnabled() { }

}

