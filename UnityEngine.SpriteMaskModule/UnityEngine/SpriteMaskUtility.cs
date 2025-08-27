namespace UnityEngine;

[NativeHeader("Modules/SpriteMask/Public/ScriptBindings/SpriteMask.bindings.h")]
[StaticAccessor("SpriteUtilityBindings", StaticAccessorType::DoubleColon (2))]
public static class SpriteMaskUtility
{

	public static bool HasSpriteMaskInLayerRange(SortingLayerRange range) { }

	private static bool HasSpriteMaskInLayerRange_Injected(ref SortingLayerRange range) { }

}

