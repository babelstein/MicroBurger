FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Kitchen.Api/Kitchen.Api.csproj", "Kitchen.Api/"]
RUN dotnet restore "Kitchen.Api/Kitchen.Api.csproj"
COPY . .
WORKDIR "/src/Kitchen.Api"
RUN dotnet build "Kitchen.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Kitchen.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Kitchen.Api.dll"]