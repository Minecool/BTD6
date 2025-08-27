namespace Assets.Scripts.Data.Legends;

public class RogueInstaMonkey : RogueLoot
{
	public string baseId; //Field offset: 0x10
	public Int32[] tiers; //Field offset: 0x18
	[HideInInspector]
	public int currentCooldown; //Field offset: 0x20
	public RogueLootType lootType; //Field offset: 0x24
	public int uniqueId; //Field offset: 0x28
	public bool isFree; //Field offset: 0x2C

	public RogueInstaMonkey() { }

}

