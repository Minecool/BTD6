namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
public sealed class Shader : object
{

	internal DisableBatchingType disableBatching
	{
		[FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = True)]
		internal get { } //Length: 51
	}

	public static GlobalKeyword[] enabledGlobalKeywords
	{
		 get { } //Length: 42
	}

	public static GlobalKeyword[] globalKeywords
	{
		 get { } //Length: 42
	}

	[NativeProperty("GlobalMaximumShaderLOD")]
	public static int globalMaximumLOD
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	public static string globalRenderPipeline
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	[Obsolete("Use Graphics.activeTier instead (UnityUpgradable) -> UnityEngine.Graphics.activeTier", False)]
	public static ShaderHardwareTier globalShaderHardwareTier
	{
		 get { } //Length: 91
		 set { } //Length: 98
	}

	public bool isSupported
	{
		[NativeMethod("IsSupported")]
		 get { } //Length: 51
	}

	public LocalKeywordSpace keywordSpace
	{
		 get { } //Length: 70
	}

	[NativeProperty("MaxChunksRuntimeOverride")]
	public static int maximumChunksOverride
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	[NativeProperty("MaximumShaderLOD")]
	public int maximumLOD
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int passCount
	{
		[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public int renderQueue
	{
		[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public int subshaderCount
	{
		[FreeFunction(Name = "ShaderScripting::GetSubshaderCount", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	private Shader() { }

	private static void CheckPropertyIndex(Shader s, int propertyIndex) { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	public static void DisableKeyword(string keyword) { }

	public static void DisableKeyword(in GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::DisableKeyword")]
	internal static void DisableKeywordFast(GlobalKeyword keyword) { }

	private static void DisableKeywordFast_Injected(ref GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	public static void EnableKeyword(string keyword) { }

	public static void EnableKeyword(in GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::EnableKeyword")]
	internal static void EnableKeywordFast(GlobalKeyword keyword) { }

	private static void EnableKeywordFast_Injected(ref GlobalKeyword keyword) { }

	private static void ExtractGlobalFloatArray(int name, List<Single> values) { }

	[FreeFunction("ShaderScripting::ExtractGlobalFloatArray")]
	private static void ExtractGlobalFloatArrayImpl(int name, out Single[] val) { }

	private static void ExtractGlobalMatrixArray(int name, List<Matrix4x4> values) { }

	[FreeFunction("ShaderScripting::ExtractGlobalMatrixArray")]
	private static void ExtractGlobalMatrixArrayImpl(int name, out Matrix4x4[] val) { }

	private static void ExtractGlobalVectorArray(int name, List<Vector4> values) { }

	[FreeFunction("ShaderScripting::ExtractGlobalVectorArray")]
	private static void ExtractGlobalVectorArrayImpl(int name, out Vector4[] val) { }

	public static Shader Find(string name) { }

	[FreeFunction("GetBuiltinResource<Shader>")]
	internal static Shader FindBuiltin(string name) { }

	public ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, ShaderTagId tagName) { }

	public ShaderTagId FindPassTagValue(int passIndex, ShaderTagId tagName) { }

	public int FindPropertyIndex(string propertyName) { }

	public ShaderTagId FindSubshaderTagValue(int subshaderIndex, ShaderTagId tagName) { }

	public bool FindTextureStack(int propertyIndex, out string stackName, out int layerIndex) { }

	[FreeFunction("ShaderScripting::FindTextureStack")]
	private static bool FindTextureStackImpl(Shader s, int propertyIdx, out string stackName, out int layerIndex) { }

	[FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = True)]
	internal DisableBatchingType get_disableBatching() { }

	public static GlobalKeyword[] get_enabledGlobalKeywords() { }

	public static GlobalKeyword[] get_globalKeywords() { }

	public static int get_globalMaximumLOD() { }

	public static string get_globalRenderPipeline() { }

	public static ShaderHardwareTier get_globalShaderHardwareTier() { }

	[NativeMethod("IsSupported")]
	public bool get_isSupported() { }

	public LocalKeywordSpace get_keywordSpace() { }

	private void get_keywordSpace_Injected(out LocalKeywordSpace ret) { }

	public static int get_maximumChunksOverride() { }

	public int get_maximumLOD() { }

	[FreeFunction(Name = "ShaderScripting::GetPassCount", HasExplicitThis = True)]
	public int get_passCount() { }

	[FreeFunction("ShaderScripting::GetRenderQueue", HasExplicitThis = True)]
	public int get_renderQueue() { }

	[FreeFunction(Name = "ShaderScripting::GetSubshaderCount", HasExplicitThis = True)]
	public int get_subshaderCount() { }

	[FreeFunction("keywords::GetAllGlobalKeywords")]
	internal static GlobalKeyword[] GetAllGlobalKeywords() { }

	public Shader GetDependency(string name) { }

	[FreeFunction("keywords::GetEnabledGlobalKeywords")]
	internal static GlobalKeyword[] GetEnabledGlobalKeywords() { }

	public static Color GetGlobalColor(int nameID) { }

	public static Color GetGlobalColor(string name) { }

	public static float GetGlobalFloat(string name) { }

	public static float GetGlobalFloat(int nameID) { }

	public static Single[] GetGlobalFloatArray(string name) { }

	public static void GetGlobalFloatArray(int nameID, List<Single> values) { }

	public static void GetGlobalFloatArray(string name, List<Single> values) { }

	public static Single[] GetGlobalFloatArray(int nameID) { }

	[FreeFunction("ShaderScripting::GetGlobalFloatArrayCount")]
	private static int GetGlobalFloatArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalFloatArray")]
	private static Single[] GetGlobalFloatArrayImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalFloat")]
	private static float GetGlobalFloatImpl(int name) { }

	public static int GetGlobalInt(string name) { }

	public static int GetGlobalInt(int nameID) { }

	public static int GetGlobalInteger(string name) { }

	public static int GetGlobalInteger(int nameID) { }

	[FreeFunction("ShaderScripting::GetGlobalInt")]
	private static int GetGlobalIntImpl(int name) { }

	public static Matrix4x4 GetGlobalMatrix(int nameID) { }

	public static Matrix4x4 GetGlobalMatrix(string name) { }

	public static Matrix4x4[] GetGlobalMatrixArray(string name) { }

	public static Matrix4x4[] GetGlobalMatrixArray(int nameID) { }

	public static void GetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	public static void GetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrixArrayCount")]
	private static int GetGlobalMatrixArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrixArray")]
	private static Matrix4x4[] GetGlobalMatrixArrayImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalMatrix")]
	private static Matrix4x4 GetGlobalMatrixImpl(int name) { }

	private static void GetGlobalMatrixImpl_Injected(int name, out Matrix4x4 ret) { }

	public static Texture GetGlobalTexture(string name) { }

	public static Texture GetGlobalTexture(int nameID) { }

	[FreeFunction("ShaderScripting::GetGlobalTexture")]
	private static Texture GetGlobalTextureImpl(int name) { }

	public static Vector4 GetGlobalVector(string name) { }

	public static Vector4 GetGlobalVector(int nameID) { }

	public static Vector4[] GetGlobalVectorArray(string name) { }

	public static Vector4[] GetGlobalVectorArray(int nameID) { }

	public static void GetGlobalVectorArray(string name, List<Vector4> values) { }

	public static void GetGlobalVectorArray(int nameID, List<Vector4> values) { }

	[FreeFunction("ShaderScripting::GetGlobalVectorArrayCount")]
	private static int GetGlobalVectorArrayCountImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalVectorArray")]
	private static Vector4[] GetGlobalVectorArrayImpl(int name) { }

	[FreeFunction("ShaderScripting::GetGlobalVector")]
	private static Vector4 GetGlobalVectorImpl(int name) { }

	private static void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

	[FreeFunction(Name = "ShaderScripting::GetPassCountInSubshader", HasExplicitThis = True)]
	public int GetPassCountInSubshader(int subshaderIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyAttributes")]
	private static String[] GetPropertyAttributes(Shader shader, int propertyIndex) { }

	public String[] GetPropertyAttributes(int propertyIndex) { }

	public int GetPropertyCount() { }

	public float GetPropertyDefaultFloatValue(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDefaultIntValue")]
	private static int GetPropertyDefaultIntValue(Shader shader, int propertyIndex) { }

	public int GetPropertyDefaultIntValue(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDefaultValue")]
	private static Vector4 GetPropertyDefaultValue(Shader shader, int propertyIndex) { }

	private static void GetPropertyDefaultValue_Injected(Shader shader, int propertyIndex, out Vector4 ret) { }

	public Vector4 GetPropertyDefaultVectorValue(int propertyIndex) { }

	public string GetPropertyDescription(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyDescription")]
	private static string GetPropertyDescription(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyFlags")]
	private static ShaderPropertyFlags GetPropertyFlags(Shader shader, int propertyIndex) { }

	public ShaderPropertyFlags GetPropertyFlags(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyName")]
	private static string GetPropertyName(Shader shader, int propertyIndex) { }

	public string GetPropertyName(int propertyIndex) { }

	public int GetPropertyNameId(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyNameId")]
	private static int GetPropertyNameId(Shader shader, int propertyIndex) { }

	public Vector2 GetPropertyRangeLimits(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyTextureDefaultName")]
	private static string GetPropertyTextureDefaultName(Shader shader, int propertyIndex) { }

	public string GetPropertyTextureDefaultName(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyTextureDimension")]
	private static TextureDimension GetPropertyTextureDimension(Shader shader, int propertyIndex) { }

	public TextureDimension GetPropertyTextureDimension(int propertyIndex) { }

	public ShaderPropertyType GetPropertyType(int propertyIndex) { }

	[FreeFunction("ShaderScripting::GetPropertyType")]
	private static ShaderPropertyType GetPropertyType(Shader shader, int propertyIndex) { }

	[FreeFunction("ShaderScripting::IDToTag")]
	internal static string IDToTag(int name) { }

	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	private int Internal_FindPassTagValue(int passIndex, int tagName) { }

	[FreeFunction(Name = "ShaderScripting::FindPassTagValue", HasExplicitThis = True)]
	private int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName) { }

	[FreeFunction(Name = "ShaderScripting::FindSubshaderTagValue", HasExplicitThis = True)]
	private int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName) { }

	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	public static bool IsKeywordEnabled(string keyword) { }

	public static bool IsKeywordEnabled(in GlobalKeyword keyword) { }

	[FreeFunction("ShaderScripting::IsKeywordEnabled")]
	internal static bool IsKeywordEnabledFast(GlobalKeyword keyword) { }

	private static bool IsKeywordEnabledFast_Injected(ref GlobalKeyword keyword) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	public static int PropertyToID(string name) { }

	public static void set_globalMaximumLOD(int value) { }

	public static void set_globalRenderPipeline(string value) { }

	public static void set_globalShaderHardwareTier(ShaderHardwareTier value) { }

	public static void set_maximumChunksOverride(int value) { }

	public void set_maximumLOD(int value) { }

	public static void SetGlobalBuffer(string name, ComputeBuffer value) { }

	public static void SetGlobalBuffer(string name, GraphicsBuffer value) { }

	public static void SetGlobalBuffer(int nameID, ComputeBuffer value) { }

	public static void SetGlobalBuffer(int nameID, GraphicsBuffer value) { }

	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	private static void SetGlobalBufferImpl(int name, ComputeBuffer value) { }

	public static void SetGlobalColor(string name, Color value) { }

	public static void SetGlobalColor(int nameID, Color value) { }

	public static void SetGlobalConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size) { }

	public static void SetGlobalConstantBuffer(string name, GraphicsBuffer value, int offset, int size) { }

	public static void SetGlobalConstantBuffer(string name, ComputeBuffer value, int offset, int size) { }

	public static void SetGlobalConstantBuffer(int nameID, ComputeBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	private static void SetGlobalConstantBufferImpl(int name, ComputeBuffer value, int offset, int size) { }

	[FreeFunction("ShaderScripting::SetGlobalConstantBuffer")]
	private static void SetGlobalConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size) { }

	public static void SetGlobalFloat(string name, float value) { }

	public static void SetGlobalFloat(int nameID, float value) { }

	public static void SetGlobalFloatArray(int nameID, List<Single> values) { }

	public static void SetGlobalFloatArray(string name, List<Single> values) { }

	public static void SetGlobalFloatArray(int nameID, Single[] values) { }

	private static void SetGlobalFloatArray(int name, Single[] values, int count) { }

	public static void SetGlobalFloatArray(string name, Single[] values) { }

	[FreeFunction("ShaderScripting::SetGlobalFloatArray")]
	private static void SetGlobalFloatArrayImpl(int name, Single[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalFloat")]
	private static void SetGlobalFloatImpl(int name, float value) { }

	[FreeFunction("ShaderScripting::SetGlobalBuffer")]
	private static void SetGlobalGraphicsBufferImpl(int name, GraphicsBuffer value) { }

	public static void SetGlobalInt(int nameID, int value) { }

	public static void SetGlobalInt(string name, int value) { }

	public static void SetGlobalInteger(string name, int value) { }

	public static void SetGlobalInteger(int nameID, int value) { }

	[FreeFunction("ShaderScripting::SetGlobalInt")]
	private static void SetGlobalIntImpl(int name, int value) { }

	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	public static void SetGlobalMatrix(string name, Matrix4x4 value) { }

	public static void SetGlobalMatrixArray(int nameID, List<Matrix4x4> values) { }

	public static void SetGlobalMatrixArray(string name, List<Matrix4x4> values) { }

	public static void SetGlobalMatrixArray(string name, Matrix4x4[] values) { }

	public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values) { }

	private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrixArray")]
	private static void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalMatrix")]
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	private static void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	[FreeFunction("ShaderScripting::SetGlobalRenderTexture")]
	private static void SetGlobalRenderTextureImpl(int name, RenderTexture value, RenderTextureSubElement element) { }

	public static void SetGlobalTexture(string name, Texture value) { }

	public static void SetGlobalTexture(int nameID, Texture value) { }

	public static void SetGlobalTexture(string name, RenderTexture value, RenderTextureSubElement element) { }

	public static void SetGlobalTexture(int nameID, RenderTexture value, RenderTextureSubElement element) { }

	[FreeFunction("ShaderScripting::SetGlobalTexture")]
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	public static void SetGlobalVector(string name, Vector4 value) { }

	public static void SetGlobalVector(int nameID, Vector4 value) { }

	public static void SetGlobalVectorArray(string name, List<Vector4> values) { }

	public static void SetGlobalVectorArray(int nameID, List<Vector4> values) { }

	public static void SetGlobalVectorArray(string name, Vector4[] values) { }

	public static void SetGlobalVectorArray(int nameID, Vector4[] values) { }

	private static void SetGlobalVectorArray(int name, Vector4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
	private static void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count) { }

	[FreeFunction("ShaderScripting::SetGlobalVector")]
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	private static void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	public static void SetKeyword(in GlobalKeyword keyword, bool value) { }

	[FreeFunction("ShaderScripting::SetKeyword")]
	internal static void SetKeywordFast(GlobalKeyword keyword, bool value) { }

	private static void SetKeywordFast_Injected(ref GlobalKeyword keyword, bool value) { }

	[FreeFunction("ShaderScripting::TagToID")]
	internal static int TagToID(string name) { }

	[FreeFunction]
	public static void WarmupAllShaders() { }

}

