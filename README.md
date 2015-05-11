## WebDeployPackagePoc

Proof of concept getting aspnet_compile working with Web Deploy packages.
Based off of [this blog post by Craig
Andrews](http://candrews.integralblue.com/2012/04/precompiling-with-web-deploy/).

To build the project, open the Visual Studio Native Tools Command Prompt, then
run:

    msbuild WebDeployPackagePoc.sln /p:AspNetCompiler=true /p:AspNetMerge=false /p:DeployOnBuild=true /p:DeployTarget=Package
