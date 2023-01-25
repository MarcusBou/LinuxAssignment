#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LinuxAssignment/LinuxAssignment.csproj", "LinuxAssignment/"]
RUN dotnet restore "LinuxAssignment/LinuxAssignment.csproj"
COPY . .
WORKDIR "/src/LinuxAssignment"
RUN dotnet build "LinuxAssignment.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LinuxAssignment.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LinuxAssignment.dll"]