namespace Assets.Scripts.Data.Input;

public class SolidShadowConfig : ScriptableObject
{
	[StrongReferenceAllowed]
	public Material overrideMaterial; //Field offset: 0x18
	public Color outlineColor; //Field offset: 0x20
	public Color shadowColor; //Field offset: 0x30
	public float outlinePadding; //Field offset: 0x40
	public Vector2 shadowOffset; //Field offset: 0x44

	public SolidShadowConfig() { }

}

