@echo off
setlocal enableDelayedExpansion

set projectPath="%~dp0\AmazonMWSTester"
set outputPath=%projectPath%\GeneratedAmazonClasses
set inputPath=%projectPath%\Amazon

echo Outputpath: %outputPath%


for %%A in (%inputPath%\*.xsd) do (
	set nameext=%%~nxA
	set filePath="%%~fA"
	set name=%%~nA
	echo Generating class file for !name! to "!name!.designer.cs"
	if !name! == amzn-envelope (
	echo *** Built Serialize, Deserialize, SaveToFile, and LoadFromFile methods
	Xsd2Code\Xsd2Code.exe !filePath! /o %outputPath%\!name!.designer.cs /n AmazonMWSTester.Amazon /pl Net40 /ap+ /eit+ /xa+ /is+ >nul 2>&1 || echo "***Error while processing***"
	) else (
	Xsd2Code\Xsd2Code.exe !filePath! /o %outputPath%\!name!.designer.cs /n AmazonMWSTester.Amazon /pl Net40 /ap+ /eit+ /xa+ /is- >nul 2>&1 || echo "***Error while processing***"
	)
	

	
)
	
echo "Done :)"
