//Type is in global namespace

public class LegendsUIAudio : ScriptableObject
{
	[Header("UI")]
	public AudioClipReference openSound; //Field offset: 0x18
	public AudioClipReference closeSound; //Field offset: 0x20
	public AudioClipReference nextSound; //Field offset: 0x28
	public AudioClipReference selectSound; //Field offset: 0x30
	public AudioClipReference tradeSound; //Field offset: 0x38
	public AudioClipReference artifactExtractSound; //Field offset: 0x40
	public AudioClipReference itemSelectSound; //Field offset: 0x48
	public AudioClipReference healthGainedSound; //Field offset: 0x50
	public AudioClipReference healthLostSound; //Field offset: 0x58
	public AudioClipReference lastLifeSound; //Field offset: 0x60
	public AudioClipReference spawnMonke; //Field offset: 0x68
	[Header("=== Tiles ===")]
	public List<AudioClipReference> tileDefault; //Field offset: 0x70
	public List<AudioClipReference> tileCombat; //Field offset: 0x78
	public List<AudioClipReference> tileCombatMiniBoss; //Field offset: 0x80
	public List<AudioClipReference> tileCombatBoss; //Field offset: 0x88
	public List<AudioClipReference> tileMerchant; //Field offset: 0x90
	public List<AudioClipReference> tileMerchantLoop; //Field offset: 0x98
	public List<AudioClipReference> tileRestLoop; //Field offset: 0xA0
	[Header("=== End Boss ===")]
	public List<AudioClipReference> bossWarHorn; //Field offset: 0xA8
	public List<AudioClipReference> bossBloonarius; //Field offset: 0xB0
	public List<AudioClipReference> bossLych; //Field offset: 0xB8
	public List<AudioClipReference> bossDreadbloon; //Field offset: 0xC0
	public List<AudioClipReference> bossPhayze; //Field offset: 0xC8
	public List<AudioClipReference> bossVortex; //Field offset: 0xD0
	public List<AudioClipReference> bossBlastapopoulos; //Field offset: 0xD8
	[Header("=== End Boss Deaths ===")]
	[SerializableDictionary]
	public SerializableDictionary<BossType, AudioClipReference> bossDeaths; //Field offset: 0xE0
	[Header("=== Mini Boss ===")]
	public List<AudioClipReference> miniBossBloonarius; //Field offset: 0xE8
	public List<AudioClipReference> miniBossLych; //Field offset: 0xF0
	public List<AudioClipReference> miniBossDreadbloon; //Field offset: 0xF8
	public List<AudioClipReference> miniBossPhayze; //Field offset: 0x100
	public List<AudioClipReference> miniBossVortex; //Field offset: 0x108
	public List<AudioClipReference> miniBossBlastapopoulos; //Field offset: 0x110

	public LegendsUIAudio() { }

	public AudioClipReference GetBossAudioClip(BossType bossType, bool miniBoss = true) { }

	public AudioClipReference GetBossDeathAudioClip(BossType bossType) { }

	public AudioClipReference GetTileAudioClip(RogueTileType tileType) { }

}

