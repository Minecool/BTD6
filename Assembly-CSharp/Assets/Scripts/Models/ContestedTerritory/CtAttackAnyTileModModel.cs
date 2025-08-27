namespace Assets.Scripts.Models.ContestedTerritory;

public class CtAttackAnyTileModModel : MutatorModModel, IModifyContestedTerritoryRules
{
	internal sealed class SetPlayerCanAttackAnyTile : MulticastDelegate
	{

		public SetPlayerCanAttackAnyTile(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool canAttackAnyTile, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool canAttackAnyTile) { }

	}


	public CtAttackAnyTileModModel(string name) { }

	public override void ApplyModification(DailyChallengeModel dcm) { }

	public virtual Model Clone() { }

	public override void RemoveModification(DailyChallengeModel dcm) { }

}

