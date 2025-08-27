namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PlayAnimationIndex), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlayAnimationIndexModel : TowerBehaviorModel
{
	public int placeAnimation; //Field offset: 0x30
	public int upgradeAnimation; //Field offset: 0x34

	public PlayAnimationIndexModel(string name, int placeAnimation, int upgradeAnimation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

