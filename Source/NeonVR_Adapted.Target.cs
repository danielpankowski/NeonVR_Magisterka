// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class NeonVR_AdaptedTarget : TargetRules
{
	public NeonVR_AdaptedTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "NeonVR_Adapted" } );
	}
}
