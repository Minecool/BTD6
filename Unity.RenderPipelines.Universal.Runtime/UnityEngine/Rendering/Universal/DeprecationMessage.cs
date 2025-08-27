namespace UnityEngine.Rendering.Universal;

internal struct DeprecationMessage
{
	internal const string CompatibilityScriptingAPIObsolete = "This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead."; //Field offset: 0x0
	internal const string CompatibilityScriptingAPIConsoleWarning = "The project currently uses the compatibility mode where the Render Graph API is disabled. Support for this mode will be removed in future Unity versions. Migrate existing ScriptableRenderPasses to the new RenderGraph API. After the migration, disable the compatibility mode in Edit > Projects Settings > Graphics > Render Graph."; //Field offset: 0x0

}

