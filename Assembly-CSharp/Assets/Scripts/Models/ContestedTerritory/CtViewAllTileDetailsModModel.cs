namespace Assets.Scripts.Models.ContestedTerritory;

public class CtViewAllTileDetailsModModel : MutatorModModel, IModifyContestedTerritoryRules
{
	internal sealed class SetPlayerCanViewAllTileDetails : MulticastDelegate
	{

		public SetPlayerCanViewAllTileDetails(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool canViewAllTileDetails, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool canViewAllTileDetails) { }

	}


	public CtViewAllTileDetailsModModel(string name) { }

	public override void ApplyModification(DailyChallengeModel dcm) { }

	public virtual Model Clone() { }

	public override void RemoveModification(DailyChallengeModel dcm) { }

}

