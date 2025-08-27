namespace Assets.Scripts.Unity.CorvusSpells;

public abstract class CorvusContinuousSpell : CorvusSpell
{
	public int ongoingManaCost; //Field offset: 0x138
	public string expOngoingManaCost; //Field offset: 0x140
	public float manaDrainInterval; //Field offset: 0x148
	public string expManaDrainInterval; //Field offset: 0x150

	protected CorvusContinuousSpell() { }

}

