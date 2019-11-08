FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["ColleguesApi/ColleguesApi.csproj", "ColleguesApi/"]
RUN dotnet restore "ColleguesApi/ColleguesApi.csproj"
COPY . .
WORKDIR "/src/ColleguesApi"
RUN dotnet build "ColleguesApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ColleguesApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ColleguesApi.dll"]