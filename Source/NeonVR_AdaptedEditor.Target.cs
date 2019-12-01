// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NeonVR_AdaptedEditorTarget : TargetRules
{
	public NeonVR_AdaptedEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "NeonVR_Adapted" } );
	}
}
