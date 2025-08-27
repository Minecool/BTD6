namespace Assets.Scripts.Simulation.GeraldoItems;

public class JarOfPicklesBehavior : GeraldoTowerHighlightingBehavior
{

	public JarOfPicklesBehavior() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	private BehaviorMutator GetCurrentMutator(JarOfPicklesBehaviorModel jarOfPicklesBehaviorModel, Tower geraldo, out int version) { }

	private bool IsPositionValid(Vector2 location, int inputId) { }

	private bool IsTowerValid(Tower tower) { }

	private bool TowerHasWeapon(Tower tower) { }

}

