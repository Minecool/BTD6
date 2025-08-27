namespace Assets.Scripts.Models.ServerEvents;

public class Restrictions
{
	public CEMod endRound; //Field offset: 0x10
	public CEMod bloonSpeed; //Field offset: 0x18
	public CEMod moabSpeed; //Field offset: 0x20
	public CEMod ceramicHealth; //Field offset: 0x28
	public CEMod moabHealth; //Field offset: 0x30
	public CEMod regrowSpeed; //Field offset: 0x38
	public CEMod abilityCooldownReduction; //Field offset: 0x40
	public CEMod removeableCost; //Field offset: 0x48
	public CEMod startLives; //Field offset: 0x50
	public CEMod maxLives; //Field offset: 0x58
	public CEMod cash; //Field offset: 0x60
	public CEMod paragonLimit; //Field offset: 0x68

	public Restrictions() { }

	public float GetMaxRestrictionValue(ChallengeModifiers challengerMod) { }

	public float GetMinRestrictionValue(ChallengeModifiers challengerMod) { }

	public CEMod GetRestriction(ChallengeModifiers challengerMod) { }

}

