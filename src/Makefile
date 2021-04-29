MSBUILD=C:\Program Files\MSBuild\14.0\bin\MSBuild.exe
PARAMETERS=/p:Configuration=Release
TEAM=xhochm07_xstast37_xkonet01_xdejma01

all: nuget
	$(MSBUILD) Calculator\Calculator.sln $(PARAMETERS) /t:Clean,Build

nuget:
	if not exist "nuget.exe" powershell -command "& { iwr https://dist.nuget.org/win-x86-commandline/latest/nuget.exe -OutFile nuget.exe }"
	nuget.exe restore Calculator

pack:	doc
	if exist ..\..\$(TEAM) rmdir /s /q ..\..\$(TEAM)
	mkdir ..\..\$(TEAM)
	mkdir ..\..\$(TEAM)\install
	mkdir ..\..\$(TEAM)\repo
	mkdir ..\..\$(TEAM)\doc
	xcopy /s /D /C /E /Q "install" "..\..\$(TEAM)\install\"
	xcopy /s /D /C doc "..\..\$(TEAM)\doc\"
	git clean -d -x -f
	xcopy /s /D ..\. "..\..\$(TEAM)\repo\"
	powershell -nologo -noprofile -command "& { Add-Type -A 'System.IO.Compression.FileSystem'; [IO.Compression.ZipFile]::CreateFromDirectory('..\..\$(TEAM)', '..\..\$(TEAM).zip'); }"

clean:
	git clean -d -x -f

run: all
	Calculator\Calculator\bin\Release\Calculator.exe

profile:
	.\Profiling\bin\Debug\netcoreapp3.1\Profiling.exe < Profiling\Input\10.txt
	.\Profiling\bin\Debug\netcoreapp3.1\Profiling.exe < Profiling\Input\100.txt
	.\Profiling\bin\Debug\netcoreapp3.1\Profiling.exe < Profiling\Input\1000.txt

tests: nuget
	$(MSBUILD) Calculator\MathLib\MathLib.csproj $(PARAMETERS)
	$(MSBUILD) Calculator\MathLibraryTests\MathLibraryTests.csproj $(PARAMETERS)
	Calculator\packages\xunit.runner.console.2.2.0\tools\xunit.console 	Calculator\MathLibraryTests\bin\Release\MathLibraryTests.dll

doc: nuget
	$(MSBUILD) Calculator\Calculator.sln $(PARAMETERS) /p:DocumentationFile=Doc.xml /t:Clean,Build
	if not exist "doc" mkdir "doc"
	copy /y Calculator\Calculator\bin\Release\Doc.xml doc\Calculator.xml
	copy /y Calculator\MathLib\bin\Release\Doc.xml doc\MathLib.xml
	copy /y Calculator\MathLibraryTests\bin\Release\Doc.xml doc\MathLibraryTests.xml
help:
	@echo Před spuštěním to nainstalujte
