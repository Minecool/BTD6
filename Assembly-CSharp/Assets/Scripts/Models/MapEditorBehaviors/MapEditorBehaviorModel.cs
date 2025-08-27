namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapEditorBehaviorModel : Model
{
	public PrefabReference placementEffect; //Field offset: 0x30
	public PrefabReference placementEffectLarge; //Field offset: 0x38
	public PrefabReference sellEffect; //Field offset: 0x40

	public MapEditorBehaviorModel(PrefabReference placementEffect, PrefabReference placementEffectLarge, PrefabReference sellEffect) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

