FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MicroBurger.Api/MicroBurger.Api.csproj", "MicroBurger.Api/"]
RUN dotnet restore "MicroBurger.Api/MicroBurger.Api.csproj"
COPY . .
WORKDIR "/src/MicroBurger.Api"
RUN dotnet build "MicroBurger.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroBurger.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroBurger.Api.dll"]