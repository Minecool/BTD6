namespace Assets.Scripts.Data.Behaviors.Towers.CorvusSpells;

public abstract class CorvusSpell : TowerBehavior
{
	public SpriteReference icon; //Field offset: 0x30
	public PrefabReference placingObject; //Field offset: 0x38
	public int corvusAnimationState; //Field offset: 0x40
	public int spiritAnimationState; //Field offset: 0x44
	public int initialManaCost; //Field offset: 0x48
	public Effect corvusEffect; //Field offset: 0x50
	public Effect spiritEffect; //Field offset: 0x58
	public Sound activateSound; //Field offset: 0x60
	public Effect effectDuringCorvus; //Field offset: 0x68
	public Effect effectDuringSpirit; //Field offset: 0x70
	public int unlockLevel; //Field offset: 0x78

	protected SoundModel SoundModel
	{
		 get { } //Length: 42
	}

	protected CorvusSpell() { }

	protected SoundModel get_SoundModel() { }

}

