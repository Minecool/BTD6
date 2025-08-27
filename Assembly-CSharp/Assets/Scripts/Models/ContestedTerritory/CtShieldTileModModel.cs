namespace Assets.Scripts.Models.ContestedTerritory;

public class CtShieldTileModModel : MutatorModModel, IModifyContestedTerritoryRules
{
	private TimeSpan duration; //Field offset: 0x30

	public CtShieldTileModModel(string name, TimeSpan duration) { }

	public override void ApplyModification(DailyChallengeModel dcm) { }

	public virtual Model Clone() { }

	public override void RemoveModification(DailyChallengeModel dcm) { }

}

