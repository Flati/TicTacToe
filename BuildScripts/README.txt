Setjið 
;%WinDir%\Microsoft.NET\Framework\v4.0.30319\ 
í classpath í Windows svo þið getið gert MSbuild beint í command prompt

To run Release
msbuild build.xml /t:Release /p:Configuration=Release
To run Debug
msbuild build.xml /t:Debug /p:Configuration=Debug