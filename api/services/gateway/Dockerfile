FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

ENV PROTOBUF_TOOLS_OS=linux
ENV PROTOBUF_TOOLS_CPU=x86
COPY *.csproj ./
RUN dotnet restore


COPY . ./
RUN ls
RUN pwd
#RUN export LD_LIBRARY_PATH=/lib64
#RUN yum install /lib/ld-linux.so.2
#RUN ln -s /lib64/ld-linux-x86-64.so.2 /lib/ld-linux.so.2
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "gateway.dll"]