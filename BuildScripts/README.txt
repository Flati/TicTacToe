Setji� 
;%WinDir%\Microsoft.NET\Framework\v4.0.30319\ 
� classpath � Windows svo �i� geti� gert MSbuild beint � command prompt

To run Release
msbuild build.xml /t:Release /p:Configuration=Release
To run Debug
msbuild build.xml /t:Debug /p:Configuration=Debug