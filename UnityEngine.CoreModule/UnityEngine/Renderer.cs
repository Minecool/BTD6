namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Renderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public class Renderer : Component
{

	[NativeProperty("IsDynamicOccludee")]
	public bool allowOcclusionWhenDynamic
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Bounds bounds
	{
		[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
		 get { } //Length: 148
	}

	public bool enabled
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool forceRenderingOff
	{
		 set { } //Length: 134
	}

	public LightProbeUsage lightProbeUsage
	{
		 set { } //Length: 131
	}

	public Bounds localBounds
	{
		[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = True)]
		 get { } //Length: 148
		[NativeName("SetLocalAABB")]
		 set { } //Length: 133
	}

	public Material material
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public Material[] materials
	{
		 get { } //Length: 118
		 set { } //Length: 196
	}

	public MotionVectorGenerationMode motionVectorGenerationMode
	{
		 set { } //Length: 131
	}

	public bool receiveShadows
	{
		 set { } //Length: 134
	}

	public ReflectionProbeUsage reflectionProbeUsage
	{
		 set { } //Length: 131
	}

	public ShadowCastingMode shadowCastingMode
	{
		 set { } //Length: 131
	}

	public Material sharedMaterial
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public Material[] sharedMaterials
	{
		 get { } //Length: 118
		 set { } //Length: 196
	}

	internal int sortingGroupID
	{
		internal get { } //Length: 118
	}

	internal int sortingGroupOrder
	{
		internal get { } //Length: 118
	}

	public int sortingLayerID
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public string sortingLayerName
	{
		 set { } //Length: 435
	}

	public int sortingOrder
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public Renderer() { }

	public bool get_allowOcclusionWhenDynamic() { }

	private static bool get_allowOcclusionWhenDynamic_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	public Bounds get_bounds() { }

	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	public bool get_enabled() { }

	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = True)]
	public Bounds get_localBounds() { }

	private static void get_localBounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	public Material get_material() { }

	public Material[] get_materials() { }

	public Material get_sharedMaterial() { }

	public Material[] get_sharedMaterials() { }

	internal int get_sortingGroupID() { }

	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	internal int get_sortingGroupOrder() { }

	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }

	public int get_sortingLayerID() { }

	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	public int get_sortingOrder() { }

	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	private Material GetMaterial() { }

	private static IntPtr GetMaterial_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	private Material[] GetMaterialArray() { }

	private static Material[] GetMaterialArray_Injected(IntPtr _unity_self) { }

	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	private Material GetSharedMaterial() { }

	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	[NativeName("GetMaterialArray")]
	private Material[] GetSharedMaterialArray() { }

	private static Material[] GetSharedMaterialArray_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	private static void Internal_GetPropertyBlock_Injected(IntPtr _unity_self, IntPtr dest) { }

	[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = True)]
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	private static void Internal_SetPropertyBlock_Injected(IntPtr _unity_self, IntPtr properties) { }

	public void set_allowOcclusionWhenDynamic(bool value) { }

	private static void set_allowOcclusionWhenDynamic_Injected(IntPtr _unity_self, bool value) { }

	public void set_enabled(bool value) { }

	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	public void set_forceRenderingOff(bool value) { }

	private static void set_forceRenderingOff_Injected(IntPtr _unity_self, bool value) { }

	public void set_lightProbeUsage(LightProbeUsage value) { }

	private static void set_lightProbeUsage_Injected(IntPtr _unity_self, LightProbeUsage value) { }

	[NativeName("SetLocalAABB")]
	public void set_localBounds(Bounds value) { }

	private static void set_localBounds_Injected(IntPtr _unity_self, in Bounds value) { }

	public void set_material(Material value) { }

	public void set_materials(Material[] value) { }

	public void set_motionVectorGenerationMode(MotionVectorGenerationMode value) { }

	private static void set_motionVectorGenerationMode_Injected(IntPtr _unity_self, MotionVectorGenerationMode value) { }

	public void set_receiveShadows(bool value) { }

	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	private static void set_reflectionProbeUsage_Injected(IntPtr _unity_self, ReflectionProbeUsage value) { }

	public void set_shadowCastingMode(ShadowCastingMode value) { }

	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	public void set_sharedMaterial(Material value) { }

	public void set_sharedMaterials(Material[] value) { }

	public void set_sortingLayerID(int value) { }

	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	public void set_sortingLayerName(string value) { }

	private static void set_sortingLayerName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_sortingOrder(int value) { }

	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	private void SetMaterial(Material m) { }

	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	private void SetMaterialArray(Material[] m) { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	private void SetMaterialArray(Material[] m, int length) { }

	private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length) { }

	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

}

