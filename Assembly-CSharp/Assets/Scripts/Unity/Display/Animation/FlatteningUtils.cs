namespace Assets.Scripts.Unity.Display.Animation;

public static class FlatteningUtils
{

	public static Texture2D CloneTextureAsReadable(Texture2D tex) { }

	public static Nullable<Color> ExtractOutlineColor(Material material) { }

	public static Color[] GenerateOutlineColorFixed(Mesh mesh, Color color) { }

	public static Color[] GenerateOutlineColors(Mesh mesh, Material[] materials) { }

	public static void ProcessMaterialsAndUVs(Mesh mesh, SkinnedMeshRenderer meshRenderer, MaterialInfo materialInfo, bool generateOutlineColors) { }

	public static void RemapUVsToRect(Mesh mesh, Rect rect, int submeshIndex = 0) { }

}

