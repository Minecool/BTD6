namespace Assets.Scripts.Unity.CorvusSpells;

public abstract class CorvusSpell : TowerBehavior
{
	public GameObject icon; //Field offset: 0x98
	public GameObject expIcon; //Field offset: 0xA0
	public GameObject placingObject; //Field offset: 0xA8
	public GameObject expPlacingObject; //Field offset: 0xB0
	public int corvusAnimationState; //Field offset: 0xB8
	public string expCorvusAnimationState; //Field offset: 0xC0
	public int spiritAnimationState; //Field offset: 0xC8
	public string expSpiritAnimationState; //Field offset: 0xD0
	public int initialManaCost; //Field offset: 0xD8
	public string expInitialManaCost; //Field offset: 0xE0
	public Effect corvusEffect; //Field offset: 0xE8
	public Effect expCorvusEffect; //Field offset: 0xF0
	public Effect spiritEffect; //Field offset: 0xF8
	public Effect expSpiritEffect; //Field offset: 0x100
	public AudioClip activateSound; //Field offset: 0x108
	public AudioClip expActivateSound; //Field offset: 0x110
	public Effect effectDuringCorvus; //Field offset: 0x118
	public Effect expEffectDuringCorvus; //Field offset: 0x120
	public Effect effectDuringSpirit; //Field offset: 0x128
	public Effect expEffectDuringSpirit; //Field offset: 0x130

	protected CorvusSpell() { }

	protected SoundModel GetSoundModel() { }

	protected int GetUnlockLevel() { }

}

