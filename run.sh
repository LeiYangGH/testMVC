#!/bin/bash
dotnet restore ~/g/testMVC/WebApplication1/WebApplication1.sln
dotnet build ~/g/testMVC/WebApplication1/WebApplication1.sln
dotnet publish ~/g/testMVC/WebApplication1/WebApplication1/WebApplication1.csproj -o /home/leiyang/p
dotnet /home/leiyang/p/WebApplication1.dll 
