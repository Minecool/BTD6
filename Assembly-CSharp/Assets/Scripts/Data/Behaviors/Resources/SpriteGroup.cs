namespace Assets.Scripts.Data.Behaviors.Resources;

[CreateAssetMenu(fileName = "SpriteGroup", menuName = "BTD6/Behaviors/Resources/SpriteGroup")]
public class SpriteGroup : ScriptableObject
{
	public PrefabReference[] sprites; //Field offset: 0x18

	public SpriteGroup() { }

}

