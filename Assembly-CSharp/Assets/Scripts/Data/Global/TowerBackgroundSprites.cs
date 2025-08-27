namespace Assets.Scripts.Data.Global;

public class TowerBackgroundSprites : ScriptableObject
{
	public SpriteReference primarySprite; //Field offset: 0x18
	public SpriteReference militarySprite; //Field offset: 0x20
	public SpriteReference magicSprite; //Field offset: 0x28
	public SpriteReference supportSprite; //Field offset: 0x30
	public SpriteReference heroSprite; //Field offset: 0x38
	public SpriteReference primarySpriteRound; //Field offset: 0x40
	public SpriteReference militarySpriteRound; //Field offset: 0x48
	public SpriteReference magicSpriteRound; //Field offset: 0x50
	public SpriteReference supportSpriteRound; //Field offset: 0x58

	public TowerBackgroundSprites() { }

}

