namespace Assets.Scripts.Models.ContestedTerritory;

public class CtEmptyModModel : MutatorModModel, IModifyContestedTerritoryRules
{

	public CtEmptyModModel(string name) { }

	public override void ApplyModification(DailyChallengeModel dcm) { }

	public virtual Model Clone() { }

	public override void RemoveModification(DailyChallengeModel dcm) { }

}

