using UnrealBuildTool;

public class ProyectoUnrealGrupo3EditorTarget : TargetRules
{
	public ProyectoUnrealGrupo3EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ProyectoUnrealGrupo3");
	}
}
