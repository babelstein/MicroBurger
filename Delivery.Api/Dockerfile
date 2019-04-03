FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Delivery.Api/Delivery.Api.csproj", "Delivery.Api/"]
RUN dotnet restore "Delivery.Api/Delivery.Api.csproj"
COPY . .
WORKDIR "/src/Delivery.Api"
RUN dotnet build "Delivery.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Delivery.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Delivery.Api.dll"]