namespace Assets.Scripts.Models.ContestedTerritory;

public class CtAddPowersModModel : MutatorModModel, IModifyContestedTerritoryRules
{
	public string power; //Field offset: 0x30
	public int amount; //Field offset: 0x38

	public CtAddPowersModModel(string name, string power, int amount) { }

	[CompilerGenerated]
	private bool <ApplyModification>b__3_0(PowerData x) { }

	[CompilerGenerated]
	private bool <RemoveModification>b__4_0(PowerData x) { }

	public override void ApplyModification(DailyChallengeModel dcm) { }

	public virtual Model Clone() { }

	public override void RemoveModification(DailyChallengeModel dcm) { }

}

