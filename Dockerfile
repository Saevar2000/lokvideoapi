
FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /app

# Copy everything and build app
COPY . .
RUN dotnet publish -c Release -o out

FROM microsoft/aspnetcore:2.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "lokvideoapi.dll"]