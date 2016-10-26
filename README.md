# aspnetcore-kudurepro
Reproduce issue with deploying aspnetcore xproj + csproj references

Creating a repro for https://github.com/projectkudu/kudu/issues/1518 to re-open the issue.

Local publish from VS works fine. In troubleshooting deployment issues to App Service with Kudu deploy command, using msbuild as suggested by [Make sure site correctly deploys locally](https://github.com/projectkudu/kudu/wiki/Make-sure-site-correctly-deploys-locally).

## Local msbuild Repro steps
- Clone
- Open VS Command prompt to sln directory
- Create temp folder at c:\temp\WebApplication1
- run command below

```
msbuild WebApplication1\WebApplication1.xproj /nologo /verbosity:m /t:Build /t:pipelinePreDeployCopyAllFilesToOneFolder /p:_PackageTempDir="c:\temp\WebApplication1";AutoParameterizationWebConfigConnectionStrings=false;Configuration=Release;UseSharedCompilation=false /p:SolutionDir="."
```

Expected error message:
`error MSB4057: The target "pipelinePreDeployCopyAllFilesToOneFolder" does not exist in the project.`
