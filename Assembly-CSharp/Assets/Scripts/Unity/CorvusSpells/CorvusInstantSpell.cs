namespace Assets.Scripts.Unity.CorvusSpells;

public abstract class CorvusInstantSpell : CorvusSpell
{
	public float duration; //Field offset: 0x138
	public string expDuration; //Field offset: 0x140
	public float cooldown; //Field offset: 0x148
	public string expCooldown; //Field offset: 0x150

	protected CorvusInstantSpell() { }

}

