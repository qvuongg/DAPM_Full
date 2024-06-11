# Ensure the Service Fabric cluster you deploy to supports the container image you are using. See https://aka.ms/containerimagehelp for information on Windows container version compatibility.
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2019
ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .
