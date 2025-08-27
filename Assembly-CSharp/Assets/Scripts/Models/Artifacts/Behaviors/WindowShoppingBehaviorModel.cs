namespace Assets.Scripts.Models.Artifacts.Behaviors;

public class WindowShoppingBehaviorModel : MapArtifactBehaviorModel
{
	private int currentTokens; //Field offset: 0x30
	public int tokenLimitAmt; //Field offset: 0x34
	public int livesToAdd; //Field offset: 0x38

	private WindowShoppingBehaviorModel(string name, int tokenLimitAmt, int livesToAdd) { }

	public virtual void Activate(ILegendsDataProvider legendsDataProvider) { }

	public virtual Model Clone() { }

	public virtual void Deactivate(ILegendsDataProvider legendsDataProvider) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	private void OnEnterMerchant(int currentTokens) { }

	private void OnLeaveMerchant(ArtifactLoot[] lootBought, int tokensSpent) { }

}

