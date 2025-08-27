namespace Assets.Scripts.Simulation.Corvus.Spells;

public struct CorvusSpellStatus
{
	public readonly CorvusSpellType spellType; //Field offset: 0x0
	public readonly bool isActive; //Field offset: 0x4
	public readonly bool canSpellBeCast; //Field offset: 0x5
	public readonly float cooldownPercent; //Field offset: 0x8
	public readonly float activeDurationRemainingPercent; //Field offset: 0xC

	public CorvusSpellStatus(CorvusSpellType spellType, bool isActive, bool canSpellBeCast, float cooldownPercent, float activeDurationRemainingPercent) { }

}

