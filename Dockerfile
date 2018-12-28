#using microsoft dotnet build docker image
FROM microsoft/dotnet:2.2-sdk as build
WORKDIR /app

#copy the service and test project file
COPY *.sln .
COPY StaffManagement/*.csproj ./StaffManagement/
COPY StaffManagement.Test/*.csproj ./StaffManagement.Test/

# then run dotnet restore
RUN dotnet restore

# copy all existing code files
COPY StaffManagement/. ./StaffManagement/
COPY StaffManagement.Test/. ./StaffManagement/

# run dotnet build command for source file
WORKDIR /app/StaffManagement
RUN dotnet build


FROM build AS testrunner
#run dotnet test command test project
WORKDIR /app/StaffManagement.Tests
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

# run test command
FROM build AS test
WORKDIR /app/StaffManagement.Test
RUN dotnet test

# run publish command
FROM build AS publish
WORKDIR /app/StaffManagement
RUN dotnet publish -c Release -o out

# run dotnet command
FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime
WORKDIR /app

# copy executable  
COPY --from=publish /app/StaffManagement/out ./
# run executable
ENTRYPOINT ["dotnet", "StaffManagement.dll"]

