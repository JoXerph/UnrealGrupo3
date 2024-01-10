using UnrealBuildTool;

public class ProyectoUnrealGrupo3Target : TargetRules
{
	public ProyectoUnrealGrupo3Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProyectoUnrealGrupo3");
	}
}
