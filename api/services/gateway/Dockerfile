#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
#WORKDIR /app
#
#ENV PROTOBUF_TOOLS_OS=linux
#ENV PROTOBUF_TOOLS_CPU=x86
#COPY *.csproj ./
#RUN dotnet restore
#
#
#COPY . ./
#RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY ./out /app
#COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "gateway.dll"]