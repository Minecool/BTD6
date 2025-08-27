namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(InvokeBoostBuffBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class InvokeBoostBuffBehaviorModel : ItemArtifactBehaviorModel
{
	[ExtendedDrawer]
	public BoostArtifactModel boostToInvokeModel; //Field offset: 0x30

	public InvokeBoostBuffBehaviorModel(string name, BoostArtifactModel boostToInvokeModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

