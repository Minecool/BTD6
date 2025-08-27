namespace Assets.Scripts.Models;

public abstract class MutatorModModel : Model
{

	public MutatorModModel(string name) { }

	protected bool HasTargetName(string behaviorName, String[] targetNames) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public override bool IsGameModeMod() { }

	public override bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

	public override bool Mutate(BloonModel model, BloonModel unmodded, string target = "") { }

	public override bool Mutate(PowerModel model, PowerModel unmodded, string target = "") { }

	public override bool Mutate(GeraldoItemModel model, GeraldoItemModel unmodded, string target = "") { }

	public override bool Mutate(GameModel model, GameModel unmodded) { }

	public override bool Mutate(TowerDetailsModel model, TowerDetailsModel unmodded, GameModel gameModel, string target = "") { }

}

